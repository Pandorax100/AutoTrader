using System.Text.Json;
using System.Text.Json.Serialization;
using Pandorax.AutoTrader.Models;

namespace Pandorax.AutoTrader.Converters;
internal class EmissionClassConverter : JsonConverter<EmissionClass>
{
    public override EmissionClass Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        return reader.GetString() switch
        {
            "Euro 2" => EmissionClass.Euro2,
            "Euro 3" => EmissionClass.Euro3,
            "Euro 4" => EmissionClass.Euro4,
            "Euro 5" => EmissionClass.Euro5,
            "Euro 6" => EmissionClass.Euro6,
            _ => throw new ArgumentException("Cannot unmarshal type EmissionClass", nameof(reader)),
        };
    }

    public override void Write(Utf8JsonWriter writer, EmissionClass value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value switch
        {
            EmissionClass.Euro2 => "Euro 2",
            EmissionClass.Euro3 => "Euro 3",
            EmissionClass.Euro4 => "Euro 4",
            EmissionClass.Euro5 => "Euro 5",
            EmissionClass.Euro6 => "Euro 6",
            _ => throw new ArgumentOutOfRangeException(nameof(value)),
        });
    }
}
