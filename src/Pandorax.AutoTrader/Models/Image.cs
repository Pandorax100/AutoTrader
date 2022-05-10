using System.Text.Json.Serialization;

namespace Pandorax.AutoTrader.Models;
public class Image
{
    [JsonPropertyName("href")]
    public string Href { get; set; } = null!;

    [JsonPropertyName("imageId")]
    public string ImageId { get; set; } = null!;
}
