using Newtonsoft.Json.Linq;
using Skybrud.Social.Google.Common.Objects;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Social.Google.Places.Objects {
    
    public class PlacesDetailsResult : GoogleApiObject {

        #region Properties

        public PlacesAddressComponent[] AddressComponents { get; private set; }

        public string AdrAddress { get; private set; }

        public string FormattedAddress { get; private set; }

        public PlacesGeometry Geometry { get; private set; }

        public string Icon { get; private set; }

        public string Id { get; private set; }

        public string Name { get; private set; }

        public string PlaceId { get; private set; }

        public string Reference { get; private set; }

        public string Scope { get; private set; }

        public string[] Types { get; private set; }

        public string Url { get; private set; }

        public string Vicinity { get; private set; }

        #endregion

        #region Constructors

        private PlacesDetailsResult(JObject obj) : base(obj) {
            AddressComponents = obj.GetArray("address_components", PlacesAddressComponent.Parse);
            AdrAddress = obj.GetString("adr_address");
            FormattedAddress = obj.GetString("formatted_address");
            Geometry = obj.GetObject("geometry", PlacesGeometry.Parse);
            Icon = obj.GetString("icon");
            Id = obj.GetString("id");
            Name = obj.GetString("name");
            PlaceId = obj.GetString("place_id");
            Reference = obj.GetString("reference");
            Scope = obj.GetString("scope");
            Types = obj.GetStringArray("types");
            Url = obj.GetString("url");
            Vicinity = obj.GetString("vicinity");
        }

        #endregion
        
        #region Static methods
        
        /// <summary>
        /// Gets a user from the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        /// <returns>Returns an instance of <see cref="PlacesDetailsResult"/> representing the place.</returns>
        public static PlacesDetailsResult Parse(JObject obj) {
            return obj == null ? null : new PlacesDetailsResult(obj);
        }

        #endregion

    }

}