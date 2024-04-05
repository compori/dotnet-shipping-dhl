using Newtonsoft.Json;

namespace Compori.Shipping.Dhl.ParcelShipment.Types
{
    /// <summary>
    /// Class PostOfficeOBox.
    /// Alternative destination - P.O. Box (Postfach)
    /// Implements the <see cref="Compori.Shipping.Dhl.ParcelShipment.Types.Consignee" />
    /// </summary>
    /// <seealso cref="Compori.Shipping.Dhl.ParcelShipment.Types.Consignee" />
    public class PostOfficeBox : Consignee
    {
        /// <summary>
        /// Gets or sets the name1. value:min:1, max:50
        /// </summary>
        /// <value>The name1.</value>
        [JsonProperty(PropertyName = "name1", Required = Required.Always)]
        public string Name1 { get; set; }

        /// <summary>
        /// Gets or sets the optional, additional line of name information. value:min:1, max:50
        /// </summary>
        /// <value>The name2.</value>
        [JsonProperty(PropertyName = "name2")]
        public string Name2 { get; set; }

        /// <summary>
        /// Gets or sets the optional, additional line of name information. value:min:1, max:50
        /// </summary>
        /// <value>The name3.</value>
        [JsonProperty(PropertyName = "name3")]
        public string Name3 { get; set; }

        /// <summary>
        /// Gets or sets the Number of P.O. Box (Postfach).
        /// </summary>
        /// <value>The Number of P.O. Box (Postfach).</value>
        [JsonProperty(PropertyName = "poBoxID", Required = Required.Always)]
        public long Number { get; set; }

        /// <summary>
        /// Gets or sets the email address of the consignee. value:min:3, max:80
        /// </summary>
        /// <value>The email.</value>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the city of the P.O. Box (Postfach) location. value:min:0, max:80
        /// </summary>
        /// <value>The city.</value>
        [JsonProperty(PropertyName = "city", Required = Required.Always)]
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the country.
        /// enum:["ABW","AFG","AGO","AIA","ALA","ALB","AND","ARE","ARG","ARM","ASM","ATG","AUS","AUT","AZE","BDI","BEL","BEN","BES","BFA","BGD","BGR","BHR","BHS","BIH","BLM","BLR","BLZ","BMU","BOL","BRA","BRB","BRN","BTN","BVT","BWA","CAF","CAN","CCK","CHE","CHL","CHN","CIV","CMR","COD","COG","COK","COL","COM","CPV","CRI","CUB","CUW","CXR","CYM","CYP","CZE","DEU","DJI","DMA","DNK","DOM","DZA","ECU","EGY","ERI","ESP","EST","ETH","FIN","FJI","FLK","FRA","FRO","FSM","GAB","GBR","GEO","GGY","GHA","GIB","GIN","GLP","GMB","GNB","GNQ","GRC","GRD","GRL","GTM","GUF","GUM","GUY","HKG","HMD","HND","HRV","HTI","HUN","IDN","IMN","IND","IRL","IRN","IRQ","ISL","ISR","ITA","JAM","JEY","JOR","JPN","KAZ","KEN","KGZ","KHM","KIR","KNA","KOR","KWT","LAO","LBN","LBR","LBY","LCA","LIE","LKA","LSO","LTU","LUX","LVA","MAC","MAF","MAR","MCO","MDA","MDG","MDV","MEX","MHL","MKD","MLI","MLT","MMR","MNE","MNG","MNP","MOZ","MRT","MSR","MTQ","MUS","MWI","MYS","MYT","NAM","NCL","NER","NFK","NGA","NIC","NIU","NLD","NOR","NPL","NRU","NZL","OMN","PAK","PAN","PCN","PER","PHL","PLW","PNG","POL","PRI","PRK","PRT","PRY","PSE","PYF","QAT","REU","ROU","RUS","RWA","SAU","SDN","SEN","SGP","SHN","SJM","SLB","SLE","SLV","SMR","SOM","SPM","SRB","SSD","STP","SUR","SVK","SVN","SWE","SWZ","SXM","SYC","SYR","TCA","TCD","TGO","THA","TJK","TKL","TKM","TLS","TON","TTO","TUN","TUR","TUV","TWN","TZA","UGA","UKR","URY","USA","UZB","VAT","VCT","VEN","VGB","VIR","VNM","VUT","WLF","WSM","YEM","ZAF","ZMB","ZWE","UNKNOWN"]
        /// A valid country code consisting of three characters according to ISO 3166-1 alpha-3.
        /// </summary>
        /// <value>The country.</value>
        [JsonProperty(PropertyName = "country", Required = Required.Always)]
        public string Country { get; set; }


        /// <summary>
        /// Gets or sets the postal code of the P.O. Box (Postfach) location. value:min:3, max:10
        /// </summary>
        /// <value>The postal code.</value>
        [JsonProperty(PropertyName = "postalCode", Required = Required.Always)]
        public string PostalCode { get; set; }
    }
}
