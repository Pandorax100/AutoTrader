using Newtonsoft.Json;

namespace Pandorax.AutoTrader.Api.Stock.Common;

public class Video
{
    [JsonProperty("href")]
    public Uri? Href { get; set; }
}
