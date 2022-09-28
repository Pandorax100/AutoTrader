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
    /// <param name="vehicleGenerationId">The generation id.</param>
    Task<IList<VehicleDerivative>> GetVehicleDerivativesAsync(int advertiserId, string vehicleGenerationId);

    /// <summary>
    /// Gets the vehicle data for the given derivative.
    /// </summary>
    /// <param name="advertiserId">The dealer's advertiser id.</param>
    /// <param name="vehicleDerivativeId">The derivative id.</param>
    Task<VehicleTechnicalData> GetTechnicalDataAsync(int advertiserId, string vehicleDerivativeId);

    Task<IList<Feature>> GetFeaturesAsync(int advertiserId, string derivativeId, DateOnly effectiveDate);
}
