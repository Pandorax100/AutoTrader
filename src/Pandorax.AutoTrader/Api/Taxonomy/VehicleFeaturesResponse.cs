using Pandorax.AutoTrader.Api.Vehicles;

namespace Pandorax.AutoTrader.Api.Taxonomy;

public class VehicleFeaturesResponse
{
    public IList<Feature> Features { get; set; } = new List<Feature>();
}
