using Newtonsoft.Json;
using Pandorax.AutoTrader.Api.Stock.Read;
using Pandorax.AutoTrader.Api.Taxonomy;
using Pandorax.AutoTrader.Api.Taxonomy.Facets;
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
    public async Task<IList<VehicleDerivative>> GetVehicleDerivativesAsync(
        int advertiserId,
        string vehicleGenerationId,
        string? fuelType = null,
        string? transmission = null,
        string? trim = null,
        string? doors = null,
        string? drivetrain = null,
        string? badgeEngineSize = null)
    {
        ArgumentNullException.ThrowIfNull(vehicleGenerationId);

        string url = Endpoints.Taxonomy.VehicleDerivatives(
            advertiserId,
            vehicleGenerationId,
            fuelType,
            transmission,
            trim,
            doors,
            drivetrain,
            badgeEngineSize);

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
        ArgumentNullException.ThrowIfNull(derivativeId);

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

    /// <inheritdoc />
    public async Task<IList<string>> GetFuelTypesForGenerationAsync(int advertiserId, string vehicleGenerationId)
    {
        ArgumentNullException.ThrowIfNull(vehicleGenerationId);

        string url = Endpoints.Taxonomy.FuelTypes(advertiserId, vehicleGenerationId);

        var response = await PerformRequest<FuelTypesResponse>(url);

        return response.FuelTypes;
    }

    /// <inheritdoc />
    public async Task<IList<string>> GetTransmissionsForGenerationAsync(int advertiserId, string vehicleGenerationId)
    {
        ArgumentNullException.ThrowIfNull(vehicleGenerationId);

        string url = Endpoints.Taxonomy.FuelTypes(advertiserId, vehicleGenerationId);

        var response = await PerformRequest<TransmissionResponse>(url);

        return response.Transmissions;
    }

    /// <inheritdoc />
    public async Task<IList<string>> GetBodyTypesForGenerationAsync(int advertiserId, string vehicleGenerationId)
    {
        ArgumentNullException.ThrowIfNull(vehicleGenerationId);

        string url = Endpoints.Taxonomy.BodyTypes(advertiserId, vehicleGenerationId);

        var response = await PerformRequest<BodyTypesResponse>(url);

        return response.BodyTypes;
    }

    /// <inheritdoc />
    public async Task<IList<string>> GetTrimsForGenerationAsync(int advertiserId, string vehicleGenerationId)
    {
        ArgumentNullException.ThrowIfNull(vehicleGenerationId);

        string url = Endpoints.Taxonomy.Trims(advertiserId, vehicleGenerationId);

        var response = await PerformRequest<TrimsResponse>(url);

        return response.Trims;
    }

    /// <inheritdoc />
    public async Task<IList<string>> GetDoorsForGenerationAsync(int advertiserId, string vehicleGenerationId)
    {
        ArgumentNullException.ThrowIfNull(vehicleGenerationId);

        string url = Endpoints.Taxonomy.Doors(advertiserId, vehicleGenerationId);

        var response = await PerformRequest<DoorsResponse>(url);

        return response.Doors;
    }

    /// <inheritdoc />
    public async Task<IList<string>> GetDrivetrainsForGenerationAsync(int advertiserId, string vehicleGenerationId)
    {
        ArgumentNullException.ThrowIfNull(vehicleGenerationId);

        string url = Endpoints.Taxonomy.Drivetrains(advertiserId, vehicleGenerationId);

        var response = await PerformRequest<DrivetrainsResponse>(url);

        return response.Drivetrains;
    }

    /// <inheritdoc />
    public async Task<IList<string>> GetBadgeEngineSizesForGenerationAsync(int advertiserId, string vehicleGenerationId)
    {
        ArgumentNullException.ThrowIfNull(vehicleGenerationId);

        string url = Endpoints.Taxonomy.BadgeEngineSizes(advertiserId, vehicleGenerationId);

        var response = await PerformRequest<BadgeEngineSizesResponse>(url);

        return response.BadgeEngineSizes;
    }

    private async Task<T> PerformRequest<T>(string url)
    {
        string responseJson = await _httpClient.GetStringAsync(url);

        T? deserialized = JsonConvert.DeserializeObject<T>(responseJson, AutoTraderJsonSerializer.SettingsWithoutContractResolver);

        return deserialized!;
    }
}
