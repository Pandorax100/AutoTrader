using Newtonsoft.Json;

namespace Pandorax.AutoTrader.Models;

public class Media
{
    [JsonProperty("images")]
    public List<Image> Images { get; set; } = null!;

    [JsonProperty("video")]
    public Video Video { get; set; } = null!;
}
