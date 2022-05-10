using System.Text.Json.Serialization;

namespace Pandorax.AutoTrader.Models;
public class DisplayOptions
{
    [JsonPropertyName("excludeBodyCondition")]
    public bool ExcludeBodyCondition { get; set; }

    [JsonPropertyName("excludeInteriorDetails")]
    public bool ExcludeInteriorDetails { get; set; }

    [JsonPropertyName("excludeMot")]
    public bool ExcludeMot { get; set; }

    [JsonPropertyName("excludePreviousOwners")]
    public bool ExcludePreviousOwners { get; set; }

    [JsonPropertyName("excludeStrapline")]
    public bool ExcludeStrapline { get; set; }

    [JsonPropertyName("excludeTyreCondition")]
    public bool ExcludeTyreCondition { get; set; }

    [JsonPropertyName("excludeWarranty")]
    public bool ExcludeWarranty { get; set; }
}
