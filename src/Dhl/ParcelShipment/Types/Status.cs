using Newtonsoft.Json;

namespace Compori.Shipping.Dhl.ParcelShipment.Types
{
    public class Status
    {
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <example>
        /// ok
        /// </example>
        /// <value>The title.</value>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the status code.
        /// 
        /// The status code of the response.Usually, but not necessarliy the HTTP status code.
        /// </summary>
        /// <example>
        /// 200
        /// </example>
        /// <value>The status code.</value>
        [JsonProperty(PropertyName = "statusCode")]
        public long Code { get; set; }

        /// <summary>
        /// Gets or sets the URI reference that identifies the specific occurrence of the problem.
        /// </summary>
        /// <value>The instance.</value>
        [JsonProperty(PropertyName = "instance")]
        public string Instance { get; set; }

        /// <summary>
        /// Gets or sets the detail.
        /// </summary>
        /// <example>
        /// The Webservice call ran successfully.
        /// </example>
        /// <value>The detail.</value>
        [JsonProperty(PropertyName = "detail")]
        public string Detail { get; set; }
    }
}
