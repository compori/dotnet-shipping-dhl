using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;

namespace Compori.Shipping.Dhl.ParcelShipment.Types
{
    public class ValidationResult
    {
        /// <summary>
        /// Gets or sets the general status description for the attached response or response item.
        /// </summary>
        /// <value>The status.</value>
        [JsonProperty(PropertyName = "status")]
        public Status Status { get; set; }

        /// <summary>
        /// Gets or sets the items. For consistency, response is a single element array.
        /// </summary>
        /// <value>The items.</value>
        [JsonProperty(PropertyName = "items")]
        public List<ValidationResultItem> Items { get; set; }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();

            if (!string.IsNullOrWhiteSpace(this.Status?.Title))
            {
                sb.AppendLine(this.Status.Title);
            }

            if (!string.IsNullOrWhiteSpace(this.Status?.Detail))
            {
                sb.AppendLine(this.Status.Detail);
            }

            if (this.Items != null)
            {
                foreach (var item in this.Items)
                {
                    sb.AppendLine(item.ToString());
                }
            }
            return sb.ToString();
        }
    }
}
