using Newtonsoft.Json;

namespace Pandorax.AutoTrader.Models;

public class Check
{
    [JsonProperty("colourChanged")]
    public bool? ColourChanged { get; set; }

    [JsonProperty("exported")]
    public bool? Exported { get; set; }

    [JsonProperty("highRisk")]
    public bool? HighRisk { get; set; }

    [JsonProperty("imported")]
    public bool? Imported { get; set; }

    [JsonProperty("insuranceWriteoffCategory")]
    public Insurance? InsuranceWriteoffCategory { get; set; }

    [JsonProperty("mileageDiscrepancy")]
    public bool? MileageDiscrepancy { get; set; }

    [JsonProperty("previousOwners")]
    public int? PreviousOwners { get; set; }

    [JsonProperty("privateFinance")]
    public bool? PrivateFinance { get; set; }

    [JsonProperty("registrationChanged")]
    public bool? RegistrationChanged { get; set; }

    [JsonProperty("scrapped")]
    public bool? Scrapped { get; set; }

    [JsonProperty("stolen")]
    public bool? Stolen { get; set; }

    [JsonProperty("tradeFinance")]
    public bool? TradeFinance { get; set; }
}
