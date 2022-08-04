using Newtonsoft.Json;

namespace Pandorax.AutoTrader.Models;

public class Standard
{
    [JsonProperty("bodyType")]
    public string BodyType { get; set; } = null!;

    [JsonProperty("colour")]
    public string? Colour { get; set; }

    [JsonProperty("derivative")]
    public string? Derivative { get; set; }

    [JsonProperty("drivetrain")]
    public string? Drivetrain { get; set; }

    [JsonProperty("fuelType")]
    public string? FuelType { get; set; }

    [JsonProperty("generation")]
    public string? Generation { get; set; }

    [JsonProperty("make")]
    public string Make { get; set; } = null!;

    [JsonProperty("model")]
    public string? Model { get; set; }

    [JsonProperty("transmissionType")]
    public string? TransmissionType { get; set; }

    [JsonProperty("trim")]
    public string? Trim { get; set; }
}
