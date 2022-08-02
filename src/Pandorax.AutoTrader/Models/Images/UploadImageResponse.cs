using System.Text.Json.Serialization;

namespace Pandorax.AutoTrader.Models.Images;

public class UploadImageResponse
{
    [JsonPropertyName("imageId")]
    public string ImageId { get; set; } = string.Empty;
}
