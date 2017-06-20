using Skybrud.Social.Google.Common.Models;
using Skybrud.Social.Http;

namespace Skybrud.Social.Google.Common.Responses {

    /// <summary>
    /// Class representing the response for getting information about the authenticated user.
    /// </summary>
    public class GoogleGetUserInfoResponse : GoogleApiResponse<GoogleUserInfo> {

        #region Constructors

        private GoogleGetUserInfoResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, GoogleUserInfo.Parse);
        
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="response"/> into an instance of <see cref="GoogleGetUserInfoResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>An instance of <see cref="GoogleGetUserInfoResponse"/> representing the response.</returns>
        public static GoogleGetUserInfoResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new GoogleGetUserInfoResponse(response);
        }

        #endregion

    }

}