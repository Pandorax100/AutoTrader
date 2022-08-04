using Newtonsoft.Json;
using Pandorax.AutoTrader.Utils;

namespace Pandorax.AutoTrader.Api.Stock.Update;

public class DisplayOptions
{
    [JsonProperty("excludeBodyCondition")]
    public Optional<bool> ExcludeBodyCondition { get; set; }

    [JsonProperty("excludeInteriorDetails")]
    public Optional<bool> ExcludeInteriorDetails { get; set; }

    [JsonProperty("excludeMot")]
    public Optional<bool> ExcludeMot { get; set; }

    [JsonProperty("excludePreviousOwners")]
    public Optional<bool> ExcludePreviousOwners { get; set; }

    [JsonProperty("excludeStrapline")]
    public Optional<bool> ExcludeStrapline { get; set; }

    [JsonProperty("excludeTyreCondition")]
    public Optional<bool> ExcludeTyreCondition { get; set; }

    [JsonProperty("excludeWarranty")]
    public Optional<bool> ExcludeWarranty { get; set; }
}
