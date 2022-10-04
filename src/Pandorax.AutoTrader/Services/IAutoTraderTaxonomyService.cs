using Pandorax.AutoTrader.Api.Taxonomy;
using Pandorax.AutoTrader.Api.Vehicles;

namespace Pandorax.AutoTrader.Services;

public interface IAutoTraderTaxonomyService
{
    /// <summary>
    /// Gets all the available vehicle types.
    /// </summary>
    /// <param name="advertiserId">The dealer's advertiser id.</param>
    Task<IList<VehicleType>> GetVehicleTypesAsync(int advertiserId);

    /// <summary>
    /// Gets all the vehicle makes for the given type.
    /// </summary>
    /// <param name="advertiserId">The dealer's advertiser id.</param>
    /// <param name="vehicleType">The vehicle type.</param>
    Task<IList<VehicleMake>> GetVehicleMakesAsync(int advertiserId, string vehicleType);

    /// <summary>
    /// Gets all the available models for the given make.
    /// </summary>
    /// <param name="advertiserId">The dealer's advertiser id.</param>
    /// <param name="vehicleMakeId">The make id.</param>
    Task<IList<VehicleModel>> GetVehicleModelsAsync(int advertiserId, string vehicleMakeId);

    /// <summary>
    /// Gets the available generations for the given model.
    /// </summary>
    /// <param name="advertiserId">The dealer's advertiser id.</param>
    /// <param name="vehicleModelId">The model id.</param>
    Task<IList<VehicleGeneration>> GetVehicleGenerationsAsync(int advertiserId, string vehicleModelId);

    /// <summary>
    /// Gets the available derivatives for the given generation.
    /// </summary>
    /// <param name="advertiserId">The dealer's advertiser id.</param>
    /// <param name="vehicleGenerationId">The vehicle generation id.</param>
    /// <param name="fuelType">The vehichle's fuel type.</param>
    /// <param name="transmission">The vehicle's transmission.</param>
    /// <param name="trim">The trim of the vehicle.</param>
    /// <param name="doors">The number of doors the vehicle has.</param>
    /// <param name="drivetrain">The vehicle's drive train.</param>
    /// <param name="badgeEngineSize">The engine badge size of the vehicle.</param>
    Task<IList<VehicleDerivative>> GetVehicleDerivativesAsync(
        int advertiserId,
        string vehicleGenerationId,
        string? fuelType = null,
        string? transmission = null,
        string? trim = null,
        string? doors = null,
        string? drivetrain = null,
        string? badgeEngineSize = null);

    /// <summary>
    /// Gets the vehicle data for the given derivative.
    /// </summary>
    /// <param name="advertiserId">The dealer's advertiser id.</param>
    /// <param name="vehicleDerivativeId">The derivative id.</param>
    Task<VehicleTechnicalData> GetTechnicalDataAsync(int advertiserId, string vehicleDerivativeId);

    /// <summary>
    /// Gets the available fuel types for the given generation.
    /// <para>The fuel types can be used to filter the derivatives for this generation.</para>
    /// </summary>
    /// <param name="advertiserId">The dealer's advertiser id.</param>
    /// <param name="vehicleGenerationId">The vehicle generation id.</param>
    Task<IList<string>> GetFuelTypesForGenerationAsync(int advertiserId, string vehicleGenerationId);

    /// <summary>
    /// Gets the available transmissions for the given generation.
    /// <para>The transmissions can be used to filter the derivatives for this generation.</para>
    /// </summary>
    /// <param name="advertiserId">The dealer's advertiser id.</param>
    /// <param name="vehicleGenerationId">The vehicle generation id.</param>
    Task<IList<string>> GetTransmissionsForGenerationAsync(int advertiserId, string vehicleGenerationId);

    /// <summary>
    /// Gets the available body types for the given generation.
    /// <para>The body types can be used to filter the derivatives for this generation.</para>
    /// </summary>
    /// <param name="advertiserId">The dealer's advertiser id.</param>
    /// <param name="vehicleGenerationId">The vehicle generation id.</param>
    Task<IList<string>> GetBodyTypesForGenerationAsync(int advertiserId, string vehicleGenerationId);

    /// <summary>
    /// Gets the available trims for the given generation.
    /// <para>The trims can be used to filter the derivatives for this generation.</para>
    /// </summary>
    /// <param name="advertiserId">The dealer's advertiser id.</param>
    /// <param name="vehicleGenerationId">The vehicle generation id.</param>
    Task<IList<string>> GetTrimsForGenerationAsync(int advertiserId, string vehicleGenerationId);

    /// <summary>
    /// Gets the available doors for the given generation.
    /// <para>The doors can be used to filter the derivatives for this generation.</para>
    /// </summary>
    /// <param name="advertiserId">The dealer's advertiser id.</param>
    /// <param name="vehicleGenerationId">The vehicle generation id.</param>
    Task<IList<string>> GetDoorsForGenerationAsync(int advertiserId, string vehicleGenerationId);

    /// <summary>
    /// Gets the available drivetrains for the given generation.
    /// <para>The drivetrains can be used to filter the derivatives for this generation.</para>
    /// </summary>
    /// <param name="advertiserId">The dealer's advertiser id.</param>
    /// <param name="vehicleGenerationId">The vehicle generation id.</param>
    Task<IList<string>> GetDrivetrainsForGenerationAsync(int advertiserId, string vehicleGenerationId);

    /// <summary>
    /// Gets the available badge engine sizes for the given generation.
    /// <para>The badge engine sizes can be used to filter the derivatives for this generation.</para>
    /// </summary>
    /// <param name="advertiserId">The dealer's advertiser id.</param>
    /// <param name="vehicleGenerationId">The vehicle generation id.</param>
    Task<IList<string>> GetBadgeEngineSizesForGenerationAsync(int advertiserId, string vehicleGenerationId);

    Task<IList<Feature>> GetFeaturesAsync(int advertiserId, string derivativeId, DateOnly effectiveDate);
}
