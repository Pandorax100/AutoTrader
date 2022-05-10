using System.Text.Json.Serialization;

namespace Pandorax.AutoTrader.Models;
public class Standard
{
    [JsonPropertyName("bodyType")]
    public string BodyType { get; set; } = null!;

    [JsonPropertyName("colour")]
    public string? Colour { get; set; }

    [JsonPropertyName("derivative")]
    public string? Derivative { get; set; }

    [JsonPropertyName("drivetrain")]
    public Drivetrain? Drivetrain { get; set; }

    [JsonPropertyName("fuelType")]
    public FuelType? FuelType { get; set; }

    [JsonPropertyName("generation")]
    public string? Generation { get; set; }

    [JsonPropertyName("make")]
    public string Make { get; set; } = null!;

    [JsonPropertyName("model")]
    public string? Model { get; set; }

    [JsonPropertyName("transmissionType")]
    public string? TransmissionType { get; set; }

    [JsonPropertyName("trim")]
    public string? Trim { get; set; }
}
