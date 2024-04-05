using Newtonsoft.Json;

namespace Compori.Shipping.Dhl.ParcelShipment.Types
{
    public class CashOnDelivery
    {
        /// <summary>
        /// Gets or sets the amount. Currency and numeric value.
        /// </summary>
        /// <value>The amount.</value>
        [JsonProperty(PropertyName = "amount", Required = Required.Always)]
        public Amount Amount { get; set; }

        /// <summary>
        /// Gets or sets the bank account data used for CoD (Cash on Delivery).
        /// </summary>
        /// <value>The bank account.</value>
        [JsonProperty(PropertyName = "bankAccount", Required = Required.Always)]
        public BankAccount BankAccount { get; set; }

        /// <summary>
        /// Gets or sets the account reference.
        /// 
        /// Reference to bank account details. 
        /// Account references are maintained in customer settings in Post & DHL business customer portal under 
        /// Ship -> Settings -> Cash on delivery. 
        /// Please note, that the default account reference is used if the provided account 
        /// reference does not exist in your customer settings!
        /// 
        /// value:min:0, max:35
        /// </summary>
        /// <value>The account reference.</value>
        [JsonProperty(PropertyName = "accountReference")]
        public string AccountReference { get; set; }

        /// <summary>
        /// Gets or sets the transfer note1.
        /// 
        /// value:min:0, max:35
        /// </summary>
        /// <value>The transfer note1.</value>
        [JsonProperty(PropertyName = "transferNote1")]
        public string TransferNote1 { get; set; }

        /// <summary>
        /// Gets or sets the transfer note2.
        /// 
        /// value:min:0, max:35
        /// </summary>
        /// <value>The transfer note2.</value>
        [JsonProperty(PropertyName = "transferNote2")]
        public string TransferNote2 { get; set; }
    }
}
