using Compori.Shipping.Dhl.Common;
using Compori.Shipping.Dhl.ParcelShipment.Types;
using RestSharp;

namespace Compori.Shipping.Dhl.ParcelShipment
{
    public class ValidationException : ResponseException
    {
        /// <summary>
        /// Liefert die Validierungsmeldung zurück.
        /// </summary>
        /// <value>Der Validierungsmeldung.</value>
        public ValidationResult Result { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationException"/> class.
        /// </summary>
        /// <param name="response">The response.</param>
        /// <param name="result">The result.</param>
        public ValidationException(RestResponse response, ValidationResult result) : base(response, result.ToString())
        {
            this.Result = result;
        }
    }
}
