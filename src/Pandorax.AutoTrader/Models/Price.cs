using System.Text.Json.Serialization;

namespace Pandorax.AutoTrader.Models;
public class Price
{
    [JsonPropertyName("amountEUR")]
    public int? AmountEur { get; set; }

    [JsonPropertyName("amountGBP")]
    public int? AmountGbp { get; set; }
}
