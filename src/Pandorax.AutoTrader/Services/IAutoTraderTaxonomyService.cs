using Pandorax.AutoTrader.Api.Taxonomy;
using Pandorax.AutoTrader.Api.Vehicles;

namespace Pandorax.AutoTrader.Services;

public interface IAutoTraderTaxonomyService
{
    /// <summary>
    /// Gets all the available vehicle types.
    /// </summary>
    Task<IList<VehicleType>> GetVehicleTypesAsync();

    /// <summary>
    /// Gets all the vehicle makes for the given type.
    /// </summary>
    /// <param name="vehicleType">The vehicle type.</param>
    Task<IList<VehicleMake>> GetVehicleMakesAsync(string vehicleType);

    /// <summary>
    /// Gets all the available models for the given make.
    /// </summary>
    /// <param name="vehicleMakeId">The make id.</param>
    Task<IList<VehicleModel>> GetVehicleModelsAsync(string vehicleMakeId);

    /// <summary>
    /// Gets the available generations for the given model.
    /// </summary>
    /// <param name="vehicleModelId">The model id.</param>
    Task<IList<VehicleGeneration>> GetVehicleGenerationsAsync(string vehicleModelId);

    /// <summary>
    /// Gets the available derivatives for the given generation.
    /// </summary>
    /// <param name="vehicleGenerationId">The generation id.</param>
    Task<IList<VehicleDerivative>> GetVehicleDerivativesAsync(string vehicleGenerationId);

    /// <summary>
    /// Gets the vehicle data for the given derivative.
    /// </summary>
    /// <param name="vehicleDerivativeId">The derivative id.</param>
    Task<VehicleTechnicalData> GetTechnicalDataAsync(string vehicleDerivativeId);

    Task<IList<Feature>> GetFeaturesAsync(string derivativeId, DateOnly effectiveDate);
}
