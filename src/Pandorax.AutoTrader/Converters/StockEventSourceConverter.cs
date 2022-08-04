using Newtonsoft.Json;
using Pandorax.AutoTrader.Api.Notifications;

namespace Pandorax.AutoTrader.Converters;

internal class StockEventSourceConverter : JsonConverter<StockEventSource>
{
    public override StockEventSource ReadJson(JsonReader reader, Type objectType, StockEventSource existingValue, bool hasExistingValue, JsonSerializer serializer)
    {
        return (string?)reader.Value switch
        {
            "FEED" => StockEventSource.Feed,
            "OTHER" => StockEventSource.Other,
            "PORTAL" => StockEventSource.Portal,
            "STOCK_MANAGEMENT_API" => StockEventSource.StockManagementApi,
            _ => throw new ArgumentException("Cannot unmarshal type StockEventSource", nameof(reader)),
        };
    }

    public override void WriteJson(JsonWriter writer, StockEventSource value, JsonSerializer serializer)
    {
        writer.WriteValue(value switch
        {
            StockEventSource.Feed => "FEED",
            StockEventSource.Other => "OTHER",
            StockEventSource.Portal => "PORTAL",
            StockEventSource.StockManagementApi => "STOCK_MANAGEMENT_API",
            _ => throw new ArgumentOutOfRangeException(nameof(value), "Cannot marshal type StockEventSource"),
        });
    }
}
