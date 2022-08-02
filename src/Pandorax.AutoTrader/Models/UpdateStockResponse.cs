namespace Pandorax.AutoTrader.Models;

public class UpdateStockResponse
{
    public bool Success { get; set; }

    public List<AutoTraderMessage> Messages { get; set; } = new();

    public AutoTraderVehicleData? AutoTraderVehicleData { get; set; }
}
