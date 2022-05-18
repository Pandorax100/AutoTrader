using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Pandorax.AutoTrader.Converters
{
    /// <summary>
    /// A converter for dates in the format "Wed May 18 09:35:06 UTC 2022".
    /// </summary>
    internal class AccessTokenDateConverter : JsonConverter<DateTimeOffset>
    {
        public override DateTimeOffset Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();

            var dateTime = DateTimeOffset.ParseExact(
                value,
                @"ddd MMM dd HH:mm:ss \U\T\C yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.AssumeUniversal);

            return dateTime;
        }

        public override void Write(Utf8JsonWriter writer, DateTimeOffset value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
