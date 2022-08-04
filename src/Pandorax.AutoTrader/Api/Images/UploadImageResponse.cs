using Newtonsoft.Json;

namespace Pandorax.AutoTrader.Api.Images;

public class UploadImageResponse
{
    [JsonProperty("imageId")]
    public string ImageId { get; set; } = string.Empty;
}
