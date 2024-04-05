using Newtonsoft.Json;
using System;
using System.IO;
using System.Text;

namespace Compori.Shipping.Dhl.Common
{
    public class SettingsFactory<TSettings> : ISettingsFactory<TSettings> where TSettings : Settings
    {
        /// <summary>
        /// Liefert die Einstellungen zrück.
        /// </summary>
        /// <value>Die Einstellungen.</value>
        public TSettings Settings { get; protected set; }

        /// <summary>
        /// Liest die Einstellungen aus einer Json Text Datei.
        /// </summary>
        /// <param name="path">The path.</param>
        public void ReadFromJsonFile(string path)
        {
            Guard.AssertArgumentIsNotNullOrWhiteSpace(path, nameof(path));

            var json = File.ReadAllText(path, Encoding.UTF8);
            ReadFromJson(json);
        }

        /// <summary>
        /// Liest die Einstellungen aus einer Json Text Datei.
        /// </summary>
        /// <param name="path">The path.</param>
        public void SaveJsonFile(string path, TSettings settings)
        {
            Guard.AssertArgumentIsNotNullOrWhiteSpace(path, nameof(path));
            Guard.AssertArgumentIsNotNull(settings, nameof(settings));

            File.WriteAllText(path, JsonConvert.SerializeObject(settings), Encoding.UTF8);
        }

        /// <summary>
        /// Liest die Einstellungen aus einem Json String
        /// </summary>
        /// <param name="json">The json.</param>
        public void ReadFromJson(string json)
        {
            Guard.AssertArgumentIsNotNullOrWhiteSpace(json, nameof(json));

            Settings = JsonConvert.DeserializeObject<TSettings>(json);
        }

        /// <summary>
        /// Erstellt die benötigten Einstellungen für den Shopware Client.
        /// </summary>
        /// <returns>Settings.</returns>
        /// <exception cref="InvalidOperationException">Die Einstellungen sind nicht gesetzt.</exception>
        public TSettings Create()
        {
            if (Settings == null)
            {
                throw new InvalidOperationException("Die Einstellungen sind nicht gesetzt.");
            }
            return Settings;
        }
    }
}
