using System;
using System.Globalization;
using Skybrud.Social.Http;
using Skybrud.Social.Interfaces.Http;

namespace Skybrud.Social.Google.Geocoding.Options {
    
    public class GeocodingGetGeocodeOptions : IHttpGetOptions {

        #region Properties

        /// <summary>
        /// Gets or sets the ID of the place to get information about.
        /// </summary>
        public string PlaceId { get; set; }

        /// <summary>
        /// Gets or sets the address the search should be based on.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets the location used for a reverse geocode lookup.
        /// </summary>
        public SocialLocation Location { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance with empty options.
        /// </summary>
        public GeocodingGetGeocodeOptions() { }

        /// <summary>
        /// Initializes a new instance for the location with the specified <code>latitude</code> and <code>longitude</code>.
        /// </summary>
        /// <param name="latitude">The latitude of the location.</param>
        /// <param name="longitude">The longitude of the location.</param>
        public GeocodingGetGeocodeOptions(double latitude, double longitude) {
            Location = new SocialLocation(latitude, longitude);
        }

        /// <summary>
        /// Initializes a new instance for the specified <code>location</code>.
        /// </summary>
        /// <param name="location">The location.</param>
        public GeocodingGetGeocodeOptions(SocialLocation location) {
            if (location == null) throw new ArgumentNullException("location");
            Location = location;
        }

        #endregion

        #region Member methods

        public IHttpQueryString GetQueryString() {

            SocialHttpQueryString query = new SocialHttpQueryString();

            if (!String.IsNullOrWhiteSpace(PlaceId)) {
                query.Add("place_id", PlaceId);
            }

            if (!String.IsNullOrWhiteSpace(Address)) {
                query.Add("address", Address);
            }

            if (Location != null) {
                query.Add("latlng", String.Format(CultureInfo.InvariantCulture, "{0},{1}", Location.Latitude, Location.Longitude));
            }

            return query;

        }

        #endregion

        #region Static methods

        public static GeocodingGetGeocodeOptions GetFromAddress(string address) {
            if (String.IsNullOrWhiteSpace(address)) throw new ArgumentNullException("address");
            return new GeocodingGetGeocodeOptions { Address = address };
        }

        public static GeocodingGetGeocodeOptions GetFromPlaceId(string placeId) {
            if (String.IsNullOrWhiteSpace(placeId)) throw new ArgumentNullException("placeId");
            return new GeocodingGetGeocodeOptions { PlaceId = placeId };
        }

        public static GeocodingGetGeocodeOptions GetFromLocation(double latitude, double longitude) {
            return new GeocodingGetGeocodeOptions(latitude, longitude);
        }

        public static GeocodingGetGeocodeOptions GetFromLocation(SocialLocation location) {
            if (location == null) throw new ArgumentNullException("location");
            return new GeocodingGetGeocodeOptions(location);
        }

        #endregion

    }

}