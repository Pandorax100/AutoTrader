using System.Text.Json.Serialization;

namespace Pandorax.AutoTrader.Models;
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Insurance
{
    A,
    D,
    E,
    P,
    U,
}
