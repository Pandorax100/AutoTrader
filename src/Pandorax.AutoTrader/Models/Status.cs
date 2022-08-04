using Newtonsoft.Json;
using Pandorax.AutoTrader.Converters;

namespace Pandorax.AutoTrader.Models;

[JsonConverter(typeof(StatusConverter))]
public enum Status
{
    Capped,
    NotPublished,
    Published,
    Rejected,
}
