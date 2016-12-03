using Newtonsoft.Json.Linq;
using Skybrud.Social.Google.Common.Objects;
using Skybrud.Social.Json.Extensions;

namespace Skybrud.Social.Google.Geocoding.Objects {
    
    public class GeocodingBox : GoogleApiObject {

        #region Properties

        public GeocodingLocation NorthEast { get; private set; }

        public GeocodingLocation SouthWest { get; private set; }

        #endregion

        #region Constructors

        protected GeocodingBox(JObject obj) : base(obj) {
            NorthEast = obj.GetObject("northeast", GeocodingLocation.Parse);
            SouthWest = obj.GetObject("southwest", GeocodingLocation.Parse);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets an instance of <see cref="GeocodingBox"/> from the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> representing the address component.</param>
        /// <returns>Returns an instance of <see cref="GeocodingBox"/>.</returns>
        public static GeocodingBox Parse(JObject obj) {
            return obj == null ? null : new GeocodingBox(obj);
        }

        #endregion

    }

}