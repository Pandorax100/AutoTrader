using System.Text.Json.Serialization;
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
