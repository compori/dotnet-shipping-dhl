using System;
using System.Threading.Tasks;

namespace Compori.Shipping.Dhl.ParcelShipment.Services
{
    public class GeneralService
    {
        /// <summary>
        /// Liefert den REST Client zurück.
        /// </summary>
        /// <value>Der REST Client.</value>
        private Client Client { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneralService"/> class.
        /// </summary>
        /// <param name="client">Der REST Client.</param>
        public GeneralService(Client client)
        {
            this.Client = client;
        }

        /// <summary>
        /// Liefert Versionsinformationen zur API zurück.
        /// </summary>
        /// <returns>Common.Response&lt;Version&gt;.</returns>
        public async Task<Common.Response<Types.Version>> GetVersion()
        {
            return await this.Client.Get<Types.Version>().ConfigureAwait(false);
        }
    }
}
