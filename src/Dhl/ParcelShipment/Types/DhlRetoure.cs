using Newtonsoft.Json;

namespace Compori.Shipping.Dhl.ParcelShipment.Types
{
    public class DhlRetoure
    {
        /// <summary>
        /// Gets or sets the billing number.
        /// </summary>
        /// <value>The billing number.</value>
        [JsonProperty(PropertyName = "billingNumber", Required = Required.Always)]
        public string BillingNumber { get; set; }

        /// <summary>
        /// Gets or sets the reference number.
        /// </summary>
        /// <value>The reference number.</value>
        [JsonProperty(PropertyName = "refNo")]
        public string ReferenceNumber { get; set; }

        /// <summary>
        /// Gets or sets the return address.
        /// 
        /// Combines name, address, contact information. 
        /// The recommended way is to use the mandatory attribute addressStreet and submit the streetname and housenumber together 
        /// alternatively addressHouse + addressStreet can be used. 
        /// For many international addresses there is no house number,
        /// please do not set a period or any other sign to indicate that the address does not have a housenumber.
        /// </summary>
        /// <value>The return address.</value>
        [JsonProperty(PropertyName = "returnAddress")]
        public ReturnAddress ReturnAddress { get; set; }    
    }
}
