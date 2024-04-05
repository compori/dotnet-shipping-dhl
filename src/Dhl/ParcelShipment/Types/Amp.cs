using Newtonsoft.Json;

namespace Compori.Shipping.Dhl.ParcelShipment.Types
{
    public class Amp
    {
        /// <summary>
        /// Liefert den Namen der API zurück. z.B. pp-parcel-shipping-native
        /// </summary>
        /// <value>Der Namen der API.</value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Liefert den Umgebungskontext der API zurück. z.B. sandbox
        /// </summary>
        /// <value>Der Umgebungskontext.</value>
        [JsonProperty(PropertyName = "env")]
        public string Environment { get; set; }

        /// <summary>
        /// Liefert die Version der API zurück. z.B. v2.0.4
        /// </summary>
        /// <value>Die Version der API.</value>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        /// <summary>
        /// Liefert die Revision der API zurück. z.B. 22
        /// </summary>
        /// <value>Die Revision der API.</value>
        [JsonProperty(PropertyName = "rev")]
        public string Revision { get; set; }
    }
}
