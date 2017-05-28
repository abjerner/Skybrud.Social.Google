using System;
using Newtonsoft.Json.Linq;
using Skybrud.Social.Google.Common.Objects;
using Skybrud.Social.Google.Places.Enums;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Google.Places.Objects {

    public class PlacesNearbySearchResponseBody : GoogleApiObject {
        
        #region Properties

        public string NextPageToken { get; private set; }

        public bool HasNextPageToken {
            get { return !String.IsNullOrWhiteSpace(NextPageToken); }
        }
        
        public PlacesDetailsResult[] Results { get; private set; }

        public PlacesResponseStatusCode Status { get; private set; }

        #endregion

        #region Constructors

        private PlacesNearbySearchResponseBody(JObject obj) : base(obj) {
            NextPageToken = obj.GetString("next_page_token");    
            Results = obj.GetArrayItems("results", PlacesDetailsResult.Parse);
            Status = obj.GetEnum<PlacesResponseStatusCode>("status");
        }

        #endregion
        
        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="PlacesNearbySearchResponseBody"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        /// <returns>An instance of <see cref="PlacesNearbySearchResponseBody"/>.</returns>
        public static PlacesNearbySearchResponseBody Parse(JObject obj) {
            return obj == null ? null : new PlacesNearbySearchResponseBody(obj);
        }

        #endregion

    }

}