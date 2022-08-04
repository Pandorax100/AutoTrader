using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Pandorax.AutoTrader.Converters;
using Pandorax.AutoTrader.Utils;

namespace Pandorax.AutoTrader.Serializer
{
    internal class AutoTraderContractResolver : DefaultContractResolver
    {
        private static readonly MethodInfo _shouldSerialize = typeof(AutoTraderContractResolver)
            .GetTypeInfo()
            .GetDeclaredMethod(nameof(ShouldSerialize)) ?? throw new InvalidOperationException("The ShouldSerialize method could not be found");

        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
        {
            var property = base.CreateProperty(member, memberSerialization);
            if (property.Ignored)
            {
                return property;
            }

            if (member is PropertyInfo propInfo)
            {
                var converter = GetConverter(property, propInfo, propInfo.PropertyType, 0);
                if (converter != null)
                {
                    property.Converter = converter;
                }
            }
            else
            {
                throw new InvalidOperationException($"{member.DeclaringType?.FullName}.{member.Name} is not a property.");
            }

            return property;
        }

        private static JsonConverter? GetConverter(JsonProperty property, PropertyInfo propInfo, Type type, int depth)
        {
            if (!type.IsConstructedGenericType)
            {
                return null;
            }

            Type genericType = type.GetGenericTypeDefinition();
            if (depth == 0 && genericType == typeof(Optional<>))
            {
                Type? typeInput = propInfo.DeclaringType;
                if (typeInput is null)
                {
                    return null;
                }

                Type innerTypeOutput = type.GenericTypeArguments[0];

                Type getter = typeof(Func<,>).MakeGenericType(typeInput, type);
                Delegate getterDelegate = propInfo.GetMethod!.CreateDelegate(getter);
                MethodInfo shouldSerialize = _shouldSerialize.MakeGenericMethod(typeInput, innerTypeOutput);
                Func<object, Delegate, bool> shouldSerializeDelegate = (Func<object, Delegate, bool>)shouldSerialize.CreateDelegate(typeof(Func<object, Delegate, bool>));
                property.ShouldSerialize = x => shouldSerializeDelegate(x, getterDelegate);

                return MakeGenericConverter(property, propInfo, typeof(OptionalConverter<>), innerTypeOutput, depth);
            }

            return null;
        }

        private static bool ShouldSerialize<TOwner, TValue>(object owner, Delegate getter)
        {
            return (getter as Func<TOwner, Optional<TValue>>)!((TOwner)owner).IsSpecified;
        }

        private static JsonConverter? MakeGenericConverter(JsonProperty property, PropertyInfo propInfo, Type converterType, Type innerType, int depth)
        {
            var genericType = converterType.MakeGenericType(innerType).GetTypeInfo();
            var innerConverter = GetConverter(property, propInfo, innerType, depth + 1);
            return genericType.DeclaredConstructors.First().Invoke(new object?[] { innerConverter }) as JsonConverter;
        }
    }
}
