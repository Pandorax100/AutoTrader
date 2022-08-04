using Pandorax.AutoTrader.Api.Stock.Common;
using Pandorax.AutoTrader.Api.Stock.Read;

namespace Pandorax.AutoTrader.Api.Stock.Update;

public class UpdateStockResponse
{
    public bool Success { get; set; }

    public List<AutoTraderMessage> Messages { get; set; } = new();

    public AutoTraderVehicleData? AutoTraderVehicleData { get; set; }
}
