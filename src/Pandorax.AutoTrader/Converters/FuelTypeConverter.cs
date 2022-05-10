using System.Text.Json;
using System.Text.Json.Serialization;
using Pandorax.AutoTrader.Models;

namespace Pandorax.AutoTrader.Converters;
internal class FuelTypeConverter : JsonConverter<FuelType>
{
    public override FuelType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        string? value = reader.GetString();

        // Some of these values differ by case, so the usual switch case expression
        // wouldn't work here.
        if (string.Equals(value, "Diesel", StringComparison.OrdinalIgnoreCase))
        {
            return FuelType.Diesel;
        }

        if (string.Equals(value, "Diesel Plug-in Hybrid", StringComparison.OrdinalIgnoreCase))
        {
            return FuelType.DieselPlugInHybrid;
        }

        if (string.Equals(value, "Electric", StringComparison.OrdinalIgnoreCase))
        {
            return FuelType.Electric;
        }

        if (string.Equals(value, "Petrol", StringComparison.OrdinalIgnoreCase))
        {
            return FuelType.Petrol;
        }

        if (string.Equals(value, "Petrol Hybrid", StringComparison.OrdinalIgnoreCase))
        {
            return FuelType.PetrolHybrid;
        }

        if (string.Equals(value, "Petrol Plug-in Hybrid", StringComparison.OrdinalIgnoreCase))
        {
            return FuelType.PetrolPlugInHybrid;
        }

        if (string.Equals(value, "Unlisted", StringComparison.OrdinalIgnoreCase))
        {
            return FuelType.Unlisted;
        }

        throw new ArgumentException("Cannot unmarshal type FuelType", nameof(reader));
    }

    public override void Write(Utf8JsonWriter writer, FuelType value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value switch
        {
            FuelType.Diesel => "Diesel",
            FuelType.DieselPlugInHybrid => "Diesel Plug-in Hybrid",
            FuelType.Electric => "Electric",
            FuelType.Petrol => "Petrol",
            FuelType.PetrolHybrid => "Petrol Hybrid",
            FuelType.PetrolPlugInHybrid => "Petrol Plug-in Hybrid",
            FuelType.Unlisted => "Unlisted",
            _ => throw new ArgumentOutOfRangeException(nameof(value)),
        });
    }
}
