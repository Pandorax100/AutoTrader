using System.Text.Json.Serialization;

namespace Pandorax.AutoTrader.Models;
public class ForecourtPrice
{
    [JsonPropertyName("amountGBP")]
    public int? AmountGbp { get; set; }
}
