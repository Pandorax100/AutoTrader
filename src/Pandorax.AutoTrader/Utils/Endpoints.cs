using System.Collections.Specialized;
using System.Web;
using Pandorax.AutoTrader.Api.Stock;
using Pandorax.AutoTrader.Api.Stock.Common;

namespace Pandorax.AutoTrader.Utils;

public static class Endpoints
{
    public static string SearchEndpoint(StockSearchParameters stockSearchParameters)
    {
        Dictionary<string, string?> queryParams = new()
        {
            ["advertiserId"] = stockSearchParameters.AdvertiserId?.ToString(),
            ["pageSize"] = stockSearchParameters.PageSize.ToString(),
            ["page"] = stockSearchParameters.Page?.ToString(),
            ["lifecycleState"] = stockSearchParameters.LifecycleState switch
            {
                LifecycleState.Deleted => "DELETED",
                LifecycleState.Forecourt => "FORECOURT",
                LifecycleState.SaleInProgress => "SALE_IN_PROGRESS",
                LifecycleState.DueIn => "DUE_IN",
                LifecycleState.Wastebin => "WASTEBIN",
                _ => null,
            },
            ["searchId"] = stockSearchParameters.SearchId,
            ["stockId"] = stockSearchParameters.StockId,
            ["registration"] = stockSearchParameters.Registration,
            ["vin"] = stockSearchParameters.Vin,
        };

        string url = QueryHelpers.AddQueryString(
            "/service/stock-management/stock",
            queryParams);

        return url;
    }

    public static string CreateStockEndpoint(int advertiserId)
        => $"/service/stock-management/stock?advertiserId={advertiserId}";

    public static string UpdateStockEndpoint(int advertiserId, string stockId)
        => $"/service/stock-management/stock/{stockId}?advertiserId={advertiserId}";

    public static string? UploadImage(int advertiserId)
        => $"/service/stock-management/images?advertiserId={advertiserId}";

    public static string VehicleData(
        int advertiserId,
        string vehicleRegistration,
        bool includeMots,
        bool includeFeatures,
        bool includeBasicVehicleCheck,
        bool includeFullVehicleCheck)
    {
        var query = HttpUtility.ParseQueryString(string.Empty);
        query.Add("advertiserId", advertiserId.ToString());
        query.Add("registration", vehicleRegistration);

        if (includeMots)
        {
            query.Add("motTests", "true");
        }

        if (includeFeatures)
        {
            query.Add("features", "true");
        }

        if (includeBasicVehicleCheck)
        {
            query.Add("basicVehicleCheck", "true");
        }

        if (includeFullVehicleCheck)
        {
            query.Add("fullVehicleCheck", "true");
        }

        return $"/service/stock-management/vehicles?{query}";
    }

    public static class Taxonomy
    {
        public static string VehicleTypes(int advertiserId)
        {
            return $"/service/stock-management/taxonomy/vehicleTypes?advertiserId={advertiserId}";
        }

        public static string VehicleMakes(int advertiserId, string vehicleType)
        {
            return $"/service/stock-management/taxonomy/makes?advertiserId={advertiserId}&vehicleType={vehicleType}";
        }

        public static string VehicleModels(int advertiserId, string makeId)
        {
            return $"/service/stock-management/taxonomy/models?advertiserId={advertiserId}&makeId={makeId}";
        }

        public static string VehicleGenerations(int advertiserId, string modelId)
        {
            return $"/service/stock-management/taxonomy/generations?advertiserId={advertiserId}&modelId={modelId}";
        }

        public static string TechnicalData(int advertiserId, string derivativeId)
        {
            return $"/service/stock-management/taxonomy/derivatives/{derivativeId}?advertiserId={advertiserId}";
        }

        public static string VehicleFeatures(int advertiserId, string derivativeId, DateOnly effectiveDate)
        {
            return $"/service/stock-management/taxonomy/features?advertiserId={advertiserId}&derivativeId={derivativeId}&effectiveDate={effectiveDate:yyyy-MM-dd}";
        }

        public static string FuelTypes(int advertiserId, string generationId)
        {
            return $"/service/stock-management/taxonomy/fuelTypes?advertiserId={advertiserId}&generationId={generationId}";
        }

        public static string Transmissions(int advertiserId, string generationId)
        {
            return $"/service/stock-management/taxonomy/transmissions?advertiserId={advertiserId}&generationId={generationId}";
        }

        public static string BodyTypes(int advertiserId, string generationId)
        {
            return $"/service/stock-management/taxonomy/bodyTypes?advertiserId={advertiserId}&generationId={generationId}";
        }

        public static string Trims(int advertiserId, string generationId)
        {
            return $"/service/stock-management/taxonomy/trims?advertiserId={advertiserId}&generationId={generationId}";
        }

        public static string Doors(int advertiserId, string generationId)
        {
            return $"/service/stock-management/taxonomy/doors?advertiserId={advertiserId}&generationId={generationId}";
        }

        public static string Drivetrains(int advertiserId, string generationId)
        {
            return $"/service/stock-management/taxonomy/drivetrains?advertiserId={advertiserId}&generationId={generationId}";
        }

        public static string BadgeEngineSizes(int advertiserId, string generationId)
        {
            return $"/service/stock-management/taxonomy/badgeEngineSizes?advertiserId={advertiserId}&generationId={generationId}";
        }

        public static string VehicleDerivatives(
            int advertiserId,
            string vehicleGenerationId,
            string? fuelType,
            string? transmission,
            string? trim,
            string? doors,
            string? drivetrain,
            string? badgeEngineSize)
        {
            Dictionary<string, string?> queryParameters = new()
            {
                ["advertiserId"] = advertiserId.ToString(),
                ["generationId"] = vehicleGenerationId,
                ["transmission"] = transmission,
                ["trim"] = trim,
                ["doors"] = doors,
                ["drivetrain"] = drivetrain,
                ["badgeEngineSize"] = badgeEngineSize,
                ["fuelType"] = fuelType,
            };

            string url = QueryHelpers.AddQueryString(
                "/service/stock-management/taxonomy/derivatives",
                queryParameters);

            return url;
        }
    }
}
