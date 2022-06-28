using System.Text.Json.Serialization;

namespace Pandorax.AutoTrader.Models;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum PriceIndicatorRating
{
    Fair,
    Good,
    Great,
    High,
    Low,
    NoAnalysis,
}
