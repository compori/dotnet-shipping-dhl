using Compori.Shipping.Dhl.Common;
using Compori.Shipping.Dhl.ParcelShipment.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Compori.Shipping.Dhl.ParcelShipment.Services
{
    public class ShipmentServiceTests : BaseTest
    {
        private ShipmentService CreateService(string file)
        {
            var settingsFactory = this.TestContext.CreateSettingsFactory<Settings>(file);
            var restClientFactory = new RestClientFactory();
            var client = new Client(settingsFactory, restClientFactory);
            return new ShipmentService(client);
        }

        protected override void Setup()
        {
            base.Setup();
        }

        [Fact()]
        public async Task TestCreate()
        {
            this.Setup();
            try
            {
                var profile = "STANDARD_GRUPPENPROFIL";
                var sut = this.CreateService("parcel-shipment-sandbox.ignore.json");
                var reference = Guid.NewGuid().ToString("N");
                var result = await sut.Create(new Types.CreateShipments
                {
                    Profile = profile,
                    Shipments = new List<CreateShipment>
                    {
                        new CreateShipment
                        {
                            Product = "V01PAK",
                            BillingNumber = "33333333330102",
                            ReferenceNumber = reference,
                            Shipper = new ShipperAddress
                            {
                                Name1 = "My Online Shop GmbH",
                                AddressStreet =  "Sträßchensweg 10",
                                AdditionalAddressInformation1 = "2. Etage",
                                PostalCode = "53113",
                                City = "Bonn",
                                Country = "DEU",
                                Email = "max@mustermann.de",
                                Phone = "+49 123456789"
                            },
                            Consignee = new ContactAddress
                            {
                                Name1 = "Maria Musterfrau",
                                AddressStreet = "Kurt-Schumacher-Str. 20",
                                AdditionalAddressInformation1 = "Apartment 107",
                                PostalCode= "53113",
                                City= "Bonn",
                                Country= "DEU",
                                Email = "maria@musterfrau.de",
                                Phone = "+49 987654321"
                            },
                            Details = new Details
                            {
                                Dimension = new Dimension
                                {
                                    Unit = "mm",
                                    Height = 100,
                                    Length = 200,
                                    Width = 150
                                },
                                Weight = new Weight
                                {
                                    Unit = "g",
                                    Value = 500
                                }
                            }
                        }
                    }
                },
                validate: false,
                mustEncode: false,
                includeDocuments: true,
                documentFormat: "PDF",
                printFormat: null,
                retourePrintFormat: null,
                combine: true);

                Assert.NotNull(result);
                Assert.NotNull(result.Status);
                Assert.Equal("OK", result.Status.Title);
                Assert.Equal(200, result.Status.Code);
                Assert.Equal("1 von 1 Sendung erfolgreich erzeugt.", result.Status.Detail);
                var actual = Assert.Single(result.Items);
                
                Assert.Equal(reference, actual.ReferenceNumber);
                Assert.Equal("OK", actual.Status.Title);
                Assert.Equal(200, actual.Status.Code);

                Assert.NotEmpty(actual.ShipmentNumber);

                var readResult = await sut.Read(actual.ShipmentNumber);

                var deleted = await sut.Delete(profile, actual.ShipmentNumber);
                Assert.True(deleted);
                await Assert.ThrowsAsync<ResponseException>(async () => await sut.Delete(profile, actual.ShipmentNumber));
                await Assert.ThrowsAsync<ResponseException>(async () => await sut.Read(actual.ShipmentNumber));
            }
            finally
            {
                this.Cleanup();
            }
        }
        
        [Fact()]
        public async Task TestCreateDoubleWeight()
        {
            this.Setup();
            try
            {
                var profile = "STANDARD_GRUPPENPROFIL";
                var sut = this.CreateService("parcel-shipment-sandbox.ignore.json");
                var reference = Guid.NewGuid().ToString("N");
                var result = await sut.Create(new Types.CreateShipments
                {
                    Profile = profile,
                    Shipments = new List<CreateShipment>
                    {
                        new CreateShipment
                        {
                            Product = "V01PAK",
                            BillingNumber = "33333333330102",
                            ReferenceNumber = reference,
                            Shipper = new ShipperAddress
                            {
                                Name1 = "My Online Shop GmbH",
                                AddressStreet =  "Sträßchensweg 10",
                                AdditionalAddressInformation1 = "2. Etage",
                                PostalCode = "53113",
                                City = "Bonn",
                                Country = "DEU",
                                Email = "max@mustermann.de",
                                Phone = "+49 123456789"
                            },
                            Consignee = new ContactAddress
                            {
                                Name1 = "Maria Musterfrau",
                                AddressStreet = "Kurt-Schumacher-Str. 20",
                                AdditionalAddressInformation1 = "Apartment 107",
                                PostalCode= "53113",
                                City= "Bonn",
                                Country= "DEU",
                                Email = "maria@musterfrau.de",
                                Phone = "+49 987654321"
                            },
                            Details = new Details
                            {
                                Dimension = new Dimension
                                {
                                    Unit = "mm",
                                    Height = 100,
                                    Length = 200,
                                    Width = 150
                                },
                                Weight = new Weight
                                {
                                    Unit = "kg",
                                    Value = 5.32
                                }
                            }
                        }
                    }
                },
                validate: false,
                mustEncode: false,
                includeDocuments: false,
                documentFormat: "PDF",
                printFormat: null,
                retourePrintFormat: null,
                combine: true);

                Assert.NotNull(result);
                Assert.NotNull(result.Status);
                Assert.Equal("OK", result.Status.Title);
                Assert.Equal(200, result.Status.Code);
                Assert.Equal("1 von 1 Sendung erfolgreich erzeugt.", result.Status.Detail);
                var actual = Assert.Single(result.Items);
                
                Assert.Equal(reference, actual.ReferenceNumber);
                Assert.Equal("OK", actual.Status.Title);
                Assert.Equal(200, actual.Status.Code);

                Assert.NotEmpty(actual.ShipmentNumber);

                var readResult = await sut.Read(actual.ShipmentNumber);

                var deleted = await sut.Delete(profile, actual.ShipmentNumber);
                Assert.True(deleted);
                await Assert.ThrowsAsync<ResponseException>(async () => await sut.Delete(profile, actual.ShipmentNumber));
                await Assert.ThrowsAsync<ResponseException>(async () => await sut.Read(actual.ShipmentNumber));
            }
            finally
            {
                this.Cleanup();
            }
        }
    }
}
