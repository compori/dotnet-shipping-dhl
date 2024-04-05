using Newtonsoft.Json;

namespace Compori.Shipping.Dhl.ParcelShipment.Types
{
    /// <summary>
    /// Class Dimension.
    /// 
    /// Physical dimensions (aka 'Gurtmass') of the parcel. 
    /// If you provide the dimension information, all attributes need to be provided.
    /// You cannot provide just the height, for example. 
    /// If you provide length, width, and height in millimeters, they will be rounded to full cm.
    /// </summary>
    public class Dimension
    {
        /// <summary>
        /// Gets or sets the unit.
        /// enum:["cm","mm"]
        /// Unit of metric, applies to all dimensions contained.
        /// </summary>
        /// <value>The unit.</value>
        [JsonProperty(PropertyName = "uom", Required = Required.Always)]
        public string Unit { get; set; } = "cm";

        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        /// <value>The height.</value>
        [JsonProperty(PropertyName = "height", Required = Required.Always)]
        public long Height { get; set; }

        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        /// <value>The width.</value>
        [JsonProperty(PropertyName = "width", Required = Required.Always)]
        public long Width { get; set; }

        /// <summary>
        /// Gets or sets the length.
        /// </summary>
        /// <value>The length.</value>
        [JsonProperty(PropertyName = "length", Required = Required.Always)]
        public long Length { get; set; }
    }
}
