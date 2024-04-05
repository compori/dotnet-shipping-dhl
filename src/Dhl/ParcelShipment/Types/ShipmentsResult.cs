using Newtonsoft.Json;
using System.Collections.Generic;

namespace Compori.Shipping.Dhl.ParcelShipment.Types
{
    public class ShipmentsResult
    {
        /// <summary>
        /// Gets or sets the general status description for the attached response or response item.
        /// </summary>
        /// <value>The status.</value>
        [JsonProperty(PropertyName = "status")]
        public Status Status { get; set; }

        /// <summary>
        /// Gets or sets the items. For consistency, response is a single element array.
        /// </summary>
        /// <value>The items.</value>
        [JsonProperty(PropertyName = "items")]
        public List<ShipmentsResultItem> Items { get; set; }  
    }
}
