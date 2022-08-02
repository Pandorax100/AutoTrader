using System.Text.Json.Serialization;

namespace Pandorax.AutoTrader.Models;
public class Metadata
{
    [JsonPropertyName("dateOnForecourt")]
    public DateTime DateOnForecourt { get; set; }

    [JsonPropertyName("externalStockId")]
    public string ExternalStockId { get; set; } = null!;

    [JsonPropertyName("externalStockReference")]
    public string? ExternalStockReference { get; set; }

    [JsonPropertyName("lastUpdated")]
    public DateTime LastUpdated { get; set; }

    [JsonPropertyName("lastUpdatedByAdvertiser")]
    public DateTime LastUpdatedByAdvertiser { get; set; }

    [JsonPropertyName("lifecycleState")]
    public LifecycleState LifecycleState { get; set; }

    [JsonPropertyName("searchId")]
    public string SearchId { get; set; } = null!;

    [JsonPropertyName("stockId")]
    public string StockId { get; set; } = null!;

    [JsonPropertyName("versionNumber")]
    public int VersionNumber { get; set; }
}
