using System.Text.Json;
using System.Text.Json.Serialization;
using Pandorax.AutoTrader.Models;

namespace Pandorax.AutoTrader.Converters;
internal class OwnershipConditionConverter : JsonConverter<OwnershipCondition>
{
    public override OwnershipCondition Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        return reader.GetString() switch
        {
            "New" => OwnershipCondition.New,
            "Used" => OwnershipCondition.Used,
            _ => throw new ArgumentException("Cannot unmarshal type OwnershipCondition", nameof(reader)),
        };
    }

    public override void Write(Utf8JsonWriter writer, OwnershipCondition value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value switch
        {
            OwnershipCondition.New => "New",
            OwnershipCondition.Used => "Used",
            _ => throw new ArgumentOutOfRangeException(nameof(value)),
        });
    }
}
