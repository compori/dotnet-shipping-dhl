using Compori.Shipping.Dhl.Common;
using Compori.Shipping.Dhl.ParcelShipment.Types;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Net;

namespace Compori.Shipping.Dhl.ParcelShipment
{
    public class Client : Client<Settings>
    {
        public Client(ISettingsFactory<Settings> settingsFactory, RestClientFactory restClientFactory) : base(settingsFactory, restClientFactory)
        {
        }

        private ValidationResult TryParseValidationResult(RestResponse response)
        {
            try
            {
                return JsonConvert.DeserializeObject<ValidationResult>(response.Content);
            }
            catch (Exception)
            {
                return null;
            }
        }

        protected override void OnProcessResponse(Common.Settings settings, RestResponse response, DateTime startTime)
        {
            base.OnProcessResponse(settings, response, startTime);

            if (response == null)
            {
                return;
            }
            if (response.StatusCode == HttpStatusCode.BadRequest)
            {
                var validation = TryParseValidationResult(response);
                if (validation != null)
                {
                    throw new ValidationException(response, validation);
                }
            }
        }
    }
}
