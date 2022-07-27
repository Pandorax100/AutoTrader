using System.Text.Json;
using Pandorax.AutoTrader.Converters;

namespace Pandorax.AutoTrader.Serializer;

public class AutoTraderJsonSerializer
{
    public static readonly JsonSerializerOptions Options = new JsonSerializerOptions(JsonSerializerDefaults.Web)
    {
        Converters =
        {
            new DateOnlyConverter(),
            new DrivetrainConverter(),
            new EmissionClassConverter(),
            new LifecycleStateConverter(),
            new OwnershipConditionConverter(),
            new StatusConverter(),
            new StockEventSourceConverter(),
            new VatStatusConverter(),
        },
    };

    public static TValue? Deserialize<TValue>(string json)
    {
        return JsonSerializer.Deserialize<TValue>(json, Options);
    }
}
