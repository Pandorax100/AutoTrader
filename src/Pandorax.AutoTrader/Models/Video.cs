using Newtonsoft.Json;

namespace Pandorax.AutoTrader.Models;
public class Video
{
    [JsonProperty("href")]
    public Uri? Href { get; set; }
}
