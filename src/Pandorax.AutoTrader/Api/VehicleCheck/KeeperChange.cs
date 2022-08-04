using Newtonsoft.Json;

namespace Pandorax.AutoTrader.Api.VehicleCheck;

public class KeeperChange
{
    [JsonProperty("dateOfLastKeeper")]
    public DateOnly DateOfLastKeeper { get; set; }
}
