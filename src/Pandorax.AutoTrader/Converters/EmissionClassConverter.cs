using Newtonsoft.Json;
using Pandorax.AutoTrader.Api.Stock.Common;

namespace Pandorax.AutoTrader.Converters;

internal class EmissionClassConverter : JsonConverter<EmissionClass?>
{
    public override EmissionClass? ReadJson(JsonReader reader, Type objectType, EmissionClass? existingValue, bool hasExistingValue, JsonSerializer serializer)
    {
        return (string?)reader.Value switch
        {
            "Euro 1" => EmissionClass.Euro1,
            "Euro 2" => EmissionClass.Euro2,
            "Euro 3" => EmissionClass.Euro3,
            "Euro 4" => EmissionClass.Euro4,
            "Euro 5" => EmissionClass.Euro5,
            "Euro 6" => EmissionClass.Euro6,
            _ => null,
        };
    }

    public override void WriteJson(JsonWriter writer, EmissionClass? value, JsonSerializer serializer)
    {
        if (value is null)
        {
            writer.WriteNull();
        }
        else
        {
            writer.WriteValue(value switch
            {
                EmissionClass.Euro1 => "Euro 1",
                EmissionClass.Euro2 => "Euro 2",
                EmissionClass.Euro3 => "Euro 3",
                EmissionClass.Euro4 => "Euro 4",
                EmissionClass.Euro5 => "Euro 5",
                EmissionClass.Euro6 => "Euro 6",
                _ => throw new ArgumentOutOfRangeException(nameof(value)),
            });
        }
    }
}
