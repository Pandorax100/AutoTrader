using System.Text.Json.Serialization;

namespace Pandorax.AutoTrader.Models;
public class Feature
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;

    [JsonPropertyName("type")]
    public FeatureType Type { get; set; }
}
