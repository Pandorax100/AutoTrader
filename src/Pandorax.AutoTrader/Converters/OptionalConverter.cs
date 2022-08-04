using Newtonsoft.Json;
using Pandorax.AutoTrader.Utils;

namespace Pandorax.AutoTrader.Converters;

internal class OptionalConverter<T> : JsonConverter
{
    private readonly JsonConverter _innerConverter;

    public OptionalConverter(JsonConverter innerConverter)
    {
        _innerConverter = innerConverter;
    }

    public override bool CanRead => true;
    public override bool CanWrite => true;

    public override bool CanConvert(Type objectType) => true;

    public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
    {
        throw new NotImplementedException();
    }

    public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
    {
        value = ((Optional<T>)value!).Value;

        if (_innerConverter != null)
        {
            _innerConverter.WriteJson(writer, value, serializer);
        }
        else
        {
            serializer.Serialize(writer, value, typeof(T));
        }
    }
}
