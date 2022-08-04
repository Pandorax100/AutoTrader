using Newtonsoft.Json;

namespace Pandorax.AutoTrader.Models;
public class DisplayOptions
{
    [JsonProperty("excludeBodyCondition")]
    public bool ExcludeBodyCondition { get; set; }

    [JsonProperty("excludeInteriorDetails")]
    public bool ExcludeInteriorDetails { get; set; }

    [JsonProperty("excludeMot")]
    public bool ExcludeMot { get; set; }

    [JsonProperty("excludePreviousOwners")]
    public bool ExcludePreviousOwners { get; set; }

    [JsonProperty("excludeStrapline")]
    public bool ExcludeStrapline { get; set; }

    [JsonProperty("excludeTyreCondition")]
    public bool ExcludeTyreCondition { get; set; }

    [JsonProperty("excludeWarranty")]
    public bool ExcludeWarranty { get; set; }
}
