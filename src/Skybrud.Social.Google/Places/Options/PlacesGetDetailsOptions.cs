using System;
using Skybrud.Essentials.Common;
using Skybrud.Social.Http;
using Skybrud.Social.Interfaces.Http;

namespace Skybrud.Social.Google.Places.Options {

    /// <see>
    ///     <cref>https://developers.google.com/places/web-service/details</cref>
    /// </see>
    public class PlacesGetDetailsOptions : IHttpGetOptions {

        #region Properties

        /// <summary>
        /// Gets or sets the ID of the place to retrieve details about.
        /// </summary>
        public string PlaceId { get; set; }

        /// <summary>
        /// Optional: Gets or sets the language code, indicating in which language the results should be returned, if
        /// possible. See the <a href="https://developers.google.com/maps/faq#languagesupport">list of supported
        /// languages</a> and their codes.
        /// </summary>
        public string Language { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance with default options.
        /// </summary>
        public PlacesGetDetailsOptions() { }

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="placeId"/>.
        /// </summary>
        /// <param name="placeId">The ID of the place.</param>
        public PlacesGetDetailsOptions(string placeId) {
            PlaceId = placeId;
        }
        
        #endregion

        public IHttpQueryString GetQueryString() {
            if (String.IsNullOrWhiteSpace(PlaceId)) throw new PropertyNotSetException("PlaceId");
            SocialHttpQueryString query = new SocialHttpQueryString();
            if (!String.IsNullOrWhiteSpace(PlaceId)) query.Add("placeid", PlaceId);
            if (!String.IsNullOrWhiteSpace(Language)) query.Add("language", Language);
            return query;
        }
    
    }

}