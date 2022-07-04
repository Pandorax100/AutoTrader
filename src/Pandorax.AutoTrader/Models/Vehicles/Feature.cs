using System.Text.Json.Serialization;

namespace Pandorax.AutoTrader.Models.Vehicles;

public class Feature
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("genericName")]
    public string GenericName { get; set; } = string.Empty;

    [JsonPropertyName("type")]
    public string Type { get; set; } = string.Empty;

    [JsonPropertyName("category")]
    public string Category { get; set; } = string.Empty;

    [JsonPropertyName("basicPrice")]
    public decimal? BasicPrice { get; set; }

    [JsonPropertyName("vatPrice")]
    public decimal? VatPrice { get; set; }

    [JsonPropertyName("factoryFitted")]
    public bool? FactoryFitted { get; set; }
}
