using System.Text.Json.Serialization;

namespace Pandorax.AutoTrader.Models;

public class Advertiser
{
    [JsonPropertyName("advertiserId")]
    public string? AdvertiserId { get; set; }
}
