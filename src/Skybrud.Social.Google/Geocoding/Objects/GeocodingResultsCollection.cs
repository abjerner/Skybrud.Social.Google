using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.Google.Common.Models;

namespace Skybrud.Social.Google.Geocoding.Objects {
    
    public class GeocodingResultsCollection : GoogleApiObject {

        #region Properties

        /// <summary>
        /// Gets an array of places that matched your query.
        /// </summary>
        public GeocodingResult[] Results { get; private set; }

        /// <summary>
        /// Gets the status of the response from the Geocoding API. At this point, <see cref="Status"/> will most
        /// likely always be <code>OK</code>.
        /// </summary>
        public string Status { get; private set; }

        #endregion

        #region Constructors

        protected GeocodingResultsCollection(JObject obj) : base(obj) {
            Results = obj.GetArrayItems("results", GeocodingResult.Parse);
            Status = obj.GetString("status");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets an instance of <see cref="GeocodingResultsCollection"/> from the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> representing the collection.</param>
        /// <returns>Returns an instance of <see cref="GeocodingResultsCollection"/>.</returns>
        public static GeocodingResultsCollection Parse(JObject obj) {
            return obj == null ? null : new GeocodingResultsCollection(obj);
        }

        #endregion

    }

}