using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Compori.Shipping.Dhl.Common;

namespace Compori.Shipping.Dhl
{
    public class TestContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestContext"/> class.
        /// </summary>
        public TestContext()
        {
        }

        /// <summary>
        /// Erstellt ein neues Einstellungsfaktoryobjekt.
        /// </summary>
        /// <typeparam name="TSettings">Der Typ der Eintstellungen.</typeparam>
        /// <param name="file">Der Dateiname.</param>
        /// <returns>ISettingsFactory&lt;TSettings&gt;.</returns>
        public ISettingsFactory<TSettings> CreateSettingsFactory<TSettings>(string file) where TSettings : Settings
        {
            var factory = new SettingsFactory<TSettings>();
            factory.ReadFromJsonFile(file);
            return factory;
        }

        /*
        /// <summary>
        /// Creates the settings factory.
        /// </summary>
        /// <returns>ISettingsFactory.</returns>
        public ISettingsFactory CreateSettingsFactory()
        {
            var factory = new SettingsFactory();
            factory.ReadFromJsonFile("sandbox.ignore.json");
            return factory;
        }

        /// <summary>
        /// Creates the settings factory.
        /// </summary>
        /// <returns>ISettingsFactory.</returns>
        public ISettingsFactory CreateUnauthorizedSettingsFactory()
        {
            var factory = new SettingsFactory();
            factory.ReadFromJsonFile("testing-unauthorized-shipcloud.ignore.json");
            return factory;
        }

        /// <summary>
        /// Liefert die Testeinstellungen zurück.
        /// </summary>
        /// <returns>Settings.</returns>
        public Settings GetSettings()
        {
            var factory = this.CreateSettingsFactory();
            return factory.Create();
        }

        /// <summary>
        /// Creates the client.
        /// </summary>
        /// <returns>Client.</returns>
        public Client CreateUnauthorizedClient()
        {
            var settingsFactory = this.CreateUnauthorizedSettingsFactory();
            var restClientFactory = new RestClientFactory();
            return new Client(settingsFactory, restClientFactory);
        }

        /// <summary>
        /// Creates the client.
        /// </summary>
        /// <returns>Client.</returns>
        public Client CreateClient()
        {
            if (this.client == null)
            {
                var settingsFactory = this.CreateSettingsFactory();
                var restClientFactory = new RestClientFactory();
                this.client = new Client(settingsFactory, restClientFactory);
            }
            return this.client;
        }
        */
    }
}
