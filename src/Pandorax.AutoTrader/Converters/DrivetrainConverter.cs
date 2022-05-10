using System.Text.Json;
using System.Text.Json.Serialization;
using Pandorax.AutoTrader.Models;

namespace Pandorax.AutoTrader.Converters;
internal class DrivetrainConverter : JsonConverter<Drivetrain>
{
    public override Drivetrain Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        return reader.GetString() switch
        {
            "Chain Drive" => Drivetrain.ChainDrive,
            "Four Wheel Drive" => Drivetrain.FourWheelDrive,
            "Front Wheel Drive" => Drivetrain.FrontWheelDrive,
            "Rear Wheel Drive" => Drivetrain.RearWheelDrive,
            _ => throw new ArgumentException("Cannot unmarshal type Drivetrain", nameof(reader)),
        };
    }

    public override void Write(Utf8JsonWriter writer, Drivetrain value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value switch
        {
            Drivetrain.ChainDrive => "Chain Drive",
            Drivetrain.FourWheelDrive => "Four Wheel Drive",
            Drivetrain.FrontWheelDrive => "Front Wheel Drive",
            Drivetrain.RearWheelDrive => "Rear Wheel Drive",
            _ => throw new ArgumentOutOfRangeException(nameof(value)),
        });
    }
}
