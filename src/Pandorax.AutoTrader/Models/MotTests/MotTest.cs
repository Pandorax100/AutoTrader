using Newtonsoft.Json;
using Pandorax.AutoTrader.Converters;

namespace Pandorax.AutoTrader.Models.MotTests;

public class MotTest
{
    [JsonProperty("completedDate")]
    public DateTime CompletedDate { get; set; }

    [JsonProperty("expiryDate")]
    [JsonConverter(typeof(DateOnlyConverter))]
    public DateOnly? ExpiryDate { get; set; }

    [JsonProperty("testResult")]
    public string TestResult { get; set; } = string.Empty;

    [JsonProperty("odometerValue")]
    public int OdometerValue { get; set; }

    [JsonProperty("odometerUnit")]
    public string OdometerUnit { get; set; } = string.Empty;

    [JsonProperty("motTestNumber")]
    public string MotTestNumber { get; set; } = string.Empty;

    [JsonProperty("rfrAndComments")]
    public List<MotComment> Comments { get; set; } = new();
}
