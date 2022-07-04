using System.Text.Json.Serialization;

namespace Pandorax.AutoTrader.Models.Images;

public class ImageCreatedResponse
{
    [JsonPropertyName("imageId")]
    public string ImageId { get; set; } = string.Empty;
}
