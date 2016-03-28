using Newtonsoft.Json.Linq;
using Skybrud.Social.Google.Common.Objects;
using Skybrud.Social.Google.Places.Enums;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Social.Google.Places.Objects {
    
    /// <summary>
    /// Class representing the response body of a call to get the details about a place in the Google Places API.
    /// </summary>
    public class PlacesGetDetailsResponseBody : GoogleApiObject {
        
        #region Properties
        
        public PlacesDetailsResult Result { get; private set; }

        public PlacesResponseStatusCode Status { get; private set; }

        #endregion

        #region Constructors

        private PlacesGetDetailsResponseBody(JObject obj) : base(obj) {
            Result = obj.GetObject("result", PlacesDetailsResult.Parse);
            //Status = obj.GetString("status", x => SocialUtils.ParseEnum<PlacesResponseStatusCode>(x.ToLower().Replace("_", "")));
        }

        #endregion
        
        #region Static methods
        
        /// <summary>
        /// Gets a user from the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        /// <returns>Returns an instance of <see cref="PlacesGetDetailsResponseBody"/>.</returns>
        public static PlacesGetDetailsResponseBody Parse(JObject obj) {
            return obj == null ? null : new PlacesGetDetailsResponseBody(obj);
        }

        #endregion

    }

}