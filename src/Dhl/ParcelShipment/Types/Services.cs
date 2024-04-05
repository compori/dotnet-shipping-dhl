using Newtonsoft.Json;

namespace Compori.Shipping.Dhl.ParcelShipment.Types
{
    public class Services
    {
        /// <summary>
        /// Gets or sets the preferred neighbour.
        /// Preferred neighbour. Can be specified as text.
        /// eg. Please ring at Meier next door
        /// value:min:0, max:100
        /// </summary>
        /// <value>The preferred neighbour.</value>
        [JsonProperty(PropertyName = "preferredNeighbour")]
        public string PreferredNeighbour { get; set; }


        /// <summary>
        /// Gets or sets the preferred location.
        /// 
        /// Preferred location. Can be specified as text.
        /// eg. Please leave in carport
        /// value:min:0, max:100
        /// </summary>
        /// <value>The preferred location.</value>
        [JsonProperty(PropertyName = "preferredLocation")]
        public string PreferredLocation { get; set; }

        /// <summary>
        /// Gets or sets the visual check of age.
        /// 
        /// enum:["A16","A18"]
        /// if used it will trigger checking the age of recipient
        /// </summary>
        /// <value>The visual check of age.</value>
        [JsonProperty(PropertyName = "visualCheckOfAge")]
        public string VisualCheckOfAge { get; set; }


        /// <summary>
        /// Gets or sets a value indicating whether [named person only].
        /// Delivery can only be signed for by yourself personally.
        /// </summary>
        /// <value><c>true</c> if [named person only]; otherwise, <c>false</c>.</value>
        [JsonProperty(PropertyName = "namedPersonOnly")]
        public bool NamedPersonOnly { get; set; }

        /// <summary>
        /// Gets or sets the ident check.
        /// 
        /// Check the identity of the recipient via name (firstname, lastname), date of birth or age. 
        /// This uses firstName and lastName as separate attributes since for identity check an 
        /// automatic split of a one-line name is not considered reliable enough.
        /// </summary>
        /// <value>The ident check.</value>
        [JsonProperty(PropertyName = "identCheck")]
        public IdentCheck IdentCheck { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether delivery must be signed for by the recipient and not by DHL staff
        /// </summary>
        /// <value><c>true</c> if [signed for by recipient]; otherwise, <c>false</c>.</value>
        [JsonProperty(PropertyName = "signedForByRecipient")]
        public bool SignedForByRecipient { get; set; }

        /// <summary>
        /// Gets or sets the endorsement.
        /// 
        /// Instructions and endorsement how to treat international undeliverable shipment. 
        /// By default, shipments are returned if undeliverable. 
        /// There are country specific rules whether the shipment is returned immediately or after a grace period.
        /// enum:["RETURN","ABANDON"]
        /// </summary>
        /// <value>The endorsement.</value>
        [JsonProperty(PropertyName = "endorsement")]
        public string Endorsement { get; set; }

        /// <summary>
        /// Gets or sets the preferred day.
        /// 
        /// Preferred day of delivery in format YYYY-MM-DD. 
        /// Shipper can request a preferred day of delivery. 
        /// The preferred day should be between 2 and 6 working days after handover to DHL.
        /// </summary>
        /// <value>The preferred day.</value>
        [JsonProperty(PropertyName = "preferredDay")]
        public string PreferredDay { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether delivery can only be signed for by yourself personally or by members of your household.
        /// </summary>
        /// <value><c>true</c> if [no neighbour delivery]; otherwise, <c>false</c>.</value>
        [JsonProperty(PropertyName = "noNeighbourDelivery")]
        public bool NoNeighbourDelivery { get; set; }

        /// <summary>
        /// Gets or sets the additional insurance. Currency and numeric value.
        /// </summary>
        /// <value>The additional insurance.</value>
        [JsonProperty(PropertyName = "additionalInsurance")]
        public Amount AdditionalInsurance { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Sperrgut. Leaving this out is same as setting to false. 
        /// </summary>
        /// <value><c>true</c> if [bulky goods]; otherwise, <c>false</c>.</value>
        [JsonProperty(PropertyName = "bulkyGoods")]
        public bool BulkyGoods { get; set; }

        /// <summary>
        /// Gets or sets the cash on delivery.
        /// 
        /// Cash on delivery (Nachnahme). Currency must be Euro. 
        /// Either bank account information or account reference (from customer profile) must be provided.
        /// Transfernote1 + 2 are references transmitted during bank transfer. 
        /// Providing account information explicitly requires elevated privileges.
        /// </summary>
        /// <value>The cash on delivery.</value>
        [JsonProperty(PropertyName = "cashOnDelivery")]
        public CashOnDelivery CashOnDelivery { get; set; }

        /// <summary>
        /// Gets or sets the special instructions for delivery. 2 character code, possible values agreed in contract.
        /// 
        /// eg. ZZ
        /// </summary>
        /// <value>The individual sender requirement.</value>
        [JsonProperty(PropertyName = "individualSenderRequirement")]
        public string IndividualSenderRequirement { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Services"/> is premium.
        /// Choice of premium vs economy parcel. 
        /// Availability is country dependent and may be manipulated by DHL if choice is not available. 
        /// Please review the label.
        /// </summary>
        /// <value><c>true</c> if premium; otherwise, <c>false</c>.</value>
        [JsonProperty(PropertyName = "premium")]
        public bool Premium { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [closest drop point].
        /// Closest Droppoint Delivery to the droppoint closest to the address of the recipient of the shipment.
        /// For this kind of delivery either the phone number and/or the e-mail address of the receiver is mandatory.
        /// For shipments using DHL Paket International it is recommended that you choose one of the three delivery types:
        /// Economy, Premium, CDP. Otherwise, the current default for the receiver country will be picked.
        /// </summary>
        /// <value><c>true</c> if [closest drop point]; otherwise, <c>false</c>.</value>
        [JsonProperty(PropertyName = "closestDropPoint")]
        public bool ClosestDropPoint { get; set; }


        /// <summary>
        /// Gets or sets the parcel outlet routing.
        /// Undeliverable domestic shipment can be forwarded and held at retail. Notification to email (fallback: consignee email) will be used.
        /// </summary>
        /// <value>The parcel outlet routing.</value>
        [JsonProperty(PropertyName = "parcelOutletRouting")]
        public string ParcelOutletRouting { get; set; }

        /// <summary>
        /// Gets or sets the DHL retoure.
        /// 
        /// Requests return label (aka 'retoure') to be provided. 
        /// Also requires returnAddress and return billing number. 
        /// Neither weight nor dimension need to be specified for the retoure (flat rate service).
        /// </summary>
        /// <value>The DHL retoure.</value>
        [JsonProperty(PropertyName = "dhlRetoure")]
        public DhlRetoure DhlRetoure { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether all import duties are paid by the shipper.
        /// </summary>
        /// <value><c>true</c> if [postal delivery duty paid]; otherwise, <c>false</c>.</value>
        [JsonProperty(PropertyName = "postalDeliveryDutyPaid")]
        public bool PostalDeliveryDutyPaid { get; set; }
    }
}
