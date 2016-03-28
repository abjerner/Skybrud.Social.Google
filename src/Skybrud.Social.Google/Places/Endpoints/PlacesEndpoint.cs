using System;
using Skybrud.Social.Google.Common;
using Skybrud.Social.Google.Places.Endpoints.Raw;
using Skybrud.Social.Google.Places.Responses;

namespace Skybrud.Social.Google.Places.Endpoints {

    /// <summary>
    /// Class representing the Google Places API implementation.
    /// </summary>
    public class PlacesEndpoint {
        
        #region Properties

        /// <summary>
        /// Gets the parent service of this endpoint.
        /// </summary>
        public GoogleService Service { get; private set; }

        /// <summary>
        /// Gets a reference to the raw Google Places endpoint.
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

        public PlacesGetDetailsResponse GetDetails(string placeId) {
            if (String.IsNullOrWhiteSpace(placeId)) throw new ArgumentNullException("placeId");
            return PlacesGetDetailsResponse.ParseResponse(Raw.GetDetails(placeId));
        }

        #endregion

    }

}