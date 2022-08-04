using Newtonsoft.Json;

namespace Pandorax.AutoTrader.Api.Stock.Read;

public class Advertiser
{
    [JsonProperty("advertiserId")]
    public string? AdvertiserId { get; set; }
}
