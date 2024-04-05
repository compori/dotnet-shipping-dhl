using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Serializers.NewtonsoftJson;
using System;
using System.Net;

namespace Compori.Shipping.Dhl.Common
{
    public class RestClientFactory<TSettings> : IRestClientFactory<TSettings> where TSettings : Settings
    {
        /// <summary>
        /// Der Logger
        /// </summary>
        private static readonly NLog.Logger Log = NLog.LogManager.GetLogger(typeof(RestClientFactory<TSettings>).FullName);

        /// <summary>
        /// Wurde die das Security Protocol bereits gesetzt?
        /// </summary>
        private bool isSecurityProtocol;

        /// <summary>
        /// Initializes a new instance of the <see cref="RestClientFactory"/> class.
        /// </summary>
        public RestClientFactory()
        {
            isSecurityProtocol = false;
        }

        /// <summary>
        /// Liefert das aktuelle Securityprotocol zurück.
        /// </summary>
        /// <value>Das aktuelle Securityprotocol.</value>
        public SecurityProtocolType SecurityProtocol => ServicePointManager.SecurityProtocol;

        /// <summary>
        /// Setzt das Security Protocol des ServicePointManager.
        /// </summary>
        /// <param name="settings">Die Einstellungen.</param>
        public void SetSecurityProtocol(TSettings settings, bool force = false)
        {
            Guard.AssertArgumentIsNotNull(settings, nameof(settings));

            if (isSecurityProtocol && !force)
            {
                return;
            }

            // Vom System konfigurierten Wert nehmen
            ServicePointManager.SecurityProtocol = SecurityProtocolType.SystemDefault;

            // Aktivieren
            ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12;
            Log.Trace("Enable SecurityProtocolType.Tls12");

            if (settings.EnableTls13)
            {
                ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls13;
                Log.Trace("Enable SecurityProtocolType.Tls13");
            }

            // Erzwingen
            if (settings.ForceTls13)
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls13;
                Log.Trace("Force SecurityProtocolType.Tls13");
            }

            isSecurityProtocol = true;
        }

        /// <summary>
        /// Creates a Authenticator for the rest client.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <returns>AuthenticatorBase.</returns>
        protected virtual AuthenticatorBase CreateAuthenticator(TSettings settings)
        {
            return null;
        }

        /// <summary>
        /// Called when client should be configured. For example with setting default header values.
        /// </summary>
        /// <param name="client">The client.</param>
        /// <param name="settings">The settings.</param>
        protected virtual void ConfigureClient(RestClient client, TSettings settings)
        {
            if (!string.IsNullOrWhiteSpace(settings.AcceptLanguage))
            {
                client.AddDefaultHeader("Accept-Language", settings.AcceptLanguage);
            }
        }

        /// <summary>
        /// Erstellt einen RestClient mit den angegebenen Einstellungen.
        /// </summary>
        /// <param name="settings">Die Einstellungen.</param>
        /// <returns>RestClient.</returns>
        public RestClient Create(TSettings settings)
        {

            Guard.AssertArgumentIsNotNull(settings, nameof(settings));

            SetSecurityProtocol(settings);

            var authenticator = CreateAuthenticator(settings);

            // Neuen Rest Client erstellen
            var options = new RestClientOptions(settings.Url)
            {
                MaxTimeout = Convert.ToInt32(settings.Timeout.TotalMilliseconds),
                UserAgent = settings.ClientAgent,
                Authenticator = authenticator
            };

            var client = new RestClient(
                options,
                configureSerialization: configuration => configuration.UseNewtonsoftJson(new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                })
            );

            this.ConfigureClient(client, settings);

            Log.Trace(authenticator != null
                ? $"Created a new REST client to '{settings.Url}' with Authenticator."
                : $"Created a new REST client to '{settings.Url}'.");

            return client;
        }
    }
}
