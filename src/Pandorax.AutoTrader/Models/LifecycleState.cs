using System.Text.Json.Serialization;
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
