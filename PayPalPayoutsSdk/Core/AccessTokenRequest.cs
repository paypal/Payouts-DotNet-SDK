using PayPalHttp;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace PayoutsSdk.Core
{
    public class AccessTokenRequest : HttpRequest
    {
        public AccessTokenRequest(PayPalEnvironment environment, string refreshToken = null) : base("/v1/oauth2/token", HttpMethod.Post, typeof(AccessToken))
        {
            this.Headers.Authorization = new AuthenticationHeaderValue("Basic", environment.AuthorizationString());
            var body = new Dictionary<string, string>()
            {
                {"grant_type", "client_credentials"}
            };

            if (refreshToken != null)
            {
                body["grant_type"] = "refresh_token";
                body.Add("refresh_token", refreshToken);
            }

            this.Body = body;

            this.ContentType = "application/x-www-form-urlencoded";
        }
    }
}
