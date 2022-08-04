using Newtonsoft.Json;

namespace Pandorax.AutoTrader.Models;

public class Vehicle
{
    [JsonProperty("axleConfiguration")]
    public string? AxleConfiguration { get; set; }

    [JsonProperty("badgeEngineSizeLitres")]
    public double? BadgeEngineSizeLitres { get; set; }

    [JsonProperty("bedroomLayout")]
    public string? BedroomLayout { get; set; }

    [JsonProperty("berths")]
    public int? Berths { get; set; }

    [JsonProperty("bodyCondition")]
    public string? BodyCondition { get; set; }

    [JsonProperty("bodyType")]
    public string? BodyType { get; set; }

    [JsonProperty("bootSpaceSeatsDownLitres")]
    public double? BootSpaceSeatsDownLitres { get; set; }

    [JsonProperty("bootSpaceSeatsUpLitres")]
    public double? BootSpaceSeatsUpLitres { get; set; }

    [JsonProperty("cabType")]
    public string? CabType { get; set; }

    [JsonProperty("co2EmissionGPKM")]
    public int? Co2EmissionGpkm { get; set; }

    [JsonProperty("colour")]
    public string? Colour { get; set; }

    [JsonProperty("derivative")]
    public string? Derivative { get; set; }

    [JsonProperty("derivativeId")]
    public string? DerivativeId { get; set; }

    [JsonProperty("doors")]
    public int? Doors { get; set; }

    [JsonProperty("driverPosition")]
    public string? DriverPosition { get; set; }

    [JsonProperty("drivetrain")]
    public string? Drivetrain { get; set; }

    [JsonProperty("emissionClass")]
    public EmissionClass? EmissionClass { get; set; }

    [JsonProperty("endLayout")]
    public string? EndLayout { get; set; }

    [JsonProperty("engineCapacityCC")]
    public int? EngineCapacityCc { get; set; }

    [JsonProperty("enginePowerBHP")]
    public double? EnginePowerBhp { get; set; }

    [JsonProperty("exDemo")]
    public bool? ExDemo { get; set; }

    [JsonProperty("exteriorFinish")]
    public string? ExteriorFinish { get; set; }

    [JsonProperty("firstRegistrationDate")]
    public DateTime? FirstRegistrationDate { get; set; }

    [JsonProperty("fuelCapacityLitres")]
    public double? FuelCapacityLitres { get; set; }

    [JsonProperty("fuelEconomyNEDCCombinedMPG")]
    public double? FuelEconomyNedcCombinedMpg { get; set; }

    [JsonProperty("fuelEconomyNEDCExtraUrbanMPG")]
    public double? FuelEconomyNedcExtraUrbanMpg { get; set; }

    [JsonProperty("fuelEconomyNEDCUrbanMPG")]
    public double? FuelEconomyNedcUrbanMpg { get; set; }

    [JsonProperty("fuelEconomyWLTPCombinedMPG")]
    public double? FuelEconomyWltpCombinedMpg { get; set; }

    [JsonProperty("fuelType")]
    public string? FuelType { get; set; }

    [JsonProperty("heightMM")]
    public int? HeightMm { get; set; }

    [JsonProperty("insuranceGroup")]
    public string? InsuranceGroup { get; set; }

    [JsonProperty("insuranceSecurityCode")]
    public Insurance? InsuranceSecurityCode { get; set; }

    [JsonProperty("interiorColour")]
    public string? InteriorColour { get; set; }

    [JsonProperty("interiorCondition")]
    public string? InteriorCondition { get; set; }

    [JsonProperty("lastServiceDate")]
    public DateTime? LastServiceDate { get; set; }

    [JsonProperty("lastServiceOdometerReadingMiles")]
    public int? LastServiceOdometerReadingMiles { get; set; }

    [JsonProperty("lengthMM")]
    public int? LengthMm { get; set; }

    [JsonProperty("make")]
    public string? Make { get; set; }

    [JsonProperty("model")]
    public string? Model { get; set; }

    [JsonProperty("motExpiryDate")]
    public DateTime? MotExpiryDate { get; set; }

    [JsonProperty("odometerReadingMiles")]
    public int? OdometerReadingMiles { get; set; }

    [JsonProperty("owners")]
    public int? Owners { get; set; }

    [JsonProperty("ownershipCondition")]
    public OwnershipCondition? OwnershipCondition { get; set; }

    [JsonProperty("plate")]
    public string? Plate { get; set; }

    [JsonProperty("registration")]
    public string? Registration { get; set; }

    [JsonProperty("seats")]
    public int? Seats { get; set; }

    [JsonProperty("serviceHistory")]
    public string? ServiceHistory { get; set; }

    [JsonProperty("standard")]
    public Standard? Standard { get; set; }

    [JsonProperty("topSpeedMPH")]
    public int? TopSpeedMph { get; set; }

    [JsonProperty("transmissionType")]
    public string? TransmissionType { get; set; }

    [JsonProperty("trim")]
    public string? Trim { get; set; }

    [JsonProperty("tyreCondition")]
    public string? TyreCondition { get; set; }

    [JsonProperty("vehicleType")]
    public VehicleType? VehicleType { get; set; }

    [JsonProperty("vin")]
    public string? Vin { get; set; }

    [JsonProperty("warrantyMonthsOnPurchase")]
    public int? WarrantyMonthsOnPurchase { get; set; }

    [JsonProperty("wheelbaseType")]
    public string? WheelbaseType { get; set; }

    [JsonProperty("widthMM")]
    public int? WidthMm { get; set; }

    [JsonProperty("yearOfManufacture")]
    public int? YearOfManufacture { get; set; }

    [JsonProperty("zeroToOneHundredKMPHSeconds")]
    public double? ZeroToOneHundredKmphSeconds { get; set; }

    [JsonProperty("zeroToSixtyMPHSeconds")]
    public double? ZeroToSixtyMphSeconds { get; set; }
}
