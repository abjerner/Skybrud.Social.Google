using System;
using Skybrud.Social.Google.Common.OAuth;
using Skybrud.Social.Google.Geocoding.Options;
using Skybrud.Social.Http;

namespace Skybrud.Social.Google.Geocoding.Endpoints.Raw {

    /// <summary>
    /// Class representing the raw Geocoding API implementation.
    /// </summary>
    public class GeocodingRawEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the OAuth client.
        /// </summary>
        public GoogleOAuthClient Client { get; private set; }

        #endregion

        #region Constructors

        internal GeocodingRawEndpoint(GoogleOAuthClient client) {
            Client = client;
        }

        #endregion

        #region Member methods
        
        public SocialHttpResponse Geocode(string placeId) {
            if (String.IsNullOrWhiteSpace(placeId)) throw new ArgumentNullException("placeId");
            SocialQueryString query = new SocialQueryString();
            query.Add("place_id", placeId);
            return Client.DoHttpGetRequest("https://maps.googleapis.com/maps/api/geocode/json", query);
        }

        public SocialHttpResponse Geocode(GeocodingGetGeocodeOptions options) {
            if (options == null) throw new ArgumentNullException("options");
            return Client.DoHttpGetRequest("https://maps.googleapis.com/maps/api/geocode/json", options);
        }
        
        #endregion

    }

}