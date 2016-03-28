using System;
using Skybrud.Social.Google.Common.OAuth;
using Skybrud.Social.Http;

namespace Skybrud.Social.Google.Places.Endpoints.Raw {

    /// <summary>
    /// Class representing the raw Google Places API implementation.
    /// </summary>
    public class PlacesRawEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the OAuth client.
        /// </summary>
        public GoogleOAuthClient Client { get; private set; }

        #endregion

        #region Constructors

        internal PlacesRawEndpoint(GoogleOAuthClient client) {
            Client = client;
        }

        #endregion

        #region Member methods

        public SocialHttpResponse GetDetails(string placeId) {
            if (String.IsNullOrWhiteSpace(placeId)) throw new ArgumentNullException("placeId");
            SocialQueryString query = new SocialQueryString();
            query.Add("placeid", placeId);
            return Client.DoHttpGetRequest("https://maps.googleapis.com/maps/api/place/details/json", query);
        }

        #endregion

    }

}