using Newtonsoft.Json;
using Pandorax.AutoTrader.Api.Stock.Common;

namespace Pandorax.AutoTrader.Converters;

internal class StatusConverter : JsonConverter<Status>
{
    public override Status ReadJson(JsonReader reader, Type objectType, Status existingValue, bool hasExistingValue, JsonSerializer serializer)
    {
        return (string?)reader.Value switch
        {
            "CAPPED" => Status.Capped,
            "NOT_PUBLISHED" => Status.NotPublished,
            "PUBLISHED" => Status.Published,
            "REJECTED" => Status.Rejected,
            _ => throw new ArgumentException("Cannot unmarshal type Status", nameof(reader)),
        };
    }

    public override void WriteJson(JsonWriter writer, Status value, JsonSerializer serializer)
    {
        writer.WriteValue(value switch
        {
            Status.Capped => "CAPPED",
            Status.NotPublished => "NOT_PUBLISHED",
            Status.Published => "PUBLISHED",
            Status.Rejected => "REJECTED",
            _ => throw new ArgumentOutOfRangeException(nameof(value)),
        });
    }
}
