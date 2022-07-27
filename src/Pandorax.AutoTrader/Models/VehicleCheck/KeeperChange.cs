using System.Text.Json.Serialization;

namespace Pandorax.AutoTrader.Models.VehicleCheck;

public class KeeperChange
{
    [JsonPropertyName("dateOfLastKeeper")]
    public DateOnly DateOfLastKeeper { get; set; }
}
