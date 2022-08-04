using Newtonsoft.Json;

namespace Pandorax.AutoTrader.Api.Stock.Update;

public class Image
{
    [JsonProperty("imageId")]
    public string ImageId { get; set; } = null!;
}
