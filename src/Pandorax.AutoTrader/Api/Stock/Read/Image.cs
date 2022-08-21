using Newtonsoft.Json;

namespace Pandorax.AutoTrader.Api.Stock.Read;

public class Image
{
    [JsonProperty("href")]
    public Uri Href { get; set; } = null!;
}
