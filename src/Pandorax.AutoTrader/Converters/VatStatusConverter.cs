using Newtonsoft.Json;
using Pandorax.AutoTrader.Models;

namespace Pandorax.AutoTrader.Converters;

internal class VatStatusConverter : JsonConverter<VatStatus?>
{
    public override VatStatus? ReadJson(JsonReader reader, Type objectType, VatStatus? existingValue, bool hasExistingValue, JsonSerializer serializer)
    {
        return (string?)reader.Value switch
        {
            "Ex VAT" => VatStatus.ExVat,
            "Inc VAT" => VatStatus.IncVat,
            "No VAT" => VatStatus.NoVat,
            _ => null,
        };
    }

    public override void WriteJson(JsonWriter writer, VatStatus? value, JsonSerializer serializer)
    {
        writer.WriteValue(value switch
        {
            VatStatus.ExVat => "Ex VAT",
            VatStatus.IncVat => "Inc VAT",
            VatStatus.NoVat => "No VAT",
            _ => null,
        });
    }
}
