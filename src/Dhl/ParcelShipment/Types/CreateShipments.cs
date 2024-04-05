using Newtonsoft.Json;
using System.Collections.Generic;

namespace Compori.Shipping.Dhl.ParcelShipment.Types
{
    public class CreateShipments
    {
        /// <summary>
        /// Liefert oder setzt das Profil. Z.B. "STANDARD_GRUPPENPROFIL"
        /// </summary>
        /// <value>Das Profil.</value>
        [JsonProperty(PropertyName = "profile")]
        public string Profile { get; set; }

        /// <summary>
        /// Liefert oder setzt die Versandaufträge.
        /// </summary>
        /// <value>Die Versandaufträge.</value>
        [JsonProperty(PropertyName = "shipments")]
        public List<CreateShipment> Shipments { get; set; } = new List<CreateShipment>();
    }
}
