using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Net.Http.Headers;
using PayPalHttp;

namespace PayoutsSdk.Core
{
    public class RefreshTokenRequest: HttpRequest
    {
        public RefreshTokenRequest(PayPalEnvironment environment, string code): base("/v1/identity/openidconnect/tokenservice", HttpMethod.Post, typeof(RefreshToken))
        {
            this.Headers.Authorization = new AuthenticationHeaderValue("Basic", environment.AuthorizationString());
            this.Body = new Dictionary<string, string>()
            {
                {"grant_type", "authorization_code"},
                {"code", code},
            };
            this.ContentType = "application/x-www-form-urlencoded";
        }
    }
}
