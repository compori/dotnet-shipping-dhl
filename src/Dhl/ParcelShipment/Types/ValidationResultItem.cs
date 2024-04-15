using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;

namespace Compori.Shipping.Dhl.ParcelShipment.Types
{
    public class ValidationResultItem
    {
        /// <summary>
        /// Gets or sets the sequence number.
        /// </summary>
        /// <value>The sequence number.</value>
        [JsonProperty(PropertyName = "sequenceNumber")]
        public long SequenceNumber { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// 
        /// General status description for the attached response or response item.
        /// </summary>
        /// <value>The status.</value>
        [JsonProperty(PropertyName = "sstatus")]
        public Status Status { get; set; }


        /// <summary>
        /// Gets or sets the items. For consistency, response is a single element array.
        /// </summary>
        /// <value>The items.</value>
        [JsonProperty(PropertyName = "validationMessages")]
        public List<ValidationMessage> ValidationMessage { get; set; } = new List<ValidationMessage>();

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

            if (this.ValidationMessage != null)
            {
                foreach (var item in this.ValidationMessage)
                {
                    sb.AppendLine(item.ToString());
                }
            }
            return sb.ToString();
        }
    }
}
