using Newtonsoft.Json;
using Pandorax.AutoTrader.Converters;

namespace Pandorax.AutoTrader.Models;

[JsonConverter(typeof(LifecycleStateConverter))]
public enum LifecycleState
{
    Deleted,
    Forecourt,
    SaleInProgress,
    DueIn,
    Wastebin,
}
