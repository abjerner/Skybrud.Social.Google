using System;
using Newtonsoft.Json.Linq;
using Skybrud.Social.Google.OAuth.Objects;
using Skybrud.Social.Google.Responses;
using Skybrud.Social.Http;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Social.Google.OAuth.Responses {
    
    public class GoogleAccessTokenResponse : GoogleApiResponse<GoogleAccessToken> {

        #region Constructors

        private GoogleAccessTokenResponse(SocialHttpResponse response) : base(response) {

            // Parse the response body
            Body = ParseJsonObject(response.Body, GoogleAccessToken.Parse);

        }

        #endregion

        public static GoogleAccessTokenResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new GoogleAccessTokenResponse(response);
        }

    }

}