using System;
using Skybrud.Essentials.Locations;
using Skybrud.Social.Google.Common.OAuth;
using Skybrud.Social.Google.Places.Options;
using Skybrud.Social.Http;

namespace Skybrud.Social.Google.Places.Endpoints.Raw {
    
    /// <summary>
    /// Class representing the raw Google Places API implementation.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.google.com/places/web-service/</cref>
    /// </see>
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

        /// <summary>
        /// Gets details about the place with the specified <paramref name="placeId"/>.
        /// </summary>
        /// <param name="placeId">The ID of the place</param>
        /// <returns>An instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        public SocialHttpResponse GetDetails(string placeId) {
            if (String.IsNullOrWhiteSpace(placeId)) throw new ArgumentNullException("placeId");
            return GetDetails(new PlacesGetDetailsOptions(placeId));
        }

        /// <summary>
        /// Gets details about the place matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        public SocialHttpResponse GetDetails(PlacesGetDetailsOptions options) {
            if (options == null) throw new ArgumentNullException("options");
            return Client.DoHttpGetRequest("https://maps.googleapis.com/maps/api/place/details/json", options);
        }

        /// <summary>
        /// Performs a search for places within a area, based on the specified <paramref name="latitude"/>,
        /// <paramref name="longitude"/> and <paramref name="radius"/>.
        /// </summary>
        /// <param name="latitude">The latitude of the center location the search should be based on.</param>
        /// <param name="longitude">The longitude of the center location the search should be based on.</param>
        /// <param name="radius">The distance (in meters) within which to return place results. The maximum allowed
        /// radius is <code>50000</code> meters.</param>
        /// <returns>An instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        /// <see>
        ///     <cref>https://developers.google.com/places/web-service/search#PlaceSearchRequests</cref>
        /// </see>
        public SocialHttpResponse NearbySearch(double latitude, double longitude, int radius) {
            return NearbySearch(new PlacesNearbySearchOptions(latitude, longitude, radius));
        }

        /// <summary>
        /// Performs a search for places within a area, based on the specified <paramref name="location"/> and
        /// <paramref name="radius"/>.
        /// </summary>
        /// <param name="location">The center location the search should be based on.</param>
        /// <param name="radius">The distance (in meters) within which to return place results. The maximum allowed
        /// radius is <code>50000</code> meters.</param>
        /// <returns>An instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        /// <see>
        ///     <cref>https://developers.google.com/places/web-service/search#PlaceSearchRequests</cref>
        /// </see>
        public SocialHttpResponse NearbySearch(ILocation location, int radius) {
            if (location == null) throw new ArgumentNullException("location");
            return NearbySearch(new PlacesNearbySearchOptions(location, radius));
        }

        /// <summary>
        /// Performs a search for places within a area, based on the specified <paramref name="pageToken"/>.
        /// </summary>
        /// <param name="pageToken">The page token for the next page.</param>
        /// <returns>An instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        /// <see>
        ///     <cref>https://developers.google.com/places/web-service/search#PlaceSearchRequests</cref>
        /// </see>
        public SocialHttpResponse NearbySearch(string pageToken) {
            if (String.IsNullOrWhiteSpace(pageToken)) throw new ArgumentNullException("pageToken");
            return NearbySearch(new PlacesNearbySearchOptions(pageToken));
        }

        /// <summary>
        /// Performs a search for places within a area, based on the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        /// <see>
        ///     <cref>https://developers.google.com/places/web-service/search#PlaceSearchRequests</cref>
        /// </see>
        public SocialHttpResponse NearbySearch(PlacesNearbySearchOptions options) {
            if (options == null) throw new ArgumentNullException("options");
            return Client.DoHttpGetRequest("https://maps.googleapis.com/maps/api/place/nearbysearch/json", options);
        }

        #endregion

    }

}