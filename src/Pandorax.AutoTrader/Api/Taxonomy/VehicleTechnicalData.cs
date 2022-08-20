using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Pandorax.AutoTrader.Api.Stock.Common;
using Pandorax.AutoTrader.Api.Vehicles;

namespace Pandorax.AutoTrader.Api.Taxonomy;

public class VehicleTechnicalData
{
    public string DerivativeId { get; set; } = null!;

    public string VehicleType { get; set; } = null!;

    public string Make { get; set; } = null!;

    public string Model { get; set; } = null!;

    public string Generation { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string LongName { get; set; } = null!;

    public DateOnly Introduced { get; set; }

    public DateOnly? Discontinued { get; set; }

    public string? Trim { get; set; }

    public string? BodyType { get; set; }

    public string? FuelType { get; set; }

    public string? FuelDelivery { get; set; }

    public string? TransmissionType { get; set; }

    public string? DriveTrain { get; set; }

    public string? CabType { get; set; }

    public string? WheelbaseType { get; set; }

    public string? RoofHeightType { get; set; }

    public int? Seats { get; set; }

    public int? Doors { get; set; }

    public int? Valves { get; set; }

    public int? Gears { get; set; }

    public int? Cylinders { get; set; }

    public string? CylinderArrangement { get; set; }

    public string? EngineMake { get; set; }

    public string? ValveGear { get; set; }

    public int? Axles { get; set; }

    public string? CountryOfOrigin { get; set; }

    public string? DriveType { get; set; }

    public bool StartStop { get; set; }

    [JsonProperty("enginePowerPS")]
    public int? EnginePowerPs { get; set; }

    [JsonProperty("engineTorqueNM")]
    public int? EngineTorqueNm { get; set; }

    [JsonProperty("engineTorqueLBFT")]
    public double? EngineTorqueLbft { get; set; }

    [JsonProperty("co2EmissionGPKM")]
    public int? Co2EmissionGpkm { get; set; }

    [JsonProperty("topSpeedMPH")]
    public int? TopSpeedMph { get; set; }

    [JsonProperty("zeroToOneHundredKMPHSeconds")]
    public double? ZeroToOneHundredKmphSeconds { get; set; }

    [JsonProperty("zeroToSixtyMPHSeconds")]
    public double? ZeroToSixtyMphSeconds { get; set; }

    [JsonProperty("badgeEngineSizeLitres")]
    public double BadgeEngineSizeLitres { get; set; }

    [JsonProperty("engineCapacityCC")]
    public int? EngineCapacityCC { get; set; }

    [JsonProperty("enginePowerBHP")]
    public int? EnginePowerBhp { get; set; }

    [JsonProperty("fuelCapacityLitres")]
    public double? FuelCapacityLitres { get; set; }

    [JsonProperty("emissionClass")]
    public EmissionClass? EmissionClass { get; set; }

    [JsonProperty("owners")]
    public int? Owners { get; set; }

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

    [JsonProperty("lengthMM")]
    public int? LengthMm { get; set; }

    [JsonProperty("heightMM")]
    public int? HeightMM { get; set; }

    [JsonProperty("widthMM")]
    public int? WidthMm { get; set; }

    [JsonProperty("wheelbaseMM")]
    public int? WheelbaseMm { get; set; }

    [JsonProperty("bootSpaceSeatsUpLitres")]
    public double? BootSpaceSeatsUpLitres { get; set; }

    [JsonProperty("bootSpaceSeatsDownLitres")]
    public double? BootSpaceSeatsDownLitres { get; set; }

    [JsonProperty("insuranceGroup")]
    public string? InsuranceGroup { get; set; }

    [JsonProperty("insuranceSecurityCode")]
    public string? InsuranceSecurityCode { get; set; }

    [JsonProperty("batteryChargeTime")]
    public string? BatteryChargeTime { get; set; }

    [JsonProperty("batteryQuickChargeTime")]
    public string? BatteryQuickChargeTime { get; set; }

    [JsonProperty("batteryRangeMiles")]
    public int? BatteryRangeMiles { get; set; }

    [JsonProperty("batteryCapacityKWH")]
    public double? BatteryCapacityKwh { get; set; }

    [JsonProperty("batteryUsableCapacityKWH")]
    public double? BatteryUsableCapacityKwh { get; set; }

    [JsonProperty("minimumKerbWeightKG")]
    public int? MinimumKerbWeightKg { get; set; }

    [JsonProperty("grossVehicleWeightKG")]
    public int? GrossVehicleWeightKg { get; set; }

    [JsonProperty("grossCombinedWeightKG")]
    public double? GrossCombinedWeightKg { get; set; }

    [JsonProperty("grossTrainWeightKG")]
    public double? GrossTrainWeightKg { get; set; }

    [JsonProperty("boreMM")]
    public int? BoreMm { get; set; }

    [JsonProperty("strokeMM")]
    public int? StrokeMm { get; set; }

    [JsonProperty("payloadLengthMM")]
    public int? PayloadLengthMM { get; set; }

    [JsonProperty("payloadWidthMM")]
    public int? PayloadWidthMm { get; set; }

    [JsonProperty("payloadHeightMM")]
    public int? PayloadHeightMM { get; set; }

    [JsonProperty("payloadWeightKG")]
    public int? PayloadWeightKg { get; set; }

    [JsonProperty("payloadVolumeCubicMetres")]
    public double? PayloadVolumeCubicMetres { get; set; }

    [JsonProperty("rde2Compliant")]
    public bool? Rde2Compliant { get; set; }

    [JsonProperty("sector")]
    public string? Sector { get; set; }

    [JsonProperty("oem")]
    public Oem Oem { get; set; } = null!;
}
