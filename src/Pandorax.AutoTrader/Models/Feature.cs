using Newtonsoft.Json;

namespace Pandorax.AutoTrader.Models;
public class Feature
{
    [JsonProperty("name")]
    public string Name { get; set; } = null!;

    [JsonProperty("type")]
    public FeatureType Type { get; set; }
}
