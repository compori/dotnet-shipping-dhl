using Compori.Shipping.Dhl.Common;

namespace Compori.Shipping.Dhl.ParcelShipment
{
    public class Client : Client<Settings>
    {
        public Client(ISettingsFactory<Settings> settingsFactory, RestClientFactory restClientFactory) : base(settingsFactory, restClientFactory)
        {
        }
    }
}
