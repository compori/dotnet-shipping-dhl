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
    }
}
