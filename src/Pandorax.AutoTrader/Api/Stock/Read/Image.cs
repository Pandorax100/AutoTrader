using Newtonsoft.Json;

namespace Pandorax.AutoTrader.Api.Stock.Read;
public class Image
{
    [JsonProperty("href")]
    public string Href { get; set; } = null!;
}
