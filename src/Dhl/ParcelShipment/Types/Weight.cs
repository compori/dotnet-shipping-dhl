using Newtonsoft.Json;

namespace Compori.Shipping.Dhl.ParcelShipment.Types
{
    public class Weight
    {
        /// <summary>
        /// Gets or sets the unit. metric unit for weight.
        /// enum:["g","kg"]
        /// </summary>
        /// <value>The unit.</value>
        [JsonProperty(PropertyName = "uom", Required = Required.Always)]
        public string Unit { get; set; } = "g";

        /// <summary>
        /// Gets or sets the value.
        /// value:min:0, max:31500
        /// </summary>
        /// <value>The value.</value>
        [JsonProperty(PropertyName = "value", Required = Required.Always)]
        public long Value { get; set; } 
    }
}
