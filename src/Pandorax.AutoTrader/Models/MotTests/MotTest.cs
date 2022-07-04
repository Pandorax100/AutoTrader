using System.Text.Json.Serialization;
using Pandorax.AutoTrader.Converters;

namespace Pandorax.AutoTrader.Models.MotTests;

public class MotTest
{
    [JsonPropertyName("completedDate")]
    public DateTime CompletedDate { get; set; }

    [JsonPropertyName("expiryDate")]
    [JsonConverter(typeof(DateOnlyConverter))]
    public DateOnly? ExpiryDate { get; set; }

    [JsonPropertyName("testResult")]
    public string TestResult { get; set; } = string.Empty;

    [JsonPropertyName("odometerValue")]
    public int OdometerValue { get; set; }

    [JsonPropertyName("odometerUnit")]
    public string OdometerUnit { get; set; } = string.Empty;

    [JsonPropertyName("motTestNumber")]
    public string MotTestNumber { get; set; } = string.Empty;

    [JsonPropertyName("comments")]
    public List<MotComment> Comments { get; set; } = new();
}
