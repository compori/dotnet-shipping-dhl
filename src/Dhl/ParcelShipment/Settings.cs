using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compori.Shipping.Dhl.ParcelShipment
{
    public class Settings : Common.Settings
    {
        /// <summary>
        /// Gets or sets the user.
        /// </summary>
        /// <value>The user.</value>
        [JsonProperty(PropertyName = "user")]
        public string User { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>The password.</value>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

        /// <summary>
        /// Liefert oder setzt den Api Key.
        /// </summary>
        /// <value>Der API KEy.</value>
        [JsonProperty(PropertyName = "apiKey")]
        public string ApiKey { get; set; }
    }
}
