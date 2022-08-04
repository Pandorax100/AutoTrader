using Newtonsoft.Json;

namespace Pandorax.AutoTrader.Api.Stock.Common;

public class AutoTraderMessage
{
    [JsonProperty("feature")]
    public string? Feature { get; set; }

    [JsonProperty("message")]
    public string? Message { get; set; }

    [JsonProperty("type")]
    public string? Type { get; set; }
}
