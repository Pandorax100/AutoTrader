using Newtonsoft.Json;

namespace Pandorax.AutoTrader.Models.VehicleCheck;

public class KeeperChange
{
    [JsonProperty("dateOfLastKeeper")]
    public DateOnly DateOfLastKeeper { get; set; }
}
