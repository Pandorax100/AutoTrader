using System.Text.Json.Serialization;

namespace Pandorax.AutoTrader.Models.MotTests;

public class MotComment
{
    [JsonPropertyName("type")]
    public string Type { get; set; } = string.Empty;

    [JsonPropertyName("text")]
    public string Text { get; set; } = string.Empty;

    [JsonPropertyName("dangerours")]
    public bool Dangerous { get; set; }
}
