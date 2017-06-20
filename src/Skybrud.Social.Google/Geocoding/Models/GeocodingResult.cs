using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.Google.Common.Models;

namespace Skybrud.Social.Google.Geocoding.Models {

    public class GeocodingResult : GoogleApiObject {

        #region Properties

        /// <summary>
        /// Gets an array of the components that make of the address of this place.
        /// </summary>
        public GeocodingAddressComponent[] AddressComponents { get; private set; }

        /// <summary>
        /// Gets the formatted address of the place.
        /// </summary>
        public string FormattedAddress { get; private set; }

        /// <summary>
        /// Gets geometric information about the place.
        /// </summary>
        public GeocodingGeometry Geometry { get; private set; }

        /// <summary>
        /// Gets the ID of the place.
        /// </summary>
        public string PlaceId { get; private set; }

        /// <summary>
        /// Gets an array of tags/keywords that describe the type of the place.
        /// </summary>
        public string[] Types { get; private set; }

        #endregion

        #region Constructors

        protected GeocodingResult(JObject obj) : base(obj) {
            AddressComponents = obj.GetArrayItems("address_components", GeocodingAddressComponent.Parse);
            FormattedAddress = obj.GetString("formatted_address");
            Geometry = obj.GetObject("geometry", GeocodingGeometry.Parse);
            PlaceId = obj.GetString("place_id");
            Types = obj.GetStringArray("types");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets an instance of <see cref="GeocodingResult"/> from the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> representing the result.</param>
        /// <returns>Returns an instance of <see cref="GeocodingResult"/>.</returns>
        public static GeocodingResult Parse(JObject obj) {
            return obj == null ? null : new GeocodingResult(obj);
        }

        #endregion

    }

}