using System.Text.Json.Serialization;

namespace Pandorax.AutoTrader.Models;
public class Vehicle
{
    [JsonPropertyName("axleConfiguration")]
    public string? AxleConfiguration { get; set; }

    [JsonPropertyName("badgeEngineSizeLitres")]
    public double? BadgeEngineSizeLitres { get; set; }

    [JsonPropertyName("bedroomLayout")]
    public string? BedroomLayout { get; set; }

    [JsonPropertyName("berths")]
    public int? Berths { get; set; }

    [JsonPropertyName("bodyCondition")]
    public string? BodyCondition { get; set; }

    [JsonPropertyName("bodyType")]
    public string? BodyType { get; set; }

    [JsonPropertyName("bootSpaceSeatsDownLitres")]
    public double? BootSpaceSeatsDownLitres { get; set; }

    [JsonPropertyName("bootSpaceSeatsUpLitres")]
    public double? BootSpaceSeatsUpLitres { get; set; }

    [JsonPropertyName("cabType")]
    public string? CabType { get; set; }

    [JsonPropertyName("co2EmissionGPKM")]
    public int? Co2EmissionGpkm { get; set; }

    [JsonPropertyName("colour")]
    public string? Colour { get; set; }

    [JsonPropertyName("derivative")]
    public string? Derivative { get; set; }

    [JsonPropertyName("derivativeId")]
    public string? DerivativeId { get; set; }

    [JsonPropertyName("doors")]
    public int? Doors { get; set; }

    [JsonPropertyName("driverPosition")]
    public string DriverPosition { get; set; } = null!;

    [JsonPropertyName("drivetrain")]
    public Drivetrain? Drivetrain { get; set; }

    [JsonPropertyName("emissionClass")]
    public EmissionClass? EmissionClass { get; set; }

    [JsonPropertyName("endLayout")]
    public string? EndLayout { get; set; }

    [JsonPropertyName("engineCapacityCC")]
    public int? EngineCapacityCc { get; set; }

    [JsonPropertyName("enginePowerBHP")]
    public double? EnginePowerBhp { get; set; }

    [JsonPropertyName("exDemo")]
    public bool ExDemo { get; set; }

    [JsonPropertyName("exteriorFinish")]
    public string? ExteriorFinish { get; set; }

    [JsonPropertyName("firstRegistrationDate")]
    public DateTimeOffset? FirstRegistrationDate { get; set; }

    [JsonPropertyName("fuelCapacityLitres")]
    public double? FuelCapacityLitres { get; set; }

    [JsonPropertyName("fuelEconomyNEDCCombinedMPG")]
    public double? FuelEconomyNedcCombinedMpg { get; set; }

    [JsonPropertyName("fuelEconomyNEDCExtraUrbanMPG")]
    public double? FuelEconomyNedcExtraUrbanMpg { get; set; }

    [JsonPropertyName("fuelEconomyNEDCUrbanMPG")]
    public double? FuelEconomyNedcUrbanMpg { get; set; }

    [JsonPropertyName("fuelEconomyWLTPCombinedMPG")]
    public double? FuelEconomyWltpCombinedMpg { get; set; }

    [JsonPropertyName("fuelType")]
    public FuelType? FuelType { get; set; }

    [JsonPropertyName("heightMM")]
    public int? HeightMm { get; set; }

    [JsonPropertyName("insuranceGroup")]
    public string? InsuranceGroup { get; set; }

    [JsonPropertyName("insuranceSecurityCode")]
    public Insurance? InsuranceSecurityCode { get; set; }

    [JsonPropertyName("interiorColour")]
    public string? InteriorColour { get; set; }

    [JsonPropertyName("interiorCondition")]
    public int? InteriorCondition { get; set; }

    [JsonPropertyName("lastServiceDate")]
    public DateTimeOffset? LastServiceDate { get; set; }

    [JsonPropertyName("lastServiceOdometerReadingMiles")]
    public int? LastServiceOdometerReadingMiles { get; set; }

    [JsonPropertyName("lengthMM")]
    public int? LengthMm { get; set; }

    [JsonPropertyName("make")]
    public string Make { get; set; } = null!;

    [JsonPropertyName("model")]
    public string Model { get; set; } = null!;

    [JsonPropertyName("motExpiryDate")]
    public DateTimeOffset? MotExpiryDate { get; set; }

    [JsonPropertyName("odometerReadingMiles")]
    public int OdometerReadingMiles { get; set; }

    [JsonPropertyName("owners")]
    public int? Owners { get; set; }

    [JsonPropertyName("ownershipCondition")]
    public OwnershipCondition OwnershipCondition { get; set; }

    [JsonPropertyName("plate")]
    public string? Plate { get; set; }

    [JsonPropertyName("registration")]
    public string? Registration { get; set; }

    [JsonPropertyName("seats")]
    public int? Seats { get; set; }

    [JsonPropertyName("serviceHistory")]
    public string? ServiceHistory { get; set; }

    [JsonPropertyName("standard")]
    public Standard Standard { get; set; } = null!;

    [JsonPropertyName("topSpeedMPH")]
    public int? TopSpeedMph { get; set; }

    [JsonPropertyName("transmissionType")]
    public string? TransmissionType { get; set; }

    [JsonPropertyName("trim")]
    public string? Trim { get; set; }

    [JsonPropertyName("tyreCondition")]
    public string? TyreCondition { get; set; }

    [JsonPropertyName("vehicleType")]
    public VehicleType VehicleType { get; set; }

    [JsonPropertyName("vin")]
    public string? Vin { get; set; }

    [JsonPropertyName("warrantyMonthsOnPurchase")]
    public int? WarrantyMonthsOnPurchase { get; set; }

    [JsonPropertyName("wheelbaseType")]
    public string? WheelbaseType { get; set; }

    [JsonPropertyName("widthMM")]
    public int? WidthMm { get; set; }

    [JsonPropertyName("yearOfManufacture")]
    public int? YearOfManufacture { get; set; }

    [JsonPropertyName("zeroToOneHundredKMPHSeconds")]
    public double? ZeroToOneHundredKmphSeconds { get; set; }

    [JsonPropertyName("zeroToSixtyMPHSeconds")]
    public double? ZeroToSixtyMphSeconds { get; set; }
}
