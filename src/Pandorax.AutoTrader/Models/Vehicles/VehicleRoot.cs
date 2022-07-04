using System.Text.Json.Serialization;
using Pandorax.AutoTrader.Models.MotTests;

namespace Pandorax.AutoTrader.Models.Vehicles;

public class VehicleRoot
{
    [JsonPropertyName("vehicle")]
    public Vehicle Vehicle { get; set; } = null!;

    [JsonPropertyName("messages")]
    public List<AutoTraderMessage>? Messages { get; set; }

    [JsonPropertyName("features")]
    public List<Feature>? Features { get; set; }

    [JsonPropertyName("motTests")]
    public List<MotTest>? MotTests { get; set; }
}
