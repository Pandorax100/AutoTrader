using System.Text.Json.Serialization;
using Pandorax.AutoTrader.Models.MotTests;
using Pandorax.AutoTrader.Models.VehicleCheck;

namespace Pandorax.AutoTrader.Models.Vehicles;

public class VehicleRoot
{
    [JsonPropertyName("vehicle")]
    public Vehicle Vehicle { get; set; } = null!;

    [JsonPropertyName("check")]
    public BasicVehicleCheck? Check { get; set; }

    [JsonPropertyName("messages")]
    public List<AutoTraderMessage>? Messages { get; set; }

    [JsonPropertyName("features")]
    public List<Feature>? Features { get; set; }

    [JsonPropertyName("motTests")]
    public List<MotTest>? MotTests { get; set; }
}
