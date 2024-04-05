using Newtonsoft.Json;

namespace Compori.Shipping.Dhl.ParcelShipment.Types
{
    public class ReturnAddress
    {
        /// <summary>
        /// Gets or sets the name1. 
        /// Line 1 of name information
        /// value:min:1, max:50
        /// </summary>
        /// <value>The name1.</value>
        [JsonProperty(PropertyName = "name1", Required = Required.Always)]
        public string Name1 { get; set; }

        /// <summary>
        /// Gets or sets the optional, additional line of name information
        /// value:min:1, max:50
        /// </summary>
        /// <value>The name2.</value>
        [JsonProperty(PropertyName = "name2")]
        public string Name2 { get; set; }

        /// <summary>
        /// Gets or sets the optional, additional line of name information.
        /// value:min:1, max:50
        /// </summary>
        /// <value>The name3.</value>
        [JsonProperty(PropertyName = "name3")]
        public string Name3 { get; set; }

        /// <summary>
        /// Gets or sets the optional, additional line of address. It's only usable for a few countries, e.g. Belgium. 
        /// It is positioned below name3 on the label.
        /// value:min:1, max:35
        /// </summary>
        /// <value>The dispatching information.</value>
        [JsonProperty(PropertyName = "dispatchingInformation")]
        public string DispatchingInformation { get; set; }

        /// <summary>
        /// Gets or sets the line 1 of the street address. This is just the street name. Can also include house number.
        /// value:min:1, max:50
        /// </summary>
        /// <value>The address street.</value>
        [JsonProperty(PropertyName = "addressStreet", Required = Required.Always)]
        public string AddressStreet { get; set; }

        /// <summary>
        /// Gets or sets the line 1 of the street address. This is just the house number. Can be added to street name instead.
        /// 
        /// value:min:1, max:10
        /// </summary>
        /// <value>The address house.</value>
        [JsonProperty(PropertyName = "addressHouse")]
        public string AddressHouse { get; set; }

        /// <summary>
        /// Gets or sets the additional information that is positioned either behind or below addressStreet on the label.
        /// If it is printed and where exactly depends on the country.
        /// 
        /// value:min:1, max:60
        /// </summary>
        /// <value>The additional address information1.</value>
        [JsonProperty(PropertyName = "additionalAddressInformation1")]
        public string AdditionalAddressInformation1 { get; set; }

        /// <summary>
        /// Gets or sets the additional information that is positioned either behind or below addressStreet on the label. 
        /// If it is printed and where exactly depends on the country.
        /// 
        /// value:min:1, max:60
        /// </summary>
        /// <value>The additional address information2.</value>
        [JsonProperty(PropertyName = "additionalAddressInformation2")]
        public string AdditionalAddressInformation2 { get; set; }

