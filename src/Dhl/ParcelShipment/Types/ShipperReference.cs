using Newtonsoft.Json;

namespace Compori.Shipping.Dhl.ParcelShipment.Types
{
    /// <summary>
    /// The class contains a reference to the Shipper data configured in GKP(Geschäftskundenportal - Business Costumer Portal).
    /// It can be used instead of a detailed shipper address.
    /// The shipper reference can also be used to print a company logo which is configured in GKP onto the label.
    /// </summary>
    public class ShipperReference : Shipper
    {
        /// <summary>
        /// Gets or sets the shipper reference string to the shipper data configured in GKP(Geschäftskundenportal - Business Costumer Portal).
        /// </summary>
        /// <remarks>
        /// String length: 0 - 50
        /// </remarks>
        /// <example>
        /// <code>
        /// var shipper = new ShipperReference();
        /// shipper.Reference = "ABC123";
        /// </code>
        /// </example>
        /// <value>The shipper reference string.</value>
        [JsonProperty(PropertyName = "shipperRef", Required = Required.Always)]
        public string Reference { get; set; }        
    }
}
