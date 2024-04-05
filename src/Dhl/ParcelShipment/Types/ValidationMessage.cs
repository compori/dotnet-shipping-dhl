using Newtonsoft.Json;

namespace Compori.Shipping.Dhl.ParcelShipment.Types
{
    public class ValidationMessage
    {
        /// <summary>
        /// Gets or sets the property that is affected by the validation message.
        /// </summary>
        /// <example>dimension.weight</example>
        /// <value>The property.</value>
        [JsonProperty(PropertyName = "property")]
        public string Property { get; set; }

        /// <summary>
        /// Gets or sets the validation message describing the error.
        /// </summary>
        /// <example>The weight is too high</example>
        /// <value>The message.</value>
        [JsonProperty(PropertyName = "validationMessage")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the validation state resulting from the error.
        /// </summary>
        /// <value>The state.</value>
        [JsonProperty(PropertyName = "validationState")]
        public string State { get; set; }

    }
}