        /// <summary>
        /// Gets or sets the postal code.
        /// 
        /// Mandatory for all countries but Ireland that use a postal code system.
        /// value:min:3, max:10
        /// </summary>
        /// <value>The postal code.</value>
        [JsonProperty(PropertyName = "postalCode")]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or sets the city.
        /// 
        /// value:min:1, max:40
        /// </summary>
        /// <value>The city.</value>
        [JsonProperty(PropertyName = "city", Required = Required.Always)]
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the state.
        /// 
        /// State, province or territory. For the USA please use the official regional ISO-Codes, e.g. US-AL.
        /// value:min:1, max:20
        /// </summary>
        /// <value>The state.</value>
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets the country.
        /// enum:["ABW","AFG","AGO","AIA","ALA","ALB","AND","ARE","ARG","ARM","ASM","ATG","AUS","AUT","AZE","BDI","BEL","BEN","BES","BFA","BGD","BGR","BHR","BHS","BIH","BLM","BLR","BLZ","BMU","BOL","BRA","BRB","BRN","BTN","BVT","BWA","CAF","CAN","CCK","CHE","CHL","CHN","CIV","CMR","COD","COG","COK","COL","COM","CPV","CRI","CUB","CUW","CXR","CYM","CYP","CZE","DEU","DJI","DMA","DNK","DOM","DZA","ECU","EGY","ERI","ESP","EST","ETH","FIN","FJI","FLK","FRA","FRO","FSM","GAB","GBR","GEO","GGY","GHA","GIB","GIN","GLP","GMB","GNB","GNQ","GRC","GRD","GRL","GTM","GUF","GUM","GUY","HKG","HMD","HND","HRV","HTI","HUN","IDN","IMN","IND","IRL","IRN","IRQ","ISL","ISR","ITA","JAM","JEY","JOR","JPN","KAZ","KEN","KGZ","KHM","KIR","KNA","KOR","KWT","LAO","LBN","LBR","LBY","LCA","LIE","LKA","LSO","LTU","LUX","LVA","MAC","MAF","MAR","MCO","MDA","MDG","MDV","MEX","MHL","MKD","MLI","MLT","MMR","MNE","MNG","MNP","MOZ","MRT","MSR","MTQ","MUS","MWI","MYS","MYT","NAM","NCL","NER","NFK","NGA","NIC","NIU","NLD","NOR","NPL","NRU","NZL","OMN","PAK","PAN","PCN","PER","PHL","PLW","PNG","POL","PRI","PRK","PRT","PRY","PSE","PYF","QAT","REU","ROU","RUS","RWA","SAU","SDN","SEN","SGP","SHN","SJM","SLB","SLE","SLV","SMR","SOM","SPM","SRB","SSD","STP","SUR","SVK","SVN","SWE","SWZ","SXM","SYC","SYR","TCA","TCD","TGO","THA","TJK","TKL","TKM","TLS","TON","TTO","TUN","TUR","TUV","TWN","TZA","UGA","UKR","URY","USA","UZB","VAT","VCT","VEN","VGB","VIR","VNM","VUT","WLF","WSM","YEM","ZAF","ZMB","ZWE","UNKNOWN"]
        /// A valid country code consisting of three characters according to ISO 3166-1 alpha-3.
        /// </summary>
        /// <value>The country.</value>
        [JsonProperty(PropertyName = "country", Required = Required.Always)]
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the optional contact name. (this is not the primary name printed on label)
        /// 
        /// value:min:3, max:80
        /// </summary>
        /// <value>The name of the contact.</value>
        [JsonProperty(PropertyName = "contactName")]
        public string ContactName { get; set; }

        /// <summary>
        /// Gets or sets the phone.
        /// 
        /// Please note that, in accordance with Art. 4 No. 11 GDPR, you must obtain the
        /// recipient's consent to forward their phone number to Deutsche Post DHL Group.
        /// For shipments within Germany, the phone number cannot be transmitted. In some countries
        /// the provision of a telephone number and/or e-mail address is mandatory for a delivery to a droppoint. 
        /// If your recipient has objected to the disclosure of their telephone number and/or e-mail address, 
        /// the shipment can only be delivered in these countries using the service Premium.
        /// 
        /// value:min:1, max:20
        /// </summary>
        /// <value>The phone.</value>
        [JsonProperty(PropertyName = "phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// 
        /// Please note that, in accordance with Art. 4 No. 11 GDPR, you must obtain the recipient's consent to
        /// forward their e-mail address to Deutsche Post DHL Group. For shipments within Germany, the e-mail 
        /// address is used to send a DHL Parcel Notification to the recipient. The e-mail address is not mandatory 
        /// for shipments within Germany. In some countries the provision of a telephone number and/or e-mail address 
        /// is mandatory for a delivery to a droppoint. If your recipient has objected to the disclosure of their 
        /// telephone number and/or e-mail address, the shipment can only be delivered in these countries using the service Premium.
        /// value:min:3, max:80
        /// </summary>
        /// <value>The email.</value>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }
    }
}
