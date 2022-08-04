using Newtonsoft.Json;
using Pandorax.AutoTrader.Converters;

namespace Pandorax.AutoTrader.Models;
[JsonConverter(typeof(OwnershipConditionConverter))]
public enum OwnershipCondition
{
    New,
    Used,
}
