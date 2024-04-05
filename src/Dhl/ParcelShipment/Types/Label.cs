using Newtonsoft.Json;

namespace Compori.Shipping.Dhl.ParcelShipment.Types
{
    public class Label
    {
        /// <summary>
        /// Gets or sets the Base64 encoded byte stream.
        /// </summary>
        /// <value>The base64.</value>
        [JsonProperty(PropertyName = "b64")]
        public string Base64 { get; set; }

        /// <summary>
        /// Gets or sets the document in zpl encoding.
        /// </summary>
        /// <value>The ZPL2.</value>
        [JsonProperty(PropertyName = "zpl2")]
        public string Zpl2 { get; set; }

        /// <summary>
        /// Gets or sets the URL reference to download document.
        /// </summary>
        /// <example>www.dhl.de/download/myobscurelink?label.png</example>
        /// <value>The URL.</value>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the file format of the encoded bytes.
        /// enum:["ZPL2", "PDF"]
        /// </summary>
        /// <example>PDF</example>
        /// <value>The file format.</value>
        [JsonProperty(PropertyName = "fileFormat")]
        public string FileFormat { get; set; }

        /// <summary>
        /// Gets or sets the print format used.
        /// Customs documents and cash on delivery documents can only be returned in format A4.
        /// enum:["A4-PT", "A4", "910-300-700", "910-300-700-oZ/oz", "910-300-300", "910-300-300-oz", "910-300-710", "910-300-600/610", "910-300-400/410", "100x70mm"]
        /// </summary>
        /// <value>The print format.</value>
        [JsonProperty(PropertyName = "printFormat")]
        public string PrintFormat { get; set; }
    }
}
