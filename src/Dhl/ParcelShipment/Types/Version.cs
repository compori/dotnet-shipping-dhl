using Newtonsoft.Json;

namespace Compori.Shipping.Dhl.ParcelShipment.Types
{
    public class Version
    {
        /// <summary>
        /// Liefert die API Versionsinformationen zurück.
        /// </summary>
        /// <value>Die API Versionsinformationen.</value>
        [JsonProperty(PropertyName = "amp")]
        public Amp Amp { get; set; }

        /// <summary>
        /// Liefert die Backend Versionsinformationen zurück.
        /// </summary>
        /// <value>Die Backend Versionsinformationen.</value>
        [JsonProperty(PropertyName = "backend")]
        public Backend Backend { get; set; }
    }
}
