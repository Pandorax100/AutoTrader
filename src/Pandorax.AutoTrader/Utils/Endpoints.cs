using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pandorax.AutoTrader.Utils;

internal static class Endpoints
{
    public static string SearchEndpoint(NameValueCollection? query)
    {
        return query is not null && query.Count > 0
            ? $"/service/stock-management/stock?${query}"
            : $"/service/stock-management/stock";
    }

    public static string CreateStockEndpoint(int advertiserId)
        => $"/service/stock-management/stock?advertiserId={advertiserId}";

    public static string UpdateStockEndpoint(string stockId)
        => $"/service/stock-management/stock/{stockId}";

    internal static string? UploadImage(int advertiserId)
        => $"/service/stock-management/images?advertiserId={advertiserId}";
}
