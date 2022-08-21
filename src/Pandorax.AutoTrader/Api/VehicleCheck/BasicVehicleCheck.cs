using Newtonsoft.Json;

namespace Pandorax.AutoTrader.Api.VehicleCheck;

public class BasicVehicleCheck
{
    [JsonProperty("exported")]
    public bool Exported { get; set; }

    [JsonProperty("imported")]
    public bool Imported { get; set; }

    [JsonProperty("insuranceWriteoffCategory")]
    public string? InsuranceWriteoffCategory { get; set; }

    [JsonProperty("keeperChanges")]
    public List<KeeperChange> KeeperChanges { get; set; } = new();

    [JsonProperty("previousOwners")]
    public int? PreviousOwners { get; set; }

    [JsonProperty("scrapped")]
    public bool Scrapped { get; set; }

    [JsonProperty("stolen")]
    public bool Stolen { get; set; }

    [JsonProperty("v5cs")]
    public List<V5C> V5Cs { get; set; } = new();
}
