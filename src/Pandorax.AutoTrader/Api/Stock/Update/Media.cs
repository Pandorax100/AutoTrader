using Newtonsoft.Json;
using Pandorax.AutoTrader.Api.Stock.Common;
using Pandorax.AutoTrader.Utils;

namespace Pandorax.AutoTrader.Api.Stock.Update;

public class Media
{
    [JsonProperty("images")]
    public Optional<List<Image>> Images { get; set; }

    [JsonProperty("video")]
    public Optional<Video> Video { get; set; }
}
