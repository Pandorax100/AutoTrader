using System.Text.Json.Serialization;

namespace Pandorax.AutoTrader.Models.VehicleCheck;

public class BasicVehicleCheck
{
    [JsonPropertyName("exported")]
    public bool Exported { get; set; }

    [JsonPropertyName("imported")]
    public bool Imported { get; set; }

    [JsonPropertyName("insuranceWriteoffCategory")]
    public string? InsuranceWriteoffCategory { get; set; }

    [JsonPropertyName("keeperChanges")]
    public List<KeeperChange> KeeperChanges { get; set; } = new();

    [JsonPropertyName("previousOwners")]
    public int PreviousOwners { get; set; }

    [JsonPropertyName("scrapped")]
    public bool Scrapped { get; set; }

    [JsonPropertyName("stolen")]
    public bool Stolen { get; set; }

    [JsonPropertyName("v5cs")]
    public List<V5C> V5Cs { get; set; } = new();
}
