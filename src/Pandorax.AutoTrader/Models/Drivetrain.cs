using System.Text.Json.Serialization;
using Pandorax.AutoTrader.Converters;

namespace Pandorax.AutoTrader.Models;

[JsonConverter(typeof(DrivetrainConverter))]
public enum Drivetrain
{
    ChainDrive,
    FourWheelDrive,
    FrontWheelDrive,
    RearWheelDrive,
}
