using Newtonsoft.Json;
using Pandorax.AutoTrader.Converters;

namespace Pandorax.AutoTrader.Api.Notifications;
[JsonConverter(typeof(StockEventSourceConverter))]
public enum StockEventSource
{
    Feed,
    Other,
    Portal,
    StockManagementApi,
}
