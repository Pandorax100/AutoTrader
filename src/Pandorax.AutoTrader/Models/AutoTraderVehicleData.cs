using Newtonsoft.Json;

namespace Pandorax.AutoTrader.Models;

public class AutoTraderVehicleData
{
    [JsonProperty("advertiser")]
    public Advertiser? Advertiser { get; set; }

    [JsonProperty("adverts")]
    public Adverts? Adverts { get; set; }

    [JsonProperty("check")]
    public Check? Check { get; set; }

    [JsonProperty("features")]
    public List<Feature> Features { get; set; } = new();

    [JsonProperty("media")]
    public Media? Media { get; set; }

    [JsonProperty("metadata")]
    public Metadata? Metadata { get; set; }

    [JsonProperty("vehicle")]
    public Vehicle? Vehicle { get; set; }

    [JsonProperty("messages")]
    public List<AutoTraderMessage>? Messages { get; set; }
}
