using Newtonsoft.Json;

namespace Pandorax.AutoTrader.Models;

public class StockListResult
{
    [JsonProperty("results")]
    public List<AutoTraderVehicleData> Results { get; set; } = new();


    [JsonProperty("totalResults")]
    public long TotalResults { get; set; }
}
