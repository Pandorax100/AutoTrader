using Newtonsoft.Json;
using Pandorax.AutoTrader.Utils;

namespace Pandorax.AutoTrader.Api.Stock.Update;

public class Price
{
    [JsonProperty("amountEUR")]
    public Optional<int?> AmountEur { get; set; }

    [JsonProperty("amountGBP")]
    public Optional<int?> AmountGbp { get; set; }
}
