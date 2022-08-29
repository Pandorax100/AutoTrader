using System.Collections.Specialized;
using System.Web;
using Pandorax.AutoTrader.Api.Stock;
using Pandorax.AutoTrader.Api.Stock.Common;

namespace Pandorax.AutoTrader.Utils;

public static class Endpoints
{
    public static string SearchEndpoint(StockSearchParameters stockSearchParameters)
    {
        var query = BuildStockQueryString(stockSearchParameters);

        return query is not null && query.Count > 0
            ? $"/service/stock-management/stock?{query}"
            : $"/service/stock-management/stock";
    }

    public static string CreateStockEndpoint(int advertiserId)
        => $"/service/stock-management/stock?advertiserId={advertiserId}";

    public static string UpdateStockEndpoint(string stockId)
        => $"/service/stock-management/stock/{stockId}";

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

    private static NameValueCollection BuildStockQueryString(StockSearchParameters parameters)
    {
        Dictionary<string, string?> queryString = new()
        {
            ["advertiserId"] = parameters.AdvertiserId?.ToString(),
            ["pageSize"] = parameters.PageSize.ToString(),
            ["page"] = parameters.Page?.ToString(),
            ["lifecycleState"] = parameters.LifecycleState switch
            {
                LifecycleState.Deleted => "DELETED",
                LifecycleState.Forecourt => "FORECOURT",
                LifecycleState.SaleInProgress => "SALE_IN_PROGRESS",
                LifecycleState.DueIn => "DUE_IN",
                LifecycleState.Wastebin => "WASTEBIN",
                _ => null,
            },
            ["searchId"] = parameters.SearchId,
            ["stockId"] = parameters.StockId,
            ["registration"] = parameters.Registration,
            ["vin"] = parameters.Vin,
        };

        NameValueCollection query = HttpUtility.ParseQueryString(string.Empty);

        foreach (var (key, value) in queryString)
        {
            if (value is not null)
            {
                query.Add(key, value);
            }
        }

        return query;
    }

    public static class Taxonomy
    {
        public static string VehicleTypes()
        {
            return "/service/stock-management/taxonomy/vehicleTypes";
        }

        public static string VehicleMakes(string vehicleType)
        {
            return $"/service/stock-management/taxonomy/makes?vehicleType={vehicleType}";
        }

        public static string VehicleModels(string makeId)
        {
            return $"/service/stock-management/taxonomy/models?makeId={makeId}";
        }

        public static string VehicleGenerations(string modelId)
        {
            return $"/service/stock-management/taxonomy/generations?modelId={modelId}";
        }

        public static string VehicleDerivatives(string generationId)
        {
            return $"/service/stock-management/taxonomy/derivatives?generationId={generationId}";
        }

        public static string TechnicalData(string derivativeId)
        {
            return $"/service/stock-management/taxonomy/derivatives/{derivativeId}";
        }

        public static string VehicleFeatures(string derivativeId, DateOnly effectiveDate)
        {
            return $"/service/stock-management/taxonomy/features?derivativeId={derivativeId}&effectiveDate={effectiveDate:yyyy-MM-dd}";
        }
    }
}
