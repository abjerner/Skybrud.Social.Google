using Newtonsoft.Json.Linq;
using Skybrud.Social.Google.Common.Objects;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Google.Geocoding.Objects {
    
    public class GeocodingAddressComponent : GoogleApiObject {

        #region Properties

        /// <summary>
        /// Gets the long name of the address component.
        /// </summary>
        public string LongName { get; private set; }

        /// <summary>
        /// Gets the short name of the address component.
        /// </summary>
        public string ShortName { get; private set; }

        /// <summary>
        /// Gets an array of tags/keywords that describe the type of the address component.
        /// </summary>
        public string[] Types { get; private set; }

        #endregion

        #region Constructors

        protected GeocodingAddressComponent(JObject obj) : base(obj) {
            LongName = obj.GetString("long_name");
            ShortName = obj.GetString("short_name");
            Types = obj.GetStringArray("types");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets an instance of <see cref="GeocodingAddressComponent"/> from the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> representing the address component.</param>
        /// <returns>Returns an instance of <see cref="GeocodingAddressComponent"/>.</returns>
        public static GeocodingAddressComponent Parse(JObject obj) {
            return obj == null ? null : new GeocodingAddressComponent(obj);
        }

        #endregion

    }

}