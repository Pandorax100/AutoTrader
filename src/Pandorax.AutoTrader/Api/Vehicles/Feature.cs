using Newtonsoft.Json;

namespace Pandorax.AutoTrader.Api.Vehicles;

public class Feature
{
    [JsonProperty("name")]
    public string Name { get; set; } = string.Empty;

    [JsonProperty("genericName")]
    public string GenericName { get; set; } = string.Empty;

    [JsonProperty("type")]
    public string Type { get; set; } = string.Empty;

    [JsonProperty("category")]
    public string Category { get; set; } = string.Empty;

    [JsonProperty("basicPrice")]
    public decimal? BasicPrice { get; set; }

    [JsonProperty("vatPrice")]
    public decimal? VatPrice { get; set; }

    [JsonProperty("factoryFitted")]
    public bool? FactoryFitted { get; set; }
}
