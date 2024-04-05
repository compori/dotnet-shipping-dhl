using Compori.Shipping.Dhl.ParcelShipment.Types;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Compori.Shipping.Dhl.ParcelShipment.Services
{
    public class ShipmentService
    {
        /// <summary>
        /// Gets the REST Client.
        /// </summary>
        /// <value>The REST Client.</value>
        private Client Client { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentService"/> class.
        /// </summary>
        /// <param name="client">The REST Client.</param>
        public ShipmentService(Client client)
        {
            this.Client = client;
        }

        /// <summary>
        /// Creates shipment orders.
        /// </summary>
        /// <param name="shipments">The shipments.</param>
        /// <param name="validate">if set to <c>true</c> [validate].</param>
        /// <param name="mustEncode">if set to <c>true</c> [must encode].</param>
        /// <param name="includeDocuments">if set to <c>true</c> [include documents].</param>
        /// <param name="documentFormat">The document format.</param>
        /// <param name="printFormat">The print format.</param>
        /// <param name="retourePrintFormat">The retoure print format.</param>
        /// <param name="combine">if set to <c>true</c> [combine].</param>
        /// <returns>CreateShipmentsResult.</returns>
        public async Task<ShipmentsResult> Create(
            CreateShipments shipments,
            bool validate = false,
            bool mustEncode = false,
            bool includeDocuments = true,
            string documentFormat = "PDF",
            string printFormat = null,
            string retourePrintFormat = null,
            bool combine = true)
        {
            // Query parameters
            var parameters = new Dictionary<string, string>()
            {
                { "validate", validate ? "true" : "false" },
                { "mustEncode", mustEncode ? "true" : "false" },
                { "includeDocs", includeDocuments ? "include" : "URL" },
                { "docFormat", documentFormat },
                { "combine", combine ? "true" : "false" },
            };
            if (!string.IsNullOrEmpty(printFormat))
            {
                parameters.Add("printFormat", printFormat);
            }
            if (!string.IsNullOrEmpty(retourePrintFormat))
            {
                parameters.Add("retourePrintFormat", retourePrintFormat);
            }

            // Create Shipment
            var result = await this.Client.Post<CreateShipments, ShipmentsResult>(
                "orders",
                shipments,
                null,
                parameters).ConfigureAwait(false);

            return result.Result;
        }

        /// <summary>
        /// Deletes a shipment order.
        /// </summary>
        /// <param name="profile">The profile.</param>
        /// <param name="shipmentNumber">The shipment number.</param>
        public async Task<bool> Delete(string profile, string shipmentNumber)
        {
            var result = await this.Client.Delete("orders", null, new Dictionary<string, string>
            {
                { "profile", profile },
                { "shipment", shipmentNumber },

            });

            return result.StatusCode == System.Net.HttpStatusCode.OK;
        }

        /// <summary>
        /// Reads the specified shipment number.
        /// </summary>
        /// <param name="shipmentNumber">The shipment number.</param>
        /// <param name="includeDocuments">if set to <c>true</c> [include documents].</param>
        /// <param name="documentFormat">The document format.</param>
        /// <param name="printFormat">The print format.</param>
        /// <param name="retourePrintFormat">The retoure print format.</param>
        /// <param name="combine">if set to <c>true</c> [combine].</param>
        /// <returns>CreateShipmentsResult.</returns>
        public async Task<ShipmentsResult> Read(
            string shipmentNumber,
            bool includeDocuments = true,
            string documentFormat = "PDF",
            string printFormat = null,
            string retourePrintFormat = null,
            bool combine = true)
        {
            // Query parameters
            var parameters = new Dictionary<string, string>()
            {
                { "shipment" , shipmentNumber },
                { "includeDocs", includeDocuments ? "include" : "URL" },
                { "docFormat", documentFormat },
                { "combine", combine ? "true" : "false" },
            };
            if (!string.IsNullOrEmpty(printFormat))
            {
                parameters.Add("printFormat", printFormat);
            }
            if (!string.IsNullOrEmpty(retourePrintFormat))
            {
                parameters.Add("retourePrintFormat", retourePrintFormat);
            }
            var result = await this.Client.Get<ShipmentsResult>(
                "orders",
                null,
                parameters).ConfigureAwait(false);
         
            return result.Result;
        }
    }
}
