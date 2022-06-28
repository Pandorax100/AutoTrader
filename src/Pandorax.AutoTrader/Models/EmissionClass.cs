using System.Text.Json.Serialization;
using Pandorax.AutoTrader.Converters;

namespace Pandorax.AutoTrader.Models;
[JsonConverter(typeof(EmissionClassConverter))]
public enum EmissionClass
{
    Euro2,
    Euro3,
    Euro4,
    Euro5,
    Euro6,
}
