using Newtonsoft.Json;

namespace Compori.Shipping.Dhl.ParcelShipment.Types
{
    public class Item
    {
        /// <summary>
        /// Gets or sets the description.
        /// 
        /// A text that describes the commodity item. 
        /// Only the first 50 characters of the description text is printed on the customs declaration form CN23.
        /// e.g: T-Shirt Boys size 164 yellow
        /// 
        /// value:min:1, max:256
        /// </summary>
        /// <value>The description.</value>
        [JsonProperty(PropertyName = "itemDescription", Required = Required.Always)]
        public string Description { get; set; }


        /// <summary>
        /// Gets or sets the country of origin.
        /// enum:["ABW","AFG","AGO","AIA","ALA","ALB","AND","ARE","ARG","ARM","ASM","ATG","AUS","AUT","AZE","BDI","BEL","BEN","BES","BFA","BGD","BGR","BHR","BHS","BIH","BLM","BLR","BLZ","BMU","BOL","BRA","BRB","BRN","BTN","BVT","BWA","CAF","CAN","CCK","CHE","CHL","CHN","CIV","CMR","COD","COG","COK","COL","COM","CPV","CRI","CUB","CUW","CXR","CYM","CYP","CZE","DEU","DJI","DMA","DNK","DOM","DZA","ECU","EGY","ERI","ESP","EST","ETH","FIN","FJI","FLK","FRA","FRO","FSM","GAB","GBR","GEO","GGY","GHA","GIB","GIN","GLP","GMB","GNB","GNQ","GRC","GRD","GRL","GTM","GUF","GUM","GUY","HKG","HMD","HND","HRV","HTI","HUN","IDN","IMN","IND","IRL","IRN","IRQ","ISL","ISR","ITA","JAM","JEY","JOR","JPN","KAZ","KEN","KGZ","KHM","KIR","KNA","KOR","KWT","LAO","LBN","LBR","LBY","LCA","LIE","LKA","LSO","LTU","LUX","LVA","MAC","MAF","MAR","MCO","MDA","MDG","MDV","MEX","MHL","MKD","MLI","MLT","MMR","MNE","MNG","MNP","MOZ","MRT","MSR","MTQ","MUS","MWI","MYS","MYT","NAM","NCL","NER","NFK","NGA","NIC","NIU","NLD","NOR","NPL","NRU","NZL","OMN","PAK","PAN","PCN","PER","PHL","PLW","PNG","POL","PRI","PRK","PRT","PRY","PSE","PYF","QAT","REU","ROU","RUS","RWA","SAU","SDN","SEN","SGP","SHN","SJM","SLB","SLE","SLV","SMR","SOM","SPM","SRB","SSD","STP","SUR","SVK","SVN","SWE","SWZ","SXM","SYC","SYR","TCA","TCD","TGO","THA","TJK","TKL","TKM","TLS","TON","TTO","TUN","TUR","TUV","TWN","TZA","UGA","UKR","URY","USA","UZB","VAT","VCT","VEN","VGB","VIR","VNM","VUT","WLF","WSM","YEM","ZAF","ZMB","ZWE","UNKNOWN"]
        /// A valid country code consisting of three characters according to ISO 3166-1 alpha-3.
        /// </summary>
        /// <value>The country of origin.</value>
        [JsonProperty(PropertyName = "countryOfOrigin")]
        public string countryOfOrigin { get; set; }

        /// <summary>
        /// Gets or sets the customs tariff number.
        /// 
        /// Harmonized System Code aka Customs tariff number.
        /// value:min:6, max:11
        /// </summary>
        /// <value>The customs tariff number.</value>
        [JsonProperty(PropertyName = "hsCode")]
        public string CustomsTariffNumber { get; set; }

        /// <summary>
        /// Gets or sets the quantity.
        /// 
        /// How many items of that type are in the package
        /// </summary>
        /// <value>The quantity.</value>
        [JsonProperty(PropertyName = "packagedQuantity", Required = Required.Always)]
        public long Quantity { get; set; } = 1;

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        [JsonProperty(PropertyName = "itemValue", Required = Required.Always)]
        public Amount Value { get; set; }

        /// <summary>
        /// Gets or sets the weight.
        /// </summary>
        /// <value>The weight.</value>
        [JsonProperty(PropertyName = "itemWeight", Required = Required.Always)]
        public Amount Weight { get; set; }
    }
}
