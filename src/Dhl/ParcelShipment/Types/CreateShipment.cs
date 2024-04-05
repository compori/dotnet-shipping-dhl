using Newtonsoft.Json;

namespace Compori.Shipping.Dhl.ParcelShipment.Types
{
    public class CreateShipment
    {
        /// <summary>
        /// Liefert oder setzt die Produktkennung: z.B. V01PAK
        /// <list type="bullet">
        /// <item>V01PAK: DHL PAKET</item>
        /// <item>V53WPAK: DHL PAKET International</item>
        /// <item>V54EPAK: DHL Europaket</item>
        /// <item>V62WP: Warenpost</item>
        /// <item>V66WPI: Warenpost International</item>
        /// </list>
        /// </summary>
        /// <value>Die Produktkennung.</value>
        [JsonProperty(PropertyName = "product")]
        public string Product { get; set; }

        /// <summary>
        /// Gets or sets the billing number.
        /// 14 digit long number that identifies the contract the shipment is booked on.
        /// Please note that in rare cases the last to characters can be letters.
        /// igit 11 and digit 12 must correspondent to the number of the product,
        /// e.g. 333333333301tt can only be used for the product V01PAK (DHL Paket).
        /// 33333333330101 or 333333333362aa
        /// </summary>
        /// <value>The billing number.</value>
        [JsonProperty(PropertyName = "billingNumber")]
        public string BillingNumber { get; set; }

        /// <summary>
        /// A reference number that the user can assign for better association purposes.
        /// It appears on shipment labels.To use the reference number for tracking purposes, 
        /// it should be at least 8 characters long and unique. value:min:8, max:35
        /// </summary>
        /// <value>The reference number.</value>
        [JsonProperty(PropertyName = "refNo")]
        public string ReferenceNumber { get; set; }

        /// <summary>
        /// Gets or sets the cost center.
        /// Textfield that appears on the shipment label. It cannot be used to search for the shipment.
        /// </summary>
        /// <value>The cost center.</value>
        [JsonProperty(PropertyName = "costCenter")]
        public string CostCenter { get; set; }

        /// <summary>
        /// Gets or sets the creation software.
        /// Is only to be indicated by DHL partners.
        /// </summary>
        /// <value>The creation software.</value>
        [JsonProperty(PropertyName = "creationSoftware")]
        public string CreationSoftware { get; set; }

        /// <summary>
        /// Gets or sets the creation software.
        /// Date the shipment is transferred to DHL.
        /// The shipment date can be the current date or a date up to a few days in the future. 
        /// It must not be in the past. 
        /// Iso format required: yyyy-mm-dd.
        /// On the shipment date the shipment will be automatically closed at your end of day closing time.
        /// </summary>
        /// <value>The creation software.</value>
        [JsonProperty(PropertyName = "shipDate")]
        public string ShipDate { get; set; }

        /// <summary>
        /// Gets or sets the shipper.
        /// 
        /// Shipper information, including contact information and address. Alternatively, a predefined shipper reference can be used.
        /// </summary>
        /// <value>The shipper.</value>
        [JsonProperty(PropertyName = "shipper")]
        public Shipper Shipper { get; set; }

        /// <summary>
        /// Gets or sets the consignee.
        /// 
        /// Consignee address information. Either a doorstep address (contact address) including contact information or a droppoint address. 
        /// One of packstation (parcel locker), or post office (postfiliale/retail shop).
        /// </summary>
        /// <value>The consignee.</value>
        [JsonProperty(PropertyName = "consignee")]
        public Consignee Consignee { get; set; }

        /// <summary>
        /// Gets or sets the details.
        /// 
        /// Details for the shipment, such as dimensions, content
        /// </summary>
        /// <value>The details.</value>
        [JsonProperty(PropertyName = "details")]
        public Details Details { get; set; }

        /// <summary>
        /// Gets or sets the services.
        /// 
        /// Value added services. Please note that services are specific to products and geographies
        /// and/or may require individual setup and billing numbers. 
        /// Please test and contact your account representative in case of questions.
        /// </summary>
        /// <value>The services.</value>
        [JsonProperty(PropertyName = "services")]
        public Services Services { get; set; }

        /// <summary>
        /// Gets or sets the customs.
        /// 
        /// For international shipments, this section contains information necessary for customs about the exported goods. 
        /// ExportDocument can contain one or more positions as child element.
        /// This data is also transferred as electronic declaration to customs. 
        /// The custom details are mandatory depending on whether the parcel will go to a country outside the European Customs Union. 
        /// For DHL Parcel International (V53WPAK) CN23 will returned as a separate document, 
        /// while for Warenpost International the customs information will be printed onto the shipment label (CN22).
        /// </summary>
        /// <value>The customs.</value>
        [JsonProperty(PropertyName = "customs")]
        public Customs Customs { get; set; }
    }
}
