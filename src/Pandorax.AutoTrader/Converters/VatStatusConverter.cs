using System.Text.Json;
using System.Text.Json.Serialization;
using Pandorax.AutoTrader.Models;

namespace Pandorax.AutoTrader.Converters;

internal class VatStatusConverter : JsonConverter<VatStatus?>
{
    public override VatStatus? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        return reader.GetString() switch
        {
            "Ex VAT" => VatStatus.ExVat,
            "Inc VAT" => VatStatus.IncVat,
            "No VAT" => VatStatus.NoVat,
            _ => null,
        };
    }

    public override void Write(Utf8JsonWriter writer, VatStatus? value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value switch
        {
            VatStatus.ExVat => "Ex VAT",
            VatStatus.IncVat => "Inc VAT",
            VatStatus.NoVat => "No VAT",
            _ => null,
        });
    }
}
