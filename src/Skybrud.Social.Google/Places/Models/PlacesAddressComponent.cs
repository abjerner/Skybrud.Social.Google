using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.Google.Common.Models;

namespace Skybrud.Social.Google.Places.Models {

    public class PlacesAddressComponent : GoogleApiObject {
        
        #region Properties

        public string LongName { get; private set; }

        public string ShortName { get; private set; }

        public string[] Types { get; private set; }

        #endregion

        #region Constructors

        private PlacesAddressComponent(JObject obj) : base(obj) {
            LongName = obj.GetString("long_name");
            ShortName = obj.GetString("short_name");
            Types = obj.GetStringArray("types");
        }

        #endregion
        
        #region Static methods
        
        /// <summary>
        /// Gets a user from the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        /// <returns>Returns an instance of <see cref="PlacesAddressComponent"/>.</returns>
        public static PlacesAddressComponent Parse(JObject obj) {
            return obj == null ? null : new PlacesAddressComponent(obj);
        }

        #endregion

    }

}