using System.Text.Json;
using System.Text.Json.Serialization;
using Pandorax.AutoTrader.Models;

namespace Pandorax.AutoTrader.Converters;
internal class LifecycleStateConverter : JsonConverter<LifecycleState>
{
    public override LifecycleState Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        return reader.GetString() switch
        {
            "DELETED" => LifecycleState.Deleted,
            "DUE_IN" => LifecycleState.DueIn,
            "FORECOURT" => LifecycleState.Forecourt,
            "SALE_IN_PROGRESS" => LifecycleState.SaleInProgress,
            "WASTEBIN" => LifecycleState.Wastebin,
            _ => throw new ArgumentException("Cannot unmarshal type LifecycleState", nameof(reader)),
        };
    }

    public override void Write(Utf8JsonWriter writer, LifecycleState value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value switch
        {
            LifecycleState.Deleted => "DELETED",
            LifecycleState.Forecourt => "FORECOURT",
            LifecycleState.SaleInProgress => "SALE_IN_PROGRESS",
            LifecycleState.Wastebin => "WASTEBIN",
            LifecycleState.DueIn => "DUE_IN",
            _ => throw new ArgumentOutOfRangeException(nameof(value)),
        });
    }
}
