using System.Text.Json.Serialization;

namespace Pandorax.AutoTrader.Models;
public class TotalPrice
{
    [JsonPropertyName("amountEUR")]
    public long? AmountEur { get; set; }

    [JsonPropertyName("amountGBP")]
    public long AmountGbp { get; set; }
}
