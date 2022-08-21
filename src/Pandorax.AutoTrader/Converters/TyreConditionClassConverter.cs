using Newtonsoft.Json;
using Pandorax.AutoTrader.Api.Stock.Common;

namespace Pandorax.AutoTrader.Converters;

internal class TyreConditionClassConverter : JsonConverter<TyreCondition?>
{
    public override TyreCondition? ReadJson(JsonReader reader, Type objectType, TyreCondition? existingValue, bool hasExistingValue, JsonSerializer serializer)
    {
        var value = (string?)reader.Value;

        if (value is null)
        {
            return null;
        }

        if (string.Equals(value, "New Tyres Required", StringComparison.OrdinalIgnoreCase))
        {
            return TyreCondition.NewTyresRequired;
        }

        return Enum.TryParse(value, ignoreCase: true, out TyreCondition tyreCondition) ? tyreCondition : null;
    }

    public override void WriteJson(JsonWriter writer, TyreCondition? value, JsonSerializer serializer)
    {
        if (value is null)
        {
            writer.WriteNull();
        }
        else if (value == TyreCondition.NewTyresRequired)
        {
            writer.WriteValue("New Tyres Required");
        }
        else
        {
            writer.WriteValue(value.ToString());
        }
    }
}
