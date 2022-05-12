using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Pandorax.AutoTrader.Models;

namespace Pandorax.AutoTrader
{
    public class AutoTraderService
    {
        private static readonly JsonSerializerOptions JsonSerializerOptions = new()
        {
            NumberHandling = JsonNumberHandling.AllowReadingFromString,
        };

        public AutoTraderNotification? ParseNotificationJson(string json)
        {
            return JsonSerializer.Deserialize<AutoTraderNotification>(json, JsonSerializerOptions);
        }
    }
}
