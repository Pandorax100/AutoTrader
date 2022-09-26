using Newtonsoft.Json;
using Pandorax.AutoTrader.Api.Stock.Read;
using Pandorax.AutoTrader.Api.Taxonomy;
using Pandorax.AutoTrader.Serializer;
using Pandorax.AutoTrader.Utils;

namespace Pandorax.AutoTrader.Services;

internal class AutoTraderTaxonomyService : IAutoTraderTaxonomyService
{
    private readonly HttpClient _httpClient;

    public AutoTraderTaxonomyService(HttpClient httpClient)
    {
        ArgumentNullException.ThrowIfNull(httpClient);

        _httpClient = httpClient;
    }

    /// <inheritdoc />
    public async Task<IList<VehicleDerivative>> GetVehicleDerivativesAsync(string vehicleGenerationId)
    {
        ArgumentNullException.ThrowIfNull(vehicleGenerationId);

        string url = Endpoints.Taxonomy.VehicleDerivatives(vehicleGenerationId);

        var response = await PerformRequest<VehicleDerivativesResponse>(url);

        return response.Derivatives;
    }

    /// <inheritdoc />
    public async Task<IList<VehicleGeneration>> GetVehicleGenerationsAsync(string vehicleModelId)
    {
        ArgumentNullException.ThrowIfNull(vehicleModelId);

        string url = Endpoints.Taxonomy.VehicleGenerations(vehicleModelId);

        var response = await PerformRequest<VehicleGenerationsResponse>(url);

        return response.Generations;
    }

    /// <inheritdoc />
    public async Task<IList<VehicleMake>> GetVehicleMakesAsync(string vehicleType)
    {
        ArgumentNullException.ThrowIfNull(vehicleType);

        string url = Endpoints.Taxonomy.VehicleMakes(vehicleType);

        var response = await PerformRequest<VehicleMakesResponse>(url);

        return response.Makes;
    }

    /// <inheritdoc />
    public async Task<IList<VehicleModel>> GetVehicleModelsAsync(string vehicleMakeId)
    {
        ArgumentNullException.ThrowIfNull(vehicleMakeId);

        string url = Endpoints.Taxonomy.VehicleModels(vehicleMakeId);

        var response = await PerformRequest<VehicleModelsResponse>(url);

        return response.Models;
    }

    /// <inheritdoc />
    public async Task<IList<VehicleType>> GetVehicleTypesAsync()
    {
        string url = Endpoints.Taxonomy.VehicleTypes();

        var response = await PerformRequest<VehicleTypesResponse>(url);

        return response.VehicleTypes;
    }

    /// <inheritdoc />
    public Task<VehicleTechnicalData> GetTechnicalDataAsync(string derivativeId)
    {
        string url = Endpoints.Taxonomy.TechnicalData(derivativeId);

        return PerformRequest<VehicleTechnicalData>(url);
    }

    /// <inheritdoc />
    public async Task<IList<Api.Vehicles.Feature>> GetFeaturesAsync(string derivativeId, DateOnly effectiveDate)
    {
        string url = Endpoints.Taxonomy.VehicleFeatures(derivativeId, effectiveDate);

        var response = await PerformRequest<VehicleFeaturesResponse>(url);

        return response.Features;
    }

    private async Task<T> PerformRequest<T>(string url)
    {
        string responseJson = await _httpClient.GetStringAsync(url);

        T? deserialized = JsonConvert.DeserializeObject<T>(responseJson, AutoTraderJsonSerializer.SettingsWithoutContractResolver);

        return deserialized!;
    }
}
