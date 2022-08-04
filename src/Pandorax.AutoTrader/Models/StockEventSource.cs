using Newtonsoft.Json;
using Pandorax.AutoTrader.Converters;

namespace Pandorax.AutoTrader.Models;
[JsonConverter(typeof(StockEventSourceConverter))]
public enum StockEventSource
{
    Feed,
    Other,
    Portal,
    StockManagementApi,
}
