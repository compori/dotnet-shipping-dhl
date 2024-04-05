using Compori.Shipping.Dhl.Common;
using System.Threading.Tasks;
using Xunit;

namespace Compori.Shipping.Dhl.ParcelShipment.Services
{
    public class GeneralServiceTests : BaseTest
    {
        private GeneralService CreateService(string file)
        {
            var settingsFactory = this.TestContext.CreateSettingsFactory<Settings>(file);
            var restClientFactory = new RestClientFactory();
            var client = new Client(settingsFactory, restClientFactory);
            return new GeneralService(client);
        }

        protected override void Setup()
        {
            base.Setup();
        }

        [Fact()]
        public async Task TestGetVersion()
        {
            this.Setup();
            try
            {
                var sut = this.CreateService("parcel-shipment-sandbox.ignore.json");

                var version = await sut.GetVersion();

                Assert.NotNull(version?.Result);
                Assert.NotNull(version.Result.Amp);
                Assert.Equal("sandbox", version.Result.Amp.Environment.ToLower());
                Assert.NotNull(version.Result.Backend);
                Assert.Equal("sandbox", version.Result.Backend.Environment.ToLower());
            }
            finally
            {
                this.Cleanup();
            }
        }
    }
}

