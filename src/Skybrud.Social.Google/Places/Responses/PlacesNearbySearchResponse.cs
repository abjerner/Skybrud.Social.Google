using Skybrud.Social.Google.Places.Objects;
using Skybrud.Social.Http;

namespace Skybrud.Social.Google.Places.Responses {

    public class PlacesNearbySearchResponse : PlacesResponse<PlacesNearbySearchResponseBody> {

        #region Constructors

        private PlacesNearbySearchResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, PlacesNearbySearchResponseBody.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="response"/> into an instance of <see cref="PlacesNearbySearchResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        public static PlacesNearbySearchResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new PlacesNearbySearchResponse(response);
        }

        #endregion

    }

}