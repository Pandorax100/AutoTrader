using Newtonsoft.Json;
using Pandorax.AutoTrader.Models.MotTests;
using Pandorax.AutoTrader.Models.VehicleCheck;

namespace Pandorax.AutoTrader.Models.Vehicles;

public class VehicleRoot
{
    [JsonProperty("vehicle")]
    public Vehicle Vehicle { get; set; } = null!;

    [JsonProperty("check")]
    public BasicVehicleCheck? Check { get; set; }

    [JsonProperty("messages")]
    public List<AutoTraderMessage>? Messages { get; set; }

    [JsonProperty("features")]
    public List<Feature>? Features { get; set; }

    [JsonProperty("motTests")]
    public List<MotTest>? MotTests { get; set; }
}
