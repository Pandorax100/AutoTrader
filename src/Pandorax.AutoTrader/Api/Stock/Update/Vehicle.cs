using Newtonsoft.Json;
using Pandorax.AutoTrader.Api.Stock.Common;
using Pandorax.AutoTrader.Utils;

namespace Pandorax.AutoTrader.Api.Stock.Update;

public class Vehicle
{
    [JsonProperty("axleConfiguration")]
    public Optional<string?> AxleConfiguration { get; set; }

    [JsonProperty("badgeEngineSizeLitres")]
    public Optional<double?> BadgeEngineSizeLitres { get; set; }

    [JsonProperty("bedroomLayout")]
    public Optional<string?> BedroomLayout { get; set; }

    [JsonProperty("berths")]
    public Optional<int?> Berths { get; set; }

    [JsonProperty("bodyCondition")]
    public Optional<string?> BodyCondition { get; set; }

    [JsonProperty("bodyType")]
    public Optional<string?> BodyType { get; set; }

    [JsonProperty("bootSpaceSeatsDownLitres")]
    public Optional<double?> BootSpaceSeatsDownLitres { get; set; }

    [JsonProperty("bootSpaceSeatsUpLitres")]
    public Optional<double?> BootSpaceSeatsUpLitres { get; set; }

    [JsonProperty("cabType")]
    public Optional<string?> CabType { get; set; }

    [JsonProperty("co2EmissionGPKM")]
    public Optional<int?> Co2EmissionGpkm { get; set; }

    [JsonProperty("colour")]
    public Optional<string?> Colour { get; set; }

    [JsonProperty("derivative")]
    public Optional<string?> Derivative { get; set; }

    [JsonProperty("derivativeId")]
    public Optional<string?> DerivativeId { get; set; }

    [JsonProperty("doors")]
    public Optional<int?> Doors { get; set; }

    [JsonProperty("driverPosition")]
    public Optional<string?> DriverPosition { get; set; }

    [JsonProperty("drivetrain")]
    public Optional<string?> Drivetrain { get; set; }

    [JsonProperty("emissionClass")]
    public Optional<EmissionClass?> EmissionClass { get; set; }

    [JsonProperty("endLayout")]
    public Optional<string?> EndLayout { get; set; }

    [JsonProperty("engineCapacityCC")]
    public Optional<int?> EngineCapacityCc { get; set; }

    [JsonProperty("enginePowerBHP")]
    public Optional<double?> EnginePowerBhp { get; set; }

    [JsonProperty("exDemo")]
    public Optional<bool?> ExDemo { get; set; }

    [JsonProperty("exteriorFinish")]
    public Optional<string?> ExteriorFinish { get; set; }

    [JsonProperty("firstRegistrationDate")]
    public Optional<DateTime?> FirstRegistrationDate { get; set; }

    [JsonProperty("fuelCapacityLitres")]
    public Optional<double?> FuelCapacityLitres { get; set; }

    [JsonProperty("fuelEconomyNEDCCombinedMPG")]
    public Optional<double?> FuelEconomyNedcCombinedMpg { get; set; }

    [JsonProperty("fuelEconomyNEDCExtraUrbanMPG")]
    public Optional<double?> FuelEconomyNedcExtraUrbanMpg { get; set; }

    [JsonProperty("fuelEconomyNEDCUrbanMPG")]
    public Optional<double?> FuelEconomyNedcUrbanMpg { get; set; }

    [JsonProperty("fuelEconomyWLTPCombinedMPG")]
    public Optional<double?> FuelEconomyWltpCombinedMpg { get; set; }

    [JsonProperty("fuelType")]
    public Optional<string?> FuelType { get; set; }

    [JsonProperty("heightMM")]
    public Optional<int?> HeightMm { get; set; }

    [JsonProperty("insuranceGroup")]
    public Optional<string?> InsuranceGroup { get; set; }

    [JsonProperty("insuranceSecurityCode")]
    public Optional<Insurance?> InsuranceSecurityCode { get; set; }

    [JsonProperty("interiorColour")]
    public Optional<string?> InteriorColour { get; set; }

    [JsonProperty("interiorCondition")]
    public Optional<string?> InteriorCondition { get; set; }

    [JsonProperty("lastServiceDate")]
    public Optional<DateTime?> LastServiceDate { get; set; }

    [JsonProperty("lastServiceOdometerReadingMiles")]
    public Optional<int?> LastServiceOdometerReadingMiles { get; set; }

    [JsonProperty("lengthMM")]
    public Optional<int?> LengthMm { get; set; }

    [JsonProperty("make")]
    public Optional<string?> Make { get; set; }

    [JsonProperty("model")]
    public Optional<string?> Model { get; set; }

    [JsonProperty("motExpiryDate")]
    public Optional<DateTime?> MotExpiryDate { get; set; }

    [JsonProperty("odometerReadingMiles")]
    public Optional<int?> OdometerReadingMiles { get; set; }

    [JsonProperty("owners")]
    public Optional<int?> Owners { get; set; }

    [JsonProperty("ownershipCondition")]
    public Optional<OwnershipCondition?> OwnershipCondition { get; set; }

    [JsonProperty("plate")]
    public Optional<string?> Plate { get; set; }

    [JsonProperty("registration")]
    public Optional<string?> Registration { get; set; }

    [JsonProperty("seats")]
    public Optional<int?> Seats { get; set; }

    [JsonProperty("serviceHistory")]
    public Optional<string?> ServiceHistory { get; set; }

    [JsonProperty("topSpeedMPH")]
    public Optional<int?> TopSpeedMph { get; set; }

    [JsonProperty("transmissionType")]
    public Optional<string?> TransmissionType { get; set; }

    [JsonProperty("trim")]
    public Optional<string?> Trim { get; set; }

    [JsonProperty("tyreCondition")]
    public Optional<string?> TyreCondition { get; set; }

    [JsonProperty("vehicleType")]
    public Optional<VehicleType?> VehicleType { get; set; }

    [JsonProperty("vin")]
    public Optional<string?> Vin { get; set; }

    [JsonProperty("warrantyMonthsOnPurchase")]
    public Optional<int?> WarrantyMonthsOnPurchase { get; set; }

    [JsonProperty("wheelbaseType")]
    public Optional<string?> WheelbaseType { get; set; }

    [JsonProperty("widthMM")]
    public Optional<int?> WidthMm { get; set; }

    [JsonProperty("yearOfManufacture")]
    public Optional<int?> YearOfManufacture { get; set; }

    [JsonProperty("zeroToOneHundredKMPHSeconds")]
    public Optional<double?> ZeroToOneHundredKmphSeconds { get; set; }

    [JsonProperty("zeroToSixtyMPHSeconds")]
    public Optional<double?> ZeroToSixtyMphSeconds { get; set; }
}
