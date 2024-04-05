using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Text;
using System.Threading.Tasks;

namespace Compori.Shipping.Dhl.RestSharp
{
    public class DhlAuthenticator : AuthenticatorBase
    {
        public DhlAuthenticator(string apiKey) : this(apiKey, Encoding.UTF8) { }

        public DhlAuthenticator(string apiKey, Encoding encoding) : base(GetHeader(apiKey, encoding)) { }

        static string GetHeader(string apiKey, Encoding encoding) => Convert.ToBase64String(encoding.GetBytes($"{apiKey}:"));

        protected override ValueTask<Parameter> GetAuthenticationParameter(string accessToken) 
            => new ValueTask<Parameter>(new HeaderParameter(KnownHeaders.Authorization, $"Basic {accessToken}"));
    }
}
