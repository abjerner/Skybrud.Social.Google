using Skybrud.Social.Google.Places.Models;
using Skybrud.Social.Http;

namespace Skybrud.Social.Google.Places.Responses {

    public class PlacesGetDetailsResponse : PlacesResponse<PlacesGetDetailsResponseBody> {

        #region Constructors

        private PlacesGetDetailsResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, PlacesGetDetailsResponseBody.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <see cref="PlacesGetDetailsResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        public static PlacesGetDetailsResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new PlacesGetDetailsResponse(response);
        }

        #endregion

    }

}