using Skybrud.Essentials.Http;
using Skybrud.Social.Google.Models.Authentication;

namespace Skybrud.Social.Google.Responses.Authentication {
    
    public class GoogleTokenResponse : GoogleApiResponse<GoogleToken> {

        #region Constructors

        private GoogleTokenResponse(IHttpResponse response) : base(response) {

            // Parse the response body
            Body = ParseJsonObject(response.Body, GoogleToken.Parse);

        }

        #endregion

        public static GoogleTokenResponse ParseResponse(IHttpResponse response) {
            return response == null ? null : new GoogleTokenResponse(response);
        }

    }

}