using Newtonsoft.Json;
using Pandorax.AutoTrader.Api.MotTests;
using Pandorax.AutoTrader.Api.Stock.Common;
using Pandorax.AutoTrader.Api.VehicleCheck;

namespace Pandorax.AutoTrader.Api.Vehicles;

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
