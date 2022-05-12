using System.Text.Json.Serialization;

namespace Pandorax.AutoTrader.Models;
public class Check
{
    [JsonPropertyName("colourChanged")]
    public bool? ColourChanged { get; set; }

    [JsonPropertyName("exported")]
    public bool? Exported { get; set; }

    [JsonPropertyName("highRisk")]
    public bool? HighRisk { get; set; }

    [JsonPropertyName("imported")]
    public bool? Imported { get; set; }

    [JsonPropertyName("insuranceWriteoffCategory")]
    public Insurance? InsuranceWriteoffCategory { get; set; }

    [JsonPropertyName("mileageDiscrepancy")]
    public bool? MileageDiscrepancy { get; set; }

    [JsonPropertyName("previousOwners")]
    public int? PreviousOwners { get; set; }

    [JsonPropertyName("privateFinance")]
    public bool? PrivateFinance { get; set; }

    [JsonPropertyName("registrationChanged")]
    public bool? RegistrationChanged { get; set; }

    [JsonPropertyName("scrapped")]
    public bool? Scrapped { get; set; }

    [JsonPropertyName("stolen")]
    public bool? Stolen { get; set; }

    [JsonPropertyName("tradeFinance")]
    public bool? TradeFinance { get; set; }
}
