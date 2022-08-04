using Newtonsoft.Json;

namespace Pandorax.AutoTrader.Models;
public class Image
{
    [JsonProperty("href")]
    public string Href { get; set; } = null!;

    [JsonProperty("imageId")]
    public string ImageId { get; set; } = null!;
}
