using Newtonsoft.Json.Linq;
using Skybrud.Social.Google.Common.Objects;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Google.Places.Objects {

    public class PlacesGeometryViewport : GoogleApiObject {
        
        #region Properties

        public PlacesGeometryLocation NorthEast { get; private set; }

        public PlacesGeometryLocation SouthWest { get; private set; }

        #endregion

        #region Constructors

        private PlacesGeometryViewport(JObject obj) : base(obj) {
            NorthEast = obj.GetObject("northeast", PlacesGeometryLocation.Parse);
            SouthWest = obj.GetObject("southwest", PlacesGeometryLocation.Parse);
        }

        #endregion
        
        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="PlacesGeometryViewport"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        /// <returns>Returns an instance of <see cref="PlacesGeometryViewport"/>.</returns>
        public static PlacesGeometryViewport Parse(JObject obj) {
            return obj == null ? null : new PlacesGeometryViewport(obj);
        }

        #endregion

    }

}