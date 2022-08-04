using Newtonsoft.Json;

namespace Pandorax.AutoTrader.Models.Vehicles;

public partial class Vehicle
{
    [JsonProperty("axles")]
    public int Axles { get; set; }

    [JsonProperty("badgeEngineSizeLitres")]
    public double BadgeEngineSizeLitres { get; set; }

    [JsonProperty("batteryCapacityKWH")]
    public double? BatteryCapacityKwh { get; set; }

    [JsonProperty("batteryChargeTime")]
    public string? BatteryChargeTime { get; set; }

    [JsonProperty("batteryQuickChargeTime")]
    public string? BatteryQuickChargeTime { get; set; }

    [JsonProperty("batteryRangeMiles")]
    public int? BatteryRangeMiles { get; set; }

    [JsonProperty("batteryUsableCapacityKWH")]
    public double? BatteryUsableCapacityKwh { get; set; }

    [JsonProperty("bodyType")]
    public string? BodyType { get; set; }

    [JsonProperty("bootSpaceSeatsDownLitres")]
    public double? BootSpaceSeatsDownLitres { get; set; }

    [JsonProperty("bootSpaceSeatsUpLitres")]
    public double? BootSpaceSeatsUpLitres { get; set; }

    [JsonProperty("boreMM")]
    public int BoreMm { get; set; }

    [JsonProperty("cabType")]
    public string? CabType { get; set; }

    [JsonProperty("co2EmissionGPKM")]
    public int Co2EmissionGpkm { get; set; }

    [JsonProperty("colour")]
    public string? Colour { get; set; }

    [JsonProperty("countryOfOrigin")]
    public string? CountryOfOrigin { get; set; }

    [JsonProperty("cylinderArrangement")]
    public string? CylinderArrangement { get; set; }

    [JsonProperty("cylinders")]
    public int? Cylinders { get; set; }

    [JsonProperty("derivative")]
    public string? Derivative { get; set; }

    [JsonProperty("derivativeId")]
    public string? DerivativeId { get; set; }

    [JsonProperty("doors")]
    public int Doors { get; set; }

    [JsonProperty("drivetrain")]
    public string? Drivetrain { get; set; }

    [JsonProperty("driveType")]
    public string? DriveType { get; set; }

    [JsonProperty("emissionClass")]
    public EmissionClass? EmissionClass { get; set; }

    [JsonProperty("engineCapacityCC")]
    public int EngineCapacityCC { get; set; }

    [JsonProperty("engineMake")]
    public string? EngineMake { get; set; }

    [JsonProperty("engineNumber")]
    public string? EngineNumber { get; set; }

    [JsonProperty("enginePowerBHP")]
    public int? EnginePowerBhp { get; set; }

    [JsonProperty("enginePowerPS")]
    public int? EnginePowerPs { get; set; }

    [JsonProperty("engineTorqueLBFT")]
    public double? EngineTorqueLbft { get; set; }

    [JsonProperty("engineTorqueNM")]
    public int? EngineTorqueNm { get; set; }

    [JsonProperty("firstRegistrationDate")]
    public DateOnly FirstRegistrationDate { get; set; }

    [JsonProperty("fuelCapacityLitres")]
    public double? FuelCapacityLitres { get; set; }

    [JsonProperty("fuelDelivery")]
    public string? FuelDelivery { get; set; }

    [JsonProperty("fuelEconomyNEDCCombinedMPG")]
    public double? FuelEconomyNedcCombinedMpg { get; set; }

    [JsonProperty("fuelEconomyNEDCExtraUrbanMPG")]
    public double? FuelEconomyNedcExtraUrbanMpg { get; set; }

    [JsonProperty("fuelEconomyNEDCUrbanMPG")]
    public double? FuelEconomyNedcUrbanMpg { get; set; }

    [JsonProperty("fuelEconomyWLTPCombinedMPG")]
    public double? FuelEconomyWltpCombinedMpg { get; set; }

    [JsonProperty("fuelEconomyWLTPExtraHighMPG")]
    public double? FuelEconomyWltpExtraHighMpg { get; set; }

