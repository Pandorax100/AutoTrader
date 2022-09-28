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
    public async Task<IList<VehicleDerivative>> GetVehicleDerivativesAsync(int advertiserId, string vehicleGenerationId)
    {
        ArgumentNullException.ThrowIfNull(vehicleGenerationId);

        string url = Endpoints.Taxonomy.VehicleDerivatives(advertiserId, vehicleGenerationId);

        var response = await PerformRequest<VehicleDerivativesResponse>(url);

        return response.Derivatives;
    }

    /// <inheritdoc />
    public async Task<IList<VehicleGeneration>> GetVehicleGenerationsAsync(int advertiserId, string vehicleModelId)
    {
        ArgumentNullException.ThrowIfNull(vehicleModelId);

        string url = Endpoints.Taxonomy.VehicleGenerations(advertiserId, vehicleModelId);

        var response = await PerformRequest<VehicleGenerationsResponse>(url);

        return response.Generations;
    }

    /// <inheritdoc />
    public async Task<IList<VehicleMake>> GetVehicleMakesAsync(int advertiserId, string vehicleType)
    {
        ArgumentNullException.ThrowIfNull(vehicleType);

        string url = Endpoints.Taxonomy.VehicleMakes(advertiserId, vehicleType);

        var response = await PerformRequest<VehicleMakesResponse>(url);

        return response.Makes;
    }

    /// <inheritdoc />
    public async Task<IList<VehicleModel>> GetVehicleModelsAsync(int advertiserId, string vehicleMakeId)
    {
        ArgumentNullException.ThrowIfNull(vehicleMakeId);

        string url = Endpoints.Taxonomy.VehicleModels(advertiserId, vehicleMakeId);

        var response = await PerformRequest<VehicleModelsResponse>(url);

        return response.Models;
    }

    /// <inheritdoc />
    public async Task<IList<VehicleType>> GetVehicleTypesAsync(int advertiserId)
    {
        string url = Endpoints.Taxonomy.VehicleTypes(advertiserId);

        var response = await PerformRequest<VehicleTypesResponse>(url);

        return response.VehicleTypes;
    }

    /// <inheritdoc />
    public Task<VehicleTechnicalData> GetTechnicalDataAsync(int advertiserId, string derivativeId)
    {
        string url = Endpoints.Taxonomy.TechnicalData(advertiserId, derivativeId);

        return PerformRequest<VehicleTechnicalData>(url);
    }

    /// <inheritdoc />
    public async Task<IList<Api.Vehicles.Feature>> GetFeaturesAsync(int advertiserId, string derivativeId, DateOnly effectiveDate)
    {
        string url = Endpoints.Taxonomy.VehicleFeatures(advertiserId, derivativeId, effectiveDate);

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
