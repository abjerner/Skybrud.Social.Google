using Skybrud.Essentials.Locations;
using Skybrud.Social.Google.Common;
using Skybrud.Social.Google.Places.Endpoints.Raw;
using Skybrud.Social.Google.Places.Options;
using Skybrud.Social.Google.Places.Responses;

namespace Skybrud.Social.Google.Places.Endpoints {
    
    /// <summary>
    /// Class representing the Google Places API implementation.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.google.com/places/web-service/</cref>
    /// </see>
    public class PlacesEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the parent service of this endpoint.
        /// </summary>
        public GoogleService Service { get; private set; }

        /// <summary>
        /// Gets a reference to the raw endpoint.
        /// </summary>
        public PlacesRawEndpoint Raw {
            get { return Service.Client.Places; }
        }

        #endregion

        #region Constructors

        internal PlacesEndpoint(GoogleService service) {
            Service = service;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets details about the place with the specified <paramref name="placeId"/>.
        /// </summary>
        /// <param name="placeId">The ID of the place</param>
        /// <returns>An instance of <see cref="PlacesGetDetailsResponse"/> representing the response.</returns>
        public PlacesGetDetailsResponse GetDetails(string placeId) {
            return PlacesGetDetailsResponse.ParseResponse(Raw.GetDetails(placeId));
        }

        /// <summary>
        /// Gets details about the place matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="PlacesGetDetailsResponse"/> representing the response.</returns>
        public PlacesGetDetailsResponse GetDetails(PlacesGetDetailsOptions options) {
            return PlacesGetDetailsResponse.ParseResponse(Raw.GetDetails(options));
        }

        /// <summary>
        /// Performs a search for places within a area, based on the specified <paramref name="latitude"/>,
        /// <paramref name="longitude"/> and <paramref name="radius"/>.
        /// </summary>
        /// <param name="latitude">The latitude of the center location the search should be based on.</param>
        /// <param name="longitude">The longitude of the center location the search should be based on.</param>
        /// <param name="radius">The distance (in meters) within which to return place results. The maximum allowed
        /// radius is <code>50000</code> meters.</param>
        /// <returns>An instance of <see cref="PlacesNearbySearchResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://developers.google.com/places/web-service/search#PlaceSearchRequests</cref>
        /// </see>
        public PlacesNearbySearchResponse NearbySearch(double latitude, double longitude, int radius) {
            return PlacesNearbySearchResponse.ParseResponse(Raw.NearbySearch(latitude, longitude, radius));
        }

        /// <summary>
        /// Performs a search for places within a area, based on the specified <paramref name="location"/> and
        /// <paramref name="radius"/>.
        /// </summary>
        /// <param name="location">The center location the search should be based on.</param>
        /// <param name="radius">The distance (in meters) within which to return place results. The maximum allowed
        /// radius is <code>50000</code> meters.</param>
        /// <returns>An instance of <see cref="PlacesNearbySearchResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://developers.google.com/places/web-service/search#PlaceSearchRequests</cref>
        /// </see>
        public PlacesNearbySearchResponse NearbySearch(ILocation location, int radius) {
            return PlacesNearbySearchResponse.ParseResponse(Raw.NearbySearch(location, radius));
        }

        /// <summary>
        /// Performs a search for places within a area, based on the specified <paramref name="pageToken"/>.
        /// </summary>
        /// <param name="pageToken">The page token for the next page.</param>
        /// <returns>An instance of <see cref="PlacesNearbySearchResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://developers.google.com/places/web-service/search#PlaceSearchRequests</cref>
        /// </see>
        public PlacesNearbySearchResponse NearbySearch(string pageToken) {
            return PlacesNearbySearchResponse.ParseResponse(Raw.NearbySearch(pageToken));
        }

        /// <summary>
        /// Performs a search for places within a area, based on the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="PlacesNearbySearchResponse"/> representing the response.</returns>
        /// <see>
        ///     <cref>https://developers.google.com/places/web-service/search#PlaceSearchRequests</cref>
        /// </see>
        public PlacesNearbySearchResponse NearbySearch(PlacesNearbySearchOptions options) {
            return PlacesNearbySearchResponse.ParseResponse(Raw.NearbySearch(options));
        }

        #endregion

    }

}