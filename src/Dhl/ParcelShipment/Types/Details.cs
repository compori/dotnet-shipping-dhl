using Newtonsoft.Json;

namespace Compori.Shipping.Dhl.ParcelShipment.Types
{
    public class Details
    {
        /// <summary>
        /// Gets or sets the dimension.
        /// 
        /// Physical dimensions (aka 'Gurtmass') of the parcel. If you provide the dimension information, 
        /// all attributes need to be provided. You cannot provide just the height, for example. 
        /// If you provide length, width, and height in millimeters, they will be rounded to full cm.
        /// </summary>
        /// <value>The dimension.</value>
        [JsonProperty(PropertyName = "dim", Required = Required.Always)]
        public Dimension Dimension { get; set; }

        /// <summary>
        /// Gets or sets the weight.
        /// 
        /// Weight of item or shipment. Both uom and value are required.
        /// </summary>
        /// <value>The weight.</value>
        [JsonProperty(PropertyName = "weight", Required = Required.Always)]
        public Weight Weight { get; set; }
    }
}
