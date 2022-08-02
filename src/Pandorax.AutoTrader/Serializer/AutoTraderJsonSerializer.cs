using System.Text.Json;
using System.Text.Json.Serialization;
using Pandorax.AutoTrader.Converters;

namespace Pandorax.AutoTrader.Serializer;

public class AutoTraderJsonSerializer
{
    public static readonly JsonSerializerOptions Options = new JsonSerializerOptions(JsonSerializerDefaults.Web)
    {
        Converters =
        {
            new DateOnlyConverter(),
            new EmissionClassConverter(),
            new LifecycleStateConverter(),
            new OwnershipConditionConverter(),
            new StatusConverter(),
            new StockEventSourceConverter(),
            new VatStatusConverter(),
        },
    };

    /// <summary>
    /// An instance of the <see cref="JsonSerializerOptions"/> for use with the AutoTrader API which does not write default values.
    /// </summary>
    public static readonly JsonSerializerOptions OptionsNoWriteNull = new JsonSerializerOptions(Options)
    {
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
    };

    public static TValue? Deserialize<TValue>(string json)
    {
        return JsonSerializer.Deserialize<TValue>(json, Options);
    }
}
