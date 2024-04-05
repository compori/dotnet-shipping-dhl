using RestSharp;
using RestSharp.Authenticators;

namespace Compori.Shipping.Dhl.ParcelShipment
{
    public class RestClientFactory : Common.RestClientFactory<Settings>
    {
        /// <summary>
        /// Creates a Authenticator for the rest client.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <returns>AuthenticatorBase.</returns>
        protected override AuthenticatorBase CreateAuthenticator(Settings settings)
        {
            return new HttpBasicAuthenticator(settings.User, settings.Password);
        }

        /// <summary>
        /// Called when client should be configured. For example with setting default header values.
        /// </summary>
        /// <param name="client">The client.</param>
        /// <param name="settings">The settings.</param>
        protected override void ConfigureClient(RestClient client, Settings settings)
        {
            base.ConfigureClient(client, settings);
            if (!string.IsNullOrEmpty(settings.ApiKey))
            {
                client.AddDefaultHeader("dhl-api-key", settings.ApiKey);
            }
        }
    }
}
