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

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString()
        {
            var result = !string.IsNullOrWhiteSpace(this.State) ? this.State + ": " : "";

            if (!string.IsNullOrWhiteSpace(this.Message))
            {
                result += this.Message;
            }

            if (!string.IsNullOrWhiteSpace(this.Property))
            {
                result += " (" + this.Property+ ")";
            }
            return !string.IsNullOrEmpty(result) ? result : base.ToString();
        }

    }
}
