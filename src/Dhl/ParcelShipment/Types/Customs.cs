using Newtonsoft.Json;
using System.Collections.Generic;

namespace Compori.Shipping.Dhl.ParcelShipment.Types
{
    public class Customs
    {
        /// <summary>
        /// Gets or sets the invoice number.
        /// 
        /// value:min:0, max:35
        /// </summary>
        /// <value>The invoice number.</value>
        [JsonProperty(PropertyName = "invoiceNo")]
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// Gets or sets the type of the export.
        /// enum:["OTHER","PRESENT","COMMERCIAL_SAMPLE","DOCUMENT","RETURN_OF_GOODS","COMMERCIAL_GOODS"]
        /// 
        /// This contains the category of goods contained in parcel.
        /// </summary>
        /// <value>The type of the export.</value>
        [JsonProperty(PropertyName = "exportType", Required = Required.Always)]
        public string ExportType { get; set; }

        /// <summary>
        /// Gets or sets the export description.
        /// 
        /// Detailed description for OTHER goods. Mandatory if exporttype is 'OTHER'
        /// value:min:0, max:80
        /// </summary>
        /// <value>The export description.</value>
        [JsonProperty(PropertyName = "exportDescription")]
        public string ExportDescription { get; set; }

        /// <summary>
        /// Gets or sets the shipping conditions.
        /// enum:["DDU","DAP","DDP","DDX","DXV"]
        /// Aka 'Terms of Trade' aka 'Frankatur'. The attribute is exclusively used for the product Europaket (V54EPAK).
        /// DDU is deprecated (use DAP instead).
        /// </summary>
        /// <value>The shipping conditions.</value>
        [JsonProperty(PropertyName = "shippingConditions")]
        public string ShippingConditions { get; set; }

        /// <summary>
        /// Gets or sets the permit number.
        /// 
        /// Permit number. Very rarely needed. Mostly relevant for higher value goods. 
        /// An example use case would be an item made from crocodile leather which requires 
        /// dedicated license / permit identified by that number.
        /// value:min:0, max:30
        /// </summary>
        /// <value>The permit number.</value>
        [JsonProperty(PropertyName = "permitNo")]
        public string PermitNumber { get; set; }

        /// <summary>
        /// Gets or sets the attestation number.
        /// 
        /// Attest or certification identified by this number. Very rarely needed.
        /// An example use case would be a medical shipment referring to an attestation that a certain amount 
        /// of medicine may be imported within e.g. the current quarter of the year.
        /// 
        /// value:min:0, max:30
        /// </summary>
        /// <value>The attestation number.</value>
        [JsonProperty(PropertyName = "attestationNo")]
        public string AttestationNumber { get; set; }

        /// <summary>
        /// Gets or sets a value confirming whether electronic record for export was made.
        /// </summary>
        /// <value><c>true</c> if this instance has electronic export notification; otherwise, <c>false</c>.</value>
        [JsonProperty(PropertyName = "hasElectronicExportNotification")]
        public bool HasElectronicExportNotification { get; set; }

        /// <summary>
        /// Gets or sets the MRN.
        /// 
        /// value:max:18
        /// </summary>
        /// <value>The MRN.</value>
        [JsonProperty(PropertyName = "MRN")]
        public string MRN { get; set; }

        /// <summary>
        /// Gets or sets the office of origin. Optional. Will appear on CN23.
        /// 
        /// value:min:0, max:35
        /// </summary>
        /// <value>The office of origin.</value>
        [JsonProperty(PropertyName = "officeOfOrigin")]
        public string OfficeOfOrigin { get; set; }

        /// <summary>
        /// Gets or sets the postal charges.
        /// </summary>
        /// <value>The postal charges.</value>
        [JsonProperty(PropertyName = "postalCharges", Required = Required.Always)]
        public Amount PostalCharges { get; set; }

        /// <summary>
        /// Gets or sets the shipper customs reference.
        /// 
        /// Optional. The customs reference is used by customs authorities to identify economics operators an/or other persons involved. 
        /// With the given reference, granted authorizations and/or relevant processes in customs clearance an/or taxation can be taken into account. 
        /// Aka Zoll-Nummer or EORI-Number but dependent on destination.
        /// 
        /// value:max:35
        /// </summary>
        /// <value>The shipper customs reference.</value>
        [JsonProperty(PropertyName = "shipperCustomsRef")]
        public string ShipperCustomsReference { get; set; }


        /// <summary>
        /// Gets or sets the consignee customs reference.
        /// 
        /// Optional. The customs reference is used by customs authorities to identify economics operators an/or other persons involved. 
        /// With the given reference, granted authorizations and/or relevant processes in customs clearance an/or taxation can be taken into account. 
        /// Aka Zoll-Nummer or EORI-Number but dependent on destination.
        /// 
        /// value:max:35
        /// </summary>
        /// <value>The consignee customs reference.</value>
        [JsonProperty(PropertyName = "consigneeCustomsRef")]
        public string ConsigneeCustomsRef { get; set; }

        /// <summary>
        /// Gets or sets the items.
        /// 
        /// Commodity types in that package
        /// </summary>
        /// <value>The items.</value>
        [JsonProperty(PropertyName = "items")]
        public List<Item> Items { get; set; }
    }
}
