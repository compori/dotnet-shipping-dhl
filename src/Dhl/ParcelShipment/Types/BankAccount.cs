using Newtonsoft.Json;

namespace Compori.Shipping.Dhl.ParcelShipment.Types
{
    public class BankAccount
    {
        /// <summary>
        /// Gets or sets the account holder.
        /// 
        /// value:min:0, max:80
        /// </summary>
        /// <value>The account holder.</value>
        [JsonProperty(PropertyName = "accountHolder", Required = Required.Always)]
        public string AccountHolder { get; set; }

        /// <summary>
        /// Gets or sets the name of the bank.
        /// 
        /// value:min:0, max:80
        /// </summary>
        /// <value>The name of the bank.</value>
        [JsonProperty(PropertyName = "bankName")]
        public string BankName { get; set; }

        /// <summary>
        /// Gets or sets the iban.
        /// </summary>
        /// <value>The iban.</value>
        [JsonProperty(PropertyName = "iban", Required = Required.Always)]
        public string Iban { get; set; }

        /// <summary>
        /// Gets or sets the bic.
        /// </summary>
        /// <value>The bic.</value>
        [JsonProperty(PropertyName = "bic")]
        public string Bic { get; set; }

    }
}
