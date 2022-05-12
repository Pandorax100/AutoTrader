using System.Text.Json.Serialization;
using Pandorax.AutoTrader.Converters;

namespace Pandorax.AutoTrader.Models;

[JsonConverter(typeof(VatStatusConverter))]
public enum VatStatus
{
    ExVat,
    IncVat,
    NoVat,
}
