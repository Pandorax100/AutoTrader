using System.Text.Json.Serialization;

namespace Pandorax.AutoTrader.Models;
public class Metadata
{
    [JsonPropertyName("dateOnForecourt")]
    public DateTimeOffset DateOnForecourt { get; set; }

    [JsonPropertyName("externalStockId")]
    public string ExternalStockId { get; set; } = null!;

    [JsonPropertyName("externalStockReference")]
    public string? ExternalStockReference { get; set; }

    [JsonPropertyName("lastUpdated")]
    public DateTimeOffset LastUpdated { get; set; }

    [JsonPropertyName("lastUpdatedByAdvertiser")]
    public DateTimeOffset LastUpdatedByAdvertiser { get; set; }

    [JsonPropertyName("lifecycleState")]
    public LifecycleState LifecycleState { get; set; }

    [JsonPropertyName("searchId")]
    public string SearchId { get; set; } = null!;

    [JsonPropertyName("stockId")]
    public string StockId { get; set; } = null!;

    [JsonPropertyName("versionNumber")]
    public int VersionNumber { get; set; }
}
