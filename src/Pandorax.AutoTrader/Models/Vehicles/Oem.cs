using Newtonsoft.Json;

namespace Pandorax.AutoTrader.Models.Vehicles;

public class Oem
{
    [JsonProperty("make")]
    public string? Make { get; set; }

    [JsonProperty("model")]
    public string? Model { get; set; }

    [JsonProperty("derivative")]
    public string? Derivative { get; set; }

    [JsonProperty("bodyType")]
    public string? BodyType { get; set; }

    [JsonProperty("transmissionType")]
    public string? TransmissionType { get; set; }

    [JsonProperty("drivetrain")]
    public string? Drivetrain { get; set; }

    [JsonProperty("wheelbaseType")]
    public string? WheelbaseType { get; set; }

    [JsonProperty("roofHeightType")]
    public string? RoofHeightType { get; set; }

    [JsonProperty("engineType")]
    public string? EngineType { get; set; }

    [JsonProperty("engineTechnology")]
    public string? EngineTechnology { get; set; }

    [JsonProperty("engineMarketing")]
    public string? EngineMarketing { get; set; }

    [JsonProperty("editionDescription")]
    public string? EditionDescription { get; set; }

    [JsonProperty("colour")]
    public string? Colour { get; set; }
}
