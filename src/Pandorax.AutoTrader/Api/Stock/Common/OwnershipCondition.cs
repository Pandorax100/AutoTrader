using Newtonsoft.Json;
using Pandorax.AutoTrader.Converters;

namespace Pandorax.AutoTrader.Api.Stock.Common;
[JsonConverter(typeof(OwnershipConditionConverter))]
public enum OwnershipCondition
{
    New,
    Used,
}
