using Skybrud.Social.Google.Models.Authentication;
using Skybrud.Social.Http;

namespace Skybrud.Social.Google.Responses.Authentication {
    
    public class GoogleTokenResponse : GoogleApiResponse<GoogleToken> {

        #region Constructors

        private GoogleTokenResponse(SocialHttpResponse response) : base(response) {

            // Parse the response body
            Body = ParseJsonObject(response.Body, GoogleToken.Parse);

        }

        #endregion

        public static GoogleTokenResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new GoogleTokenResponse(response);
        }

    }

}