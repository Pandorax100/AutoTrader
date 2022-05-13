using Pandorax.AutoTrader.Models;

namespace Pandorax.AutoTrader
{
    public interface IAutoTraderService
    {
        AutoTraderNotification? ParseNotificationJson(string json);
        Task<StockListResult> GetStockByAdvertiserIdAsync(string advertiserId);
    }
}
