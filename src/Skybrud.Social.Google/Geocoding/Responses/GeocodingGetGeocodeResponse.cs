using Skybrud.Social.Google.Geocoding.Objects;
using Skybrud.Social.Google.Places.Responses;
using Skybrud.Social.Http;

namespace Skybrud.Social.Google.Geocoding.Responses {

    public class GeocodingGetGeocodeResponse : PlacesResponse<GeocodingResultsCollection> {

        #region Constructors

        private GeocodingGetGeocodeResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, GeocodingResultsCollection.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <see cref="GeocodingGetGeocodeResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        public static GeocodingGetGeocodeResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new GeocodingGetGeocodeResponse(response);
        }

        #endregion

    }

}