using Pandorax.AutoTrader.Api.Images;
using Pandorax.AutoTrader.Api.Notifications;
using Pandorax.AutoTrader.Api.Stock;
using Pandorax.AutoTrader.Api.Stock.Read;
using Pandorax.AutoTrader.Api.Stock.Update;
using Pandorax.AutoTrader.Api.Vehicles;

namespace Pandorax.AutoTrader.Services;

public interface IAutoTraderService
{
    AutoTraderNotification? ParseNotificationJson(string json);

    /// <summary>
    /// Retrieves stock records and optionally searches by the given parameters.
    /// </summary>
    /// <param name="parameters">The search parameters to use in the vehicle search.</param>
    /// <returns>
    /// A task representing the asynchronous operation. The result of the task is an object containing the total number
    /// of records and a list of the records on the current page.
    /// </returns>
    Task<StockListResult?> GetStockAsync(StockSearchParameters parameters);

    /// <summary>
    /// Retrieves all stock records across all pages, optionally searching by the given parameters.
    /// </summary>
    /// <remarks>
    /// This method may make multiple call to the API across multiple pages to gather all stock results for the given search.
    /// </remarks>
    /// <param name="parameters">The search parameters to use in the vehicle search.</param>
    /// <returns>
    /// A task representing the asynchronous operation. The result of the task is an object containing the all
    /// the records on all pages.
    /// </returns>
    Task<List<AutoTraderVehicleData>> GetAllStockAsync(StockSearchParameters parameters);

    Task<UpdateStockResponse> CreateStockAsync(int advertiserId, AutoTraderVehicleUpdateRequest vehicle);
    Task<UpdateStockResponse> UpdateStockAsync(string stockId, AutoTraderVehicleUpdateRequest vehicle);
    Task<UpdateStockResponse> RemoveStockItemAsync(string stockId);

    Task<UploadImageResponse> UploadImageAsync(int advertiserId, Stream stream, string contentType, string fileName);

    Task<VehicleRoot?> GetVehicleDataAsync(
        string vehicleRegistration,
        bool includeMots = false,
        bool includeFeatures = false,
        bool includeBasicVehicleCheck = false,
        bool includeFullVehicleCheck = false);
}