    [JsonProperty("fuelEconomyWLTPHighMPG")]
    public double? FuelEconomyWltpHighMpg { get; set; }

    [JsonProperty("fuelEconomyWLTPLowMPG")]
    public double? FuelEconomyWltpLowMpg { get; set; }

    [JsonProperty("fuelEconomyWLTPMediumMPG")]
    public double? FuelEconomyWltpMediumMpg { get; set; }

    [JsonProperty("fuelType")]
    public string? FuelType { get; set; }

    [JsonProperty("gears")]
    public int Gears { get; set; }

    [JsonProperty("generation")]
    public string? Generation { get; set; }

    [JsonProperty("grossCombinedWeightKG")]
    public double? GrossCombinedWeightKg { get; set; }

    [JsonProperty("grossTrainWeightKG")]
    public double? GrossTrainWeightKg { get; set; }

    [JsonProperty("grossVehicleWeightKG")]
    public int? GrossVehicleWeightKg { get; set; }

    [JsonProperty("heightMM")]
    public int HeightMM { get; set; }

    [JsonProperty("insuranceGroup")]
    public string? InsuranceGroup { get; set; }

    [JsonProperty("insuranceSecurityCode")]
    public string? InsuranceSecurityCode { get; set; }

    [JsonProperty("lengthMM")]
    public int LengthMm { get; set; }

    [JsonProperty("make")]
    public string? Make { get; set; }

    [JsonProperty("minimumKerbWeightKG")]
    public int? MinimumKerbWeightKg { get; set; }

    [JsonProperty("model")]
    public string? Model { get; set; }

    [JsonProperty("oem")]
    public Oem Oem { get; set; } = new();

    [JsonProperty("owners")]
    public int Owners { get; set; }

    [JsonProperty("ownershipCondition")]
    public OwnershipCondition OwnershipCondition { get; set; }

    [JsonProperty("payloadHeightMM")]
    public int? PayloadHeightMM { get; set; }

    [JsonProperty("payloadLengthMM")]
    public int? PayloadLengthMM { get; set; }

    [JsonProperty("payloadVolumeCubicMetres")]
    public double? PayloadVolumeCubicMetres { get; set; }

    [JsonProperty("payloadWeightKG")]
    public int? PayloadWeightKg { get; set; }

    [JsonProperty("payloadWidthMM")]
    public int? PayloadWidthMm { get; set; }

    [JsonProperty("rde2Compliant")]
    public bool? Rde2Compliant { get; set; }

    [JsonProperty("registration")]
    public string? Registration { get; set; }

    [JsonProperty("roofHeightType")]
    public string? RoofHeightType { get; set; }

    [JsonProperty("seats")]
    public int Seats { get; set; }

    [JsonProperty("sector")]
    public string? Sector { get; set; }

    [JsonProperty("startStop")]
    public bool StartStop { get; set; }

    [JsonProperty("strokeMM")]
    public int StrokeMm { get; set; }

    [JsonProperty("style")]
    public string? Style { get; set; }

    [JsonProperty("subStyle")]
    public string? SubStyle { get; set; }

    [JsonProperty("topSpeedMPH")]
    public int TopSpeedMph { get; set; }

    [JsonProperty("transmissionType")]
    public string? TransmissionType { get; set; }

    [JsonProperty("trim")]
    public string? Trim { get; set; }

    [JsonProperty("valveGear")]
    public string? ValveGear { get; set; }

    [JsonProperty("valves")]
    public int Valves { get; set; }

    [JsonProperty("vehicleType")]
    public VehicleType VehicleType { get; set; }

    [JsonProperty("vin")]
    public string? Vin { get; set; }

    [JsonProperty("wheelbaseMM")]
    public int WheelbaseMm { get; set; }

    [JsonProperty("wheelbaseType")]
    public string? WheelbaseType { get; set; }

    [JsonProperty("widthMM")]
    public int WidthMm { get; set; }

    [JsonProperty("zeroToOneHundredKMPHSeconds")]
    public double? ZeroToOneHundredKmphSeconds { get; set; }

    [JsonProperty("zeroToSixtyMPHSeconds")]
    public double? ZeroToSixtyMphSeconds { get; set; }
}
