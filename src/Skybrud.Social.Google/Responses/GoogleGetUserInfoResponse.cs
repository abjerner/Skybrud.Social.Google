using Skybrud.Social.Google.Objects;
using Skybrud.Social.Http;

namespace Skybrud.Social.Google.Responses {

    public class GoogleGetUserInfoResponse : GoogleApiResponse<GoogleUserInfo> {

        #region Constructors

        protected GoogleGetUserInfoResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, GoogleUserInfo.Parse);
        
        }

        #endregion

        #region Static methods

        public static GoogleGetUserInfoResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new GoogleGetUserInfoResponse(response);
        }

        #endregion

    }

}