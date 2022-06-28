using System.Text.Json.Serialization;

namespace Pandorax.AutoTrader.Models;

public class AutoTraderVehicleData
{
    [JsonPropertyName("advertiser")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Advertiser? Advertiser { get; set; }

    [JsonPropertyName("adverts")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Adverts? Adverts { get; set; }

    [JsonPropertyName("check")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Check? Check { get; set; }

    [JsonPropertyName("features")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public List<Feature> Features { get; set; } = new();

    [JsonPropertyName("media")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Media? Media { get; set; }

    [JsonPropertyName("metadata")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Metadata? Metadata { get; set; }

    [JsonPropertyName("vehicle")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Vehicle? Vehicle { get; set; }
}
