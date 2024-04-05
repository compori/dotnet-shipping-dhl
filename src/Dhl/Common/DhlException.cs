using System;

namespace Compori.Shipping.Dhl.Common
{
    /// <summary>
    /// Class ShipcloudException.
    /// Implements the <see cref="Exception" />
    /// </summary>
    /// <seealso cref="Exception" />
    public class DhlException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DhlException"/> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public DhlException(string message) : base(message)
        {
        }
    }
}
