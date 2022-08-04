using Pandorax.AutoTrader.Api.Stock.Common;

namespace Pandorax.AutoTrader.Api.Stock;

public class StockSearchParameters
{
    public StockSearchParameters()
    {
    }

    /// <summary>
    /// Gets or sets the advertiser id. Only stock for this advertiser id will be returned.
    /// </summary>
    public int? AdvertiserId { get; set; }

    /// <summary>
    /// Gets or sets the number of results returned per page.
    /// 20 is the default and recommended however you may request up to 200.
    /// </summary>
    public int PageSize { get; set; } = 20;

    /// <summary>
    /// Gets or sets the page of results to return.
    /// </summary>
    public int? Page { get; set; }

    /// <summary>
    /// Gets or sets the stock lifecycle state.
    /// </summary>
    public LifecycleState? LifecycleState { get; set; }

    /// <summary>
    /// Gets or sets the search id. Used for a direct call to the stock records details by search Id.
    /// </summary>
    public string? SearchId { get; set; }

    /// <summary>
    /// Gets or sets the stock id. used for a direct call to the stock records details by stock Id.
    /// </summary>
    public string? StockId { get; set; }

    /// <summary>
    /// Gets or sets the vehicle registration number.
    /// </summary>
    public string? Registration { get; set; }

    /// <summary>
    /// Gets or sets the VIN of the search.
    /// </summary>
    public string? Vin { get; set; }
}
