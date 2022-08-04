using Newtonsoft.Json;
using Pandorax.AutoTrader.Models;

namespace Pandorax.AutoTrader.Converters;

internal class OwnershipConditionConverter : JsonConverter<OwnershipCondition>
{
    public override OwnershipCondition ReadJson(JsonReader reader, Type objectType, OwnershipCondition existingValue, bool hasExistingValue, JsonSerializer serializer)
    {
        return (string?)reader.Value switch
        {
            "New" => OwnershipCondition.New,
            "Used" => OwnershipCondition.Used,
            _ => throw new ArgumentException("Cannot unmarshal type OwnershipCondition", nameof(reader)),
        };
    }

    public override void WriteJson(JsonWriter writer, OwnershipCondition value, JsonSerializer serializer)
    {
        writer.WriteValue(value switch
        {
            OwnershipCondition.New => "New",
            OwnershipCondition.Used => "Used",
            _ => throw new ArgumentOutOfRangeException(nameof(value)),
        });
    }
}
