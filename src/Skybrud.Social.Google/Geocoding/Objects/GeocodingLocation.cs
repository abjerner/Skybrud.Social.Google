using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Essentials.Locations;
using Skybrud.Social.Google.Common.Models;

namespace Skybrud.Social.Google.Geocoding.Objects {
    
    public class GeocodingLocation : GoogleApiObject, ILocation {

        #region Properties

        public double Latitude { get; private set; }

        public double Longitude { get; private set; }

        #endregion

        #region Constructors

        protected GeocodingLocation(JObject obj) : base(obj) {
            Latitude = obj.GetDouble("lat");
            Longitude = obj.GetDouble("lng");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets an instance of <see cref="GeocodingLocation"/> from the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> representing the address component.</param>
        /// <returns>Returns an instance of <see cref="GeocodingLocation"/>.</returns>
        public static GeocodingLocation Parse(JObject obj) {
            return obj == null ? null : new GeocodingLocation(obj);
        }

        #endregion

    }

}