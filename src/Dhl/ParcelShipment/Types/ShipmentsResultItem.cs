using Newtonsoft.Json;

namespace Compori.Shipping.Dhl.ParcelShipment.Types
{
    public class ShipmentsResultItem
    {
        /// <summary>
        /// Gets or sets the shipment number.
        /// 
        /// value:min:0, max:50
        /// </summary>
        /// <value>The shipment number.</value>
        [JsonProperty(PropertyName = "shipmentNo")]
        public string ShipmentNumber { get; set; }

        /// <summary>
        /// Gets or sets the return shipment number.
        /// 
        /// value:min:0, max:50
        /// </summary>
        /// <value>The return shipment number.</value>
        [JsonProperty(PropertyName = "returnShipmentNo")]
        public string ReturnShipmentNumber { get; set; }

        /// <summary>
        /// Gets or sets the reference number.
        /// 
        /// value:min:6, max:50
        /// </summary>
        /// <value>The reference number.</value>
        [JsonProperty(PropertyName = "shipmentRefNo")]
        public string ReferenceNumber { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// 
        /// General status description for the attached response or response item.
        /// </summary>
        /// <value>The status.</value>
        [JsonProperty(PropertyName = "sstatus")]
        public Status Status { get; set; }

        /// <summary>
        /// Gets or sets the label.
        /// </summary>
        /// <value>The label.</value>
        [JsonProperty(PropertyName = "label")]
        public Label Label { get; set; }

        /// <summary>
        /// Gets or sets the return label.
        /// </summary>
        /// <value>The return label.</value>
        [JsonProperty(PropertyName = "returnLabel")]
        public Label ReturnLabel { get; set; }

        /// <summary>
        /// Gets or sets the customs document.
        /// </summary>
        /// <value>The customs document.</value>
        [JsonProperty(PropertyName = "customsDoc")]
        public Label CustomsDocument { get; set; }

        /// <summary>
        /// Gets or sets the cod label.
        /// </summary>
        /// <value>The cod label.</value>
        [JsonProperty(PropertyName = "codLabel")]
        public Label CodLabel { get; set; }

        /// <summary>
        /// Gets or sets an optional validation messages attached to the shipment.
        /// </summary>
        /// <value>The validation message.</value>
        [JsonProperty(PropertyName = "validationMessages")]
        public ValidationMessage ValidationMessage { get; set; }
    }
}