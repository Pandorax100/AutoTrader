using Newtonsoft.Json;
using Pandorax.AutoTrader.Api.Stock.Common;
using Pandorax.AutoTrader.Utils;

namespace Pandorax.AutoTrader.Api.Stock.Update;

public class Metadata
{
    [JsonProperty("dateOnForecourt")]
    public Optional<DateTime> DateOnForecourt { get; set; }

    [JsonProperty("externalStockId")]
    public Optional<string> ExternalStockId { get; set; }

    [JsonProperty("externalStockReference")]
    public Optional<string?> ExternalStockReference { get; set; }

    [JsonProperty("lastUpdated")]
    public Optional<DateTime> LastUpdated { get; set; }

    [JsonProperty("lastUpdatedByAdvertiser")]
    public Optional<DateTime> LastUpdatedByAdvertiser { get; set; }

    [JsonProperty("lifecycleState")]
    public Optional<LifecycleState> LifecycleState { get; set; }

    [JsonProperty("searchId")]
    public Optional<string> SearchId { get; set; }

    [JsonProperty("stockId")]
    public Optional<string> StockId { get; set; }

    [JsonProperty("versionNumber")]
    public Optional<int> VersionNumber { get; set; }
}
