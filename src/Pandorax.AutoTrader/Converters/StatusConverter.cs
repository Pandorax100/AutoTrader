using System.Text.Json;
using System.Text.Json.Serialization;
using Pandorax.AutoTrader.Models;

namespace Pandorax.AutoTrader.Converters;
internal class StatusConverter : JsonConverter<Status>
{
    public override Status Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        return reader.GetString() switch
        {
            "CAPPED" => Status.Capped,
            "NOT_PUBLISHED" => Status.NotPublished,
            "PUBLISHED" => Status.Published,
            "REJECTED" => Status.Rejected,
            _ => throw new ArgumentException("Cannot unmarshal type Status", nameof(reader)),
        };
    }

    public override void Write(Utf8JsonWriter writer, Status value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value switch
        {
            Status.Capped => "CAPPED",
            Status.NotPublished => "NOT_PUBLISHED",
            Status.Published => "PUBLISHED",
            Status.Rejected => "REJECTED",
            _ => throw new ArgumentOutOfRangeException(nameof(value)),
        });
    }
}
