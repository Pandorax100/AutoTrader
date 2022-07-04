using System.Text.Json.Serialization;

namespace Pandorax.AutoTrader.Models.Vehicles;

public class Oem
{
    [JsonPropertyName("make")]
    public string? Make { get; set; }

    [JsonPropertyName("model")]
    public string? Model { get; set; }

    [JsonPropertyName("derivative")]
    public string? Derivative { get; set; }

    [JsonPropertyName("bodyType")]
    public string? BodyType { get; set; }

    [JsonPropertyName("transmissionType")]
    public string? TransmissionType { get; set; }

    [JsonPropertyName("drivetrain")]
    public string? Drivetrain { get; set; }

    [JsonPropertyName("wheelbaseType")]
    public string? WheelbaseType { get; set; }

    [JsonPropertyName("roofHeightType")]
    public string? RoofHeightType { get; set; }

    [JsonPropertyName("engineType")]
    public string? EngineType { get; set; }

    [JsonPropertyName("engineTechnology")]
    public string? EngineTechnology { get; set; }

    [JsonPropertyName("engineMarketing")]
    public string? EngineMarketing { get; set; }

    [JsonPropertyName("editionDescription")]
    public string? EditionDescription { get; set; }

    [JsonPropertyName("colour")]
    public string? Colour { get; set; }
}
