using System.Text.Json.Serialization;

namespace Pandorax.AutoTrader.Models;
public class Adverts
{
    [JsonPropertyName("forecourtPrice")]
    public Price ForecourtPrice { get; set; } = null!;

    [JsonPropertyName("manufacturerApproved")]
    public bool ManufacturerApproved { get; set; }

    [JsonPropertyName("preparationCosts")]
    public Price PreparationCosts { get; set; } = null!;

    [JsonPropertyName("priceOnApplication")]
    public bool PriceOnApplication { get; set; }

    [JsonPropertyName("purchasePrice")]
    public Price PurchasePrice { get; set; } = null!;

    [JsonPropertyName("reservationStatus")]
    public string? ReservationStatus { get; set; }

    [JsonPropertyName("retailAdverts")]
    public RetailAdverts RetailAdverts { get; set; } = null!;

    [JsonPropertyName("soldDate")]
    public DateTimeOffset? SoldDate { get; set; }

    [JsonPropertyName("stockInDate")]
    public DateTimeOffset? StockInDate { get; set; }

    [JsonPropertyName("stockInValue")]
    public Price StockInValue { get; set; } = null!;

    [JsonPropertyName("twelveMonthsMot")]
    public bool TwelveMonthsMot { get; set; }
}
