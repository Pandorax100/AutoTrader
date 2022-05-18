using System.Text.Json.Serialization;

namespace Pandorax.AutoTrader.Models;

public class AutoTraderVehicleData
{
    [JsonPropertyName("advertiser")]
    public Advertiser Advertiser { get; set; } = null!;

    [JsonPropertyName("adverts")]
    public Adverts Adverts { get; set; } = null!;

    [JsonPropertyName("check")]
    public Check Check { get; set; } = null!;

    [JsonPropertyName("features")]
    public List<Feature> Features { get; set; } = null!;

    [JsonPropertyName("media")]
    public Media Media { get; set; } = null!;

    [JsonPropertyName("metadata")]
    public Metadata Metadata { get; set; } = null!;

    [JsonPropertyName("vehicle")]
    public Vehicle Vehicle { get; set; } = null!;
}
