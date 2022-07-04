using System.Text.Json.Serialization;

namespace Pandorax.AutoTrader.Models;

public class AutoTraderMessage
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("message")]
    public string Message { get; set; }
}
