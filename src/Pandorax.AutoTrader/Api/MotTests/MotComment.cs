using Newtonsoft.Json;

namespace Pandorax.AutoTrader.Api.MotTests;

public class MotComment
{
    [JsonProperty("type")]
    public string Type { get; set; } = string.Empty;

    [JsonProperty("text")]
    public string Text { get; set; } = string.Empty;

    [JsonProperty("dangerours")]
    public bool Dangerous { get; set; }
}
