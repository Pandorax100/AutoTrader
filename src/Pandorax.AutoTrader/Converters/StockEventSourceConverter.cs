using System.Text.Json;
using System.Text.Json.Serialization;
using Pandorax.AutoTrader.Models;

namespace Pandorax.AutoTrader.Converters;

internal class StockEventSourceConverter : JsonConverter<StockEventSource>
{
    public override StockEventSource Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        return reader.GetString() switch
        {
            "FEED" => StockEventSource.Feed,
            "OTHER" => StockEventSource.Other,
            "PORTAL" => StockEventSource.Portal,
            "STOCK_MANAGEMENT_API" => StockEventSource.StockManagementApi,
            _ => throw new ArgumentException("Cannot unmarshal type StockEventSource", nameof(reader)),
        };
    }

    public override void Write(Utf8JsonWriter writer, StockEventSource value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value switch
        {
            StockEventSource.Feed => "FEED",
            StockEventSource.Other => "OTHER",
            StockEventSource.Portal => "PORTAL",
            StockEventSource.StockManagementApi => "STOCK_MANAGEMENT_API",
            _ => throw new ArgumentOutOfRangeException(nameof(value), "Cannot marshal type StockEventSource"),
        });
    }
}
