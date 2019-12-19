using Skybrud.Essentials.Http;
using Skybrud.Social.Google.Models.Authentication;

namespace Skybrud.Social.Google.Responses.Authentication {

    /// <summary>
    /// Class representing a response with information about an access token (<see cref="GoogleToken"/>).
    /// </summary>
    public class GoogleTokenResponse : GoogleApiResponse<GoogleToken> {

        #region Constructors

        private GoogleTokenResponse(IHttpResponse response) : base(response) {

            // Parse the response body
            Body = ParseJsonObject(response.Body, GoogleToken.Parse);

        }

        #endregion

        /// <summary>
        /// Parses the specified <paramref name="response"/> into an instance of <see cref="GoogleTokenResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>An instance of <see cref="GoogleTokenResponse"/> representing the response.</returns>
        public static GoogleTokenResponse ParseResponse(IHttpResponse response) {
            return response == null ? null : new GoogleTokenResponse(response);
        }

    }

}