using System.Text.Json.Serialization;

namespace Pandorax.AutoTrader.Models;

public class AutoTraderMessage
{
    [JsonPropertyName("feature")]
    public string? Feature { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
