using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Essentials.Locations;
using Skybrud.Social.Google.Common.Models;

namespace Skybrud.Social.Google.Places.Models {

    public class PlacesGeometryLocation : GoogleApiObject, ILocation {
        
        #region Properties

        public double Latitude { get; private set; }
        
        public double Longitude { get; private set; }

        #endregion

        #region Constructors

        private PlacesGeometryLocation(JObject obj) : base(obj) {
            Latitude = obj.GetDouble("lat");
            Longitude = obj.GetDouble("lng");
        }

        #endregion
        
        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="PlacesGeometryLocation"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        /// <returns>Returns an instance of <see cref="PlacesGeometryLocation"/>.</returns>
        public static PlacesGeometryLocation Parse(JObject obj) {
            return obj == null ? null : new PlacesGeometryLocation(obj);
        }

        #endregion

    }

}