using Skybrud.Social.Google.Places.Objects;
using Skybrud.Social.Http;

namespace Skybrud.Social.Google.Places.Responses {

    public class PlacesTextSearchResponse : PlacesResponse<PlacesTextSearchResponseBody> {

        #region Constructors

        private PlacesTextSearchResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, PlacesTextSearchResponseBody.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="response"/> into an instance of <see cref="PlacesTextSearchResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        public static PlacesTextSearchResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new PlacesTextSearchResponse(response);
        }

        #endregion

    }

}