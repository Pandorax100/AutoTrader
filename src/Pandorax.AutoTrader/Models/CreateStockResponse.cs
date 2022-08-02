namespace Pandorax.AutoTrader.Models;

public class CreateStockResponse
{
    public bool Success { get; set; }

    public List<AutoTraderMessage> Messages { get; set; } = new();

    public AutoTraderVehicleData? AutoTraderVehicleData { get; set; }
}
