using System.Text.Json.Serialization;

namespace Pandorax.AutoTrader.Models;
public class AutoTraderNotification
{
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    [JsonPropertyName("data")]
    public AutoTraderVehicleData Data { get; set; } = null!;

    [JsonPropertyName("id")]
    public string Id { get; set; } = null!;

    [JsonPropertyName("stockEventSource")]
    public StockEventSource? StockEventSource { get; set; }

    [JsonPropertyName("time")]
    public DateTimeOffset Time { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; } = null!;
}
