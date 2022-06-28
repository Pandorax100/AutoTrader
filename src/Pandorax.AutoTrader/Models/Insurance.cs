using System.Text.Json.Serialization;

namespace Pandorax.AutoTrader.Models;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Insurance
{
    A,
    B,
    C,
    D,
    E,
    S,
    N,
    P,
    U,
}
