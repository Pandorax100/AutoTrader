using System.Text.Json.Serialization;
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
