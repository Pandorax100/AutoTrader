using System.Text.Json.Serialization;

namespace Pandorax.AutoTrader.Models;
public class Video
{
    [JsonPropertyName("href")]
    public Uri? Href { get; set; }
}
