using Newtonsoft.Json;
using Pandorax.AutoTrader.Api.Stock.Common;

namespace Pandorax.AutoTrader.Api.Stock.Read;

public class Metadata
{
    [JsonProperty("dateOnForecourt")]
    public DateTime DateOnForecourt { get; set; }

    [JsonProperty("externalStockId")]
    public string ExternalStockId { get; set; } = null!;

    [JsonProperty("externalStockReference")]
    public string? ExternalStockReference { get; set; }

    [JsonProperty("lastUpdated")]
    public DateTime LastUpdated { get; set; }

    [JsonProperty("lastUpdatedByAdvertiser")]
    public DateTime LastUpdatedByAdvertiser { get; set; }

    [JsonProperty("lifecycleState")]
    public LifecycleState LifecycleState { get; set; }

    [JsonProperty("searchId")]
    public string SearchId { get; set; } = null!;

    [JsonProperty("stockId")]
    public string StockId { get; set; } = null!;

    [JsonProperty("versionNumber")]
    public int VersionNumber { get; set; }
}
