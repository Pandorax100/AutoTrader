using System.Collections.Specialized;
using System.Web;
using Pandorax.AutoTrader.Models;
using Pandorax.AutoTrader.Models.Stock;

namespace Pandorax.AutoTrader.Utils;

public static class Endpoints
{
    internal static string SearchEndpoint(StockSearchParameters stockSearchParameters)
    {
        var query = BuildStockQueryString(stockSearchParameters);

        return query is not null && query.Count > 0
            ? $"/service/stock-management/stock?${query}"
            : $"/service/stock-management/stock";
    }

    internal static string CreateStockEndpoint(int advertiserId)
        => $"/service/stock-management/stock?advertiserId={advertiserId}";

    internal static string UpdateStockEndpoint(string stockId)
        => $"/service/stock-management/stock/{stockId}";

    internal static string? UploadImage(int advertiserId)
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
            ["advertiserId"] = parameters.AdvertiserId,
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
}
