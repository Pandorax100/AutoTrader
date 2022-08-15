using Pandorax.AutoTrader.Api.Taxonomy;
using Pandorax.AutoTrader.Api.Vehicles;

namespace Pandorax.AutoTrader.Services;

public interface IAutoTraderTaxonomyService
{
    Task<IList<VehicleType>> GetVehicleTypesAsync();

    Task<IList<VehicleMake>> GetVehicleMakesAsync(string vehicleType);

    Task<IList<VehicleModel>> GetVehicleModelsAsync(string vehicleMakeId);

    Task<IList<VehicleGeneration>> GetVehicleGenerationAsync(string vehicleModelId);

    Task<IList<VehicleDerivative>> GetVehicleDerivativeAsync(string vehicleGenerationId);

    Task<VehicleTechnicalData> GetTechnicalDataAsync(string vehicleDerivativeId);

    Task<IList<Feature>> GetFeaturesAsync(string derivativeId, DateOnly effectiveDate);
}
