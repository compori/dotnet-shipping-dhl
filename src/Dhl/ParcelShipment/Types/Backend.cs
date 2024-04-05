using Newtonsoft.Json;

namespace Compori.Shipping.Dhl.ParcelShipment.Types
{
    public class Backend
    {
        /// <summary>
        /// Liefert den Umgebungskontext des Backends zurück. z.B. sandbox
        /// </summary>
        /// <value>Der Umgebungskontext.</value>
        [JsonProperty(PropertyName = "env")]
        public string Environment { get; set; }

        /// <summary>
        /// Liefert die Version des Backends zurück. z.B. v2.1.0
        /// </summary>
        /// <value>Die Version des Backends.</value>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }
    }
}
