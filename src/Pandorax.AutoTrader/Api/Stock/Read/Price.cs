using Newtonsoft.Json;

namespace Pandorax.AutoTrader.Api.Stock.Read;
public class Price
{
    [JsonProperty("amountEUR")]
    public int? AmountEur { get; set; }

    [JsonProperty("amountGBP")]
    public int? AmountGbp { get; set; }
}
