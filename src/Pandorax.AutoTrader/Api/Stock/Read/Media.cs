using Newtonsoft.Json;
using Pandorax.AutoTrader.Api.Stock.Common;

namespace Pandorax.AutoTrader.Api.Stock.Read;

public class Media
{
    [JsonProperty("images")]
    public List<Image> Images { get; set; } = null!;

    [JsonProperty("video")]
    public Video Video { get; set; } = null!;
}
