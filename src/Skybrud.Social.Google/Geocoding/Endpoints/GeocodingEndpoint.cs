using System;
using Skybrud.Social.Google.Common;
using Skybrud.Social.Google.Geocoding.Endpoints.Raw;
using Skybrud.Social.Google.Geocoding.Options;
using Skybrud.Social.Google.Geocoding.Responses;

namespace Skybrud.Social.Google.Geocoding.Endpoints {

    /// <summary>
    /// Class representing the Geocoding API implementation.
    /// </summary>
    public class GeocodingEndpoint {
        
        #region Properties

        /// <summary>
        /// Gets the parent service of this endpoint.
        /// </summary>
        public GoogleService Service { get; private set; }

        /// <summary>
        /// Gets a reference to the raw Geocoding API endpoint.
        /// </summary>
        public GeocodingRawEndpoint Raw {
            get { return Service.Client.Geocoding; }
        }

        #endregion

        #region Constructors

        internal GeocodingEndpoint(GoogleService service) {
            Service = service;
        }

        #endregion

        #region Member methods
        
        public GeocodingGetGeocodeResponse Geocode(string placeId) {
            if (String.IsNullOrWhiteSpace(placeId)) throw new ArgumentNullException("placeId");
            return GeocodingGetGeocodeResponse.ParseResponse(Raw.Geocode(placeId));
        }

        public GeocodingGetGeocodeResponse Geocode(GeocodingGetGeocodeOptions options) {
            if (options == null) throw new ArgumentNullException("options");
            return GeocodingGetGeocodeResponse.ParseResponse(Raw.Geocode(options));
        }

        #endregion

    }

}