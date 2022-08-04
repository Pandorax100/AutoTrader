using Newtonsoft.Json;
using Pandorax.AutoTrader.Converters;

namespace Pandorax.AutoTrader.Api.Stock.Common;

[JsonConverter(typeof(StatusConverter))]
public enum Status
{
    Capped,
    NotPublished,
    Published,
    Rejected,
}
