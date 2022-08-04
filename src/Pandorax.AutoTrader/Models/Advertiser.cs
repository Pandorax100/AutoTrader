using Newtonsoft.Json;

namespace Pandorax.AutoTrader.Models;

public class Advertiser
{
    [JsonProperty("advertiserId")]
    public string? AdvertiserId { get; set; }
}
