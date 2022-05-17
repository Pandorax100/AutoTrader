using Pandorax.AutoTrader.Models;

namespace Pandorax.AutoTrader;

public interface IAutoTraderService
{
    AutoTraderNotification? ParseNotificationJson(string json);

    /// <summary>
    /// Retreives stock records and optionally searches by the given parameters.
    /// </summary>
    /// <param name="advertiserId">An optional advertiser id to return stock associated to a specific advertiser.</param>
    /// <param name="pageSize">
    /// Use this to adjust the number of results returned per page.
    /// 20 is the default and recommended however you may request up to 200.
    /// </param>
    /// <param name="page">
    /// <para>Used to request subsequten pages of results.</para>
    /// <para>Pagination volume can be calculated by totalResults / pageSize.</para>
    /// </param>
    /// <param name="lifecycleState">
    /// Used to retreive stock with a specific lifecycle state.
    /// </param>
    /// <param name="searchId">Used for a direct call to the stock records details by search Id.</param>
    /// <param name="stockId">Used for a direct call to the stock records details by stock Id.</param>
    /// <param name="registration">The vehicle registration number.</param>
    /// <param name="vin">The VIN of the vehicle.</param>
    /// <returns>
    /// A tast representing the asynchronous operation. The result of the task is an object containing the total number
    /// of records and a list of the records on the current page.
    /// </returns>
    Task<StockListResult?> GetStockAsync(
        string? advertiserId = null,
        int? pageSize = null,
        int? page = null,
        LifecycleState? lifecycleState = null,
        string? searchId = null,
        string? stockId = null,
        string? registration = null,
        string? vin = null);
}
