using Newtonsoft.Json;
using Pandorax.AutoTrader.Api.Stock.Read;

namespace Pandorax.AutoTrader.Api.Notifications;

public class AutoTraderNotification
{
    [JsonProperty("clientId")]
    public string? ClientId { get; set; }

    [JsonProperty("data")]
    public AutoTraderVehicleData Data { get; set; } = null!;

    [JsonProperty("id")]
    public string Id { get; set; } = null!;

    [JsonProperty("stockEventSource")]
    public StockEventSource? StockEventSource { get; set; }

    [JsonProperty("time")]
    public DateTimeOffset Time { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; } = null!;
}
