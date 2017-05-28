using Newtonsoft.Json.Linq;
using Skybrud.Social.Google.Common.Objects;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Google.Places.Objects {

    public class PlacesGeometry : GoogleApiObject {

        #region Properties

        public PlacesGeometryLocation Location { get; private set; }

        public PlacesGeometryViewport Viewport { get; private set; }

        #endregion

        #region Constructors

        private PlacesGeometry(JObject obj) : base(obj) {
            Location = obj.GetObject("location", PlacesGeometryLocation.Parse);
            Viewport = obj.GetObject("viewport", PlacesGeometryViewport.Parse);
        }

        #endregion
        
        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="PlacesGeometry"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        /// <returns>Returns an instance of <see cref="PlacesGeometry"/>.</returns>
        public static PlacesGeometry Parse(JObject obj) {
            return obj == null ? null : new PlacesGeometry(obj);
        }

        #endregion

    }

}