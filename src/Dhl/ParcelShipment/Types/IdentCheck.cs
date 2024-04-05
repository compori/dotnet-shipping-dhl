using Newtonsoft.Json;

namespace Compori.Shipping.Dhl.ParcelShipment.Types
{
    public class IdentCheck
    {
        /// <summary>
        /// Gets or sets the first name.
        /// value:min:1, max:35
        /// </summary>
        /// <value>The first name.</value>
        [JsonProperty(PropertyName = "firstName", Required = Required.Always)]
        public  string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// value:min:1, max:35
        /// </summary>
        /// <value>The last name.</value>
        [JsonProperty(PropertyName = "lastName", Required = Required.Always)]
        public  string LastName { get; set; }

        /// <summary>
        /// Gets or sets the date of birth.
        /// 
        /// date of birth, used in conjunction with minimumAge and shipping date. Format yyyy-mm-dd is used.
        /// </summary>
        /// <value>The date of birth.</value>
        [JsonProperty(PropertyName = "dateOfBirth")]
        public  string DateOfBirth { get; set; }

        /// <summary>
        /// Gets or sets the minimum age.
        /// 
        /// enum:["A16","A18"]
        /// Checks if recipient will have reached specified age by shipping date.
        /// </summary>
        /// <value>The minimum age.</value>
        [JsonProperty(PropertyName = "minimumAge", Required = Required.Always)]
        public  string MinimumAge { get; set; }
    }
}
