using System.Text.Json.Serialization;

namespace Pandorax.AutoTrader.Models.Vehicles;

public partial class Vehicle
{
    [JsonPropertyName("axles")]
    public int Axles { get; set; }

    [JsonPropertyName("badgeEngineSizeLitres")]
    public double BadgeEngineSizeLitres { get; set; }

    [JsonPropertyName("batteryCapacityKWH")]
    public double? BatteryCapacityKwh { get; set; }

    [JsonPropertyName("batteryChargeTime")]
    public string? BatteryChargeTime { get; set; }

    [JsonPropertyName("batteryQuickChargeTime")]
    public string? BatteryQuickChargeTime { get; set; }

    [JsonPropertyName("batteryRangeMiles")]
    public int? BatteryRangeMiles { get; set; }

    [JsonPropertyName("batteryUsableCapacityKWH")]
    public double? BatteryUsableCapacityKwh { get; set; }

    [JsonPropertyName("bodyType")]
    public string? BodyType { get; set; }

    [JsonPropertyName("bootSpaceSeatsDownLitres")]
    public double? BootSpaceSeatsDownLitres { get; set; }

    [JsonPropertyName("bootSpaceSeatsUpLitres")]
    public double? BootSpaceSeatsUpLitres { get; set; }

    [JsonPropertyName("boreMM")]
    public int BoreMm { get; set; }

    [JsonPropertyName("cabType")]
    public string? CabType { get; set; }

    [JsonPropertyName("co2EmissionGPKM")]
    public int Co2EmissionGpkm { get; set; }

    [JsonPropertyName("colour")]
    public string? Colour { get; set; }

    [JsonPropertyName("countryOfOrigin")]
    public string? CountryOfOrigin { get; set; }

    [JsonPropertyName("cylinderArrangement")]
    public string? CylinderArrangement { get; set; }

    [JsonPropertyName("cylinders")]
    public int? Cylinders { get; set; }

    [JsonPropertyName("derivative")]
    public string? Derivative { get; set; }

    [JsonPropertyName("derivativeId")]
    public string? DerivativeId { get; set; }

    [JsonPropertyName("doors")]
    public int Doors { get; set; }

    [JsonPropertyName("drivetrain")]
    public Drivetrain Drivetrain { get; set; }

    [JsonPropertyName("driveType")]
    public string? DriveType { get; set; }

    [JsonPropertyName("emissionClass")]
    public EmissionClass EmissionClass { get; set; }

    [JsonPropertyName("engineCapacityCC")]
    public int EngineCapacityCC { get; set; }

    [JsonPropertyName("engineMake")]
    public string? EngineMake { get; set; }

    [JsonPropertyName("engineNumber")]
    public string? EngineNumber { get; set; }

    [JsonPropertyName("enginePowerBHP")]
    public int? EnginePowerBhp { get; set; }

    [JsonPropertyName("enginePowerPS")]
    public int? EnginePowerPs { get; set; }

    [JsonPropertyName("engineTorqueLBFT")]
    public double? EngineTorqueLbft { get; set; }

    [JsonPropertyName("engineTorqueNM")]
    public int? EngineTorqueNm { get; set; }

    [JsonPropertyName("firstRegistrationDate")]
    public DateOnly FirstRegistrationDate { get; set; }

    [JsonPropertyName("fuelCapacityLitres")]
    public double? FuelCapacityLitres { get; set; }

    [JsonPropertyName("fuelDelivery")]
    public string? FuelDelivery { get; set; }

    [JsonPropertyName("fuelEconomyNEDCCombinedMPG")]
    public double? FuelEconomyNedcCombinedMpg { get; set; }

    [JsonPropertyName("fuelEconomyNEDCExtraUrbanMPG")]
    public double? FuelEconomyNedcExtraUrbanMpg { get; set; }

    [JsonPropertyName("fuelEconomyNEDCUrbanMPG")]
    public double? FuelEconomyNedcUrbanMpg { get; set; }

    [JsonPropertyName("fuelEconomyWLTPCombinedMPG")]
    public double? FuelEconomyWltpCombinedMpg { get; set; }

    [JsonPropertyName("fuelEconomyWLTPExtraHighMPG")]
    public double? FuelEconomyWltpExtraHighMpg { get; set; }

    [JsonPropertyName("fuelEconomyWLTPHighMPG")]
    public double? FuelEconomyWltpHighMpg { get; set; }

