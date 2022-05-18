using System.Text.Json.Serialization;

namespace Pandorax.AutoTrader.Models;

public class StockListResult
{
    [JsonPropertyName("results")]
    public List<AutoTraderVehicleData> Results { get; set; } = new();


    [JsonPropertyName("totalResults")]
    public long TotalResults { get; set; }
}
