using Newtonsoft.Json;

namespace Pandorax.AutoTrader.Models;
public class Adverts
{
    [JsonProperty("forecourtPrice")]
    public Price ForecourtPrice { get; set; } = null!;

    [JsonProperty("manufacturerApproved")]
    public bool? ManufacturerApproved { get; set; }

    [JsonProperty("preparationCosts")]
    public Price PreparationCosts { get; set; } = null!;

    [JsonProperty("priceOnApplication")]
    public bool? PriceOnApplication { get; set; }

    [JsonProperty("purchasePrice")]
    public Price PurchasePrice { get; set; } = null!;

    [JsonProperty("reservationStatus")]
    public string? ReservationStatus { get; set; }

    [JsonProperty("retailAdverts")]
    public RetailAdverts RetailAdverts { get; set; } = null!;

    [JsonProperty("soldDate")]
    public DateTime? SoldDate { get; set; }

    [JsonProperty("stockInDate")]
    public DateTime? StockInDate { get; set; }

    [JsonProperty("stockInValue")]
    public Price StockInValue { get; set; } = null!;

    [JsonProperty("twelveMonthsMot")]
    public bool? TwelveMonthsMot { get; set; }
}