    [JsonPropertyName("fuelEconomyWLTPLowMPG")]
    public double? FuelEconomyWltpLowMpg { get; set; }

    [JsonPropertyName("fuelEconomyWLTPMediumMPG")]
    public double? FuelEconomyWltpMediumMpg { get; set; }

    [JsonPropertyName("fuelType")]
    public string? FuelType { get; set; }

    [JsonPropertyName("gears")]
    public int Gears { get; set; }

    [JsonPropertyName("generation")]
    public string? Generation { get; set; }

    [JsonPropertyName("grossCombinedWeightKG")]
    public double? GrossCombinedWeightKg { get; set; }

    [JsonPropertyName("grossTrainWeightKG")]
    public double? GrossTrainWeightKg { get; set; }

    [JsonPropertyName("grossVehicleWeightKG")]
    public int? GrossVehicleWeightKg { get; set; }

    [JsonPropertyName("heightMM")]
    public int HeightMM { get; set; }

    [JsonPropertyName("insuranceGroup")]
    public string? InsuranceGroup { get; set; }

    [JsonPropertyName("insuranceSecurityCode")]
    public string? InsuranceSecurityCode { get; set; }

    [JsonPropertyName("lengthMM")]
    public int LengthMm { get; set; }

    [JsonPropertyName("make")]
    public string? Make { get; set; }

    [JsonPropertyName("minimumKerbWeightKG")]
    public int? MinimumKerbWeightKg { get; set; }

    [JsonPropertyName("model")]
    public string? Model { get; set; }

    [JsonPropertyName("oem")]
    public Oem Oem { get; set; } = new();

    [JsonPropertyName("owners")]
    public int Owners { get; set; }

    [JsonPropertyName("ownershipCondition")]
    public OwnershipCondition OwnershipCondition { get; set; }

    [JsonPropertyName("payloadHeightMM")]
    public int? PayloadHeightMM { get; set; }

    [JsonPropertyName("payloadLengthMM")]
    public int? PayloadLengthMM { get; set; }

    [JsonPropertyName("payloadVolumeCubicMetres")]
    public double? PayloadVolumeCubicMetres { get; set; }

    [JsonPropertyName("payloadWeightKG")]
    public int? PayloadWeightKg { get; set; }

    [JsonPropertyName("payloadWidthMM")]
    public int? PayloadWidthMm { get; set; }

    [JsonPropertyName("rde2Compliant")]
    public bool? Rde2Compliant { get; set; }

    [JsonPropertyName("registration")]
    public string? Registration { get; set; }

    [JsonPropertyName("roofHeightType")]
    public string? RoofHeightType { get; set; }

    [JsonPropertyName("seats")]
    public int Seats { get; set; }

    [JsonPropertyName("sector")]
    public string? Sector { get; set; }

    [JsonPropertyName("startStop")]
    public bool StartStop { get; set; }

    [JsonPropertyName("strokeMM")]
    public int StrokeMm { get; set; }

    [JsonPropertyName("style")]
    public string? Style { get; set; }

    [JsonPropertyName("subStyle")]
    public string? SubStyle { get; set; }

    [JsonPropertyName("topSpeedMPH")]
    public int TopSpeedMph { get; set; }

    [JsonPropertyName("transmissionType")]
    public string? TransmissionType { get; set; }

    [JsonPropertyName("trim")]
    public string? Trim { get; set; }

    [JsonPropertyName("valveGear")]
    public string? ValveGear { get; set; }

    [JsonPropertyName("valves")]
    public int Valves { get; set; }

    [JsonPropertyName("vehicleType")]
    public VehicleType VehicleType { get; set; }

    [JsonPropertyName("vin")]
    public string? Vin { get; set; }

    [JsonPropertyName("wheelbaseMM")]
    public int WheelbaseMm { get; set; }

    [JsonPropertyName("wheelbaseType")]
    public string? WheelbaseType { get; set; }

    [JsonPropertyName("widthMM")]
    public int WidthMm { get; set; }

    [JsonPropertyName("zeroToOneHundredKMPHSeconds")]
    public double? ZeroToOneHundredKmphSeconds { get; set; }

    [JsonPropertyName("zeroToSixtyMPHSeconds")]
    public double? ZeroToSixtyMphSeconds { get; set; }
}
