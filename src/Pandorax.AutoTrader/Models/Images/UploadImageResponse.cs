using Newtonsoft.Json;

namespace Pandorax.AutoTrader.Models.Images;

public class UploadImageResponse
{
    [JsonProperty("imageId")]
    public string ImageId { get; set; } = string.Empty;
}
