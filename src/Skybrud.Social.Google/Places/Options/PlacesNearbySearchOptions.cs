using System;
using System.Globalization;
using Skybrud.Essentials.Common;
using Skybrud.Essentials.Locations;
using Skybrud.Essentials.Strings;
using Skybrud.Social.Google.Places.Enums;
using Skybrud.Social.Http;
using Skybrud.Social.Interfaces.Http;

namespace Skybrud.Social.Google.Places.Options {

    /// <see>
    ///     <cref>https://developers.google.com/places/web-service/search#PlaceSearchRequests</cref>
    /// </see>
    public class PlacesNearbySearchOptions : IHttpGetOptions {

        #region Properties

        /// <summary>
        /// Required: Gets or sets the latitude/longitude around which to retrieve place information.
        /// </summary>
        public ILocation Location { get; set; }

        /// <summary>
        /// Required: Gets or sets the distance (in meters) within which to return place results. The maximum allowed radius is <code>50000</code> meters.
        /// </summary>
        public int Radius { get; set; }

        /// <summary>
        /// Optional: Gets or sets a term to be matched against all content that Google has indexed for this place, including but not limited to name, type, and address, as well as customer reviews and other third-party content.
        /// </summary>
        public string Keyword { get; set; }

        /// <summary>
        /// Optional: Gets or sets the language code, indicating in which language the results should be returned, if
        /// possible. See the <a href="https://developers.google.com/maps/faq#languagesupport">list of supported
        /// languages</a> and their codes.
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// Optional: Gets or sets the minimum price level of the places that should be returned by the search.
        /// </summary>
        public PlacesPriceLevel MinPrice { get; set; }

        /// <summary>
        /// Optional: Gets or sets the maximum price level of the places that should be returned by the search.
        /// </summary>
        public PlacesPriceLevel MaxPrice { get; set; }

        /// <summary>
        /// Gets or sets a term to be matched against all content that Google has indexed for this place. Equivalent to
        /// <see cref="Keyword"/>. The <see cref="Name"/> field is no longer restricted to place names. Values in this
        /// field are combined with values in the <see cref="Keyword"/> field and passed as part of the same search string.
        /// 
        /// Google recommends using only the <see cref="Keyword"/> parameter for all search terms.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Specifies the order in which results are listed. Note that <see cref="RankBy"/> must not be included if
        /// <see cref="Radius"/> is specified. Possible values are:
        /// 
        /// <strong>prominence</strong> (default). This option sorts results based on their importance. Ranking will
        /// favor prominent places within the specified area. Prominence can be affected by a place's ranking in
        /// Google's index, global popularity, and other factors.
        /// 
        /// <strong>distance</strong>. This option biases search results in ascending order by their distance from the
        /// specified location. When <see cref="PlacesRankBy.Distance"/> is specified, one or more of
        /// <see cref="Keyword"/>, <see cref="Name"/>, or <see cref="Type"/> is required.
        /// </summary>
        public PlacesRankBy RankBy { get; set; }

        /// <summary>
        /// Gets or sets the type of the places that should be returned by the search.
        /// </summary>
        public string Type { get; set; }

        public string PageToken { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance with default options.
        /// </summary>
        public PlacesNearbySearchOptions() {
            Location = new EssentialsLocation();
        }

        /// <summary>
        /// Initializes a new instance with the specified <paramref name="latitude"/>, <paramref name="longitude"/> and <paramref name="radius"/>.
        /// </summary>
        /// <param name="latitude">The latitude of the center location the search should be based on.</param>
        /// <param name="longitude">The longitude of the center location the search should be based on.</param>
        /// <param name="radius">The distance (in meters) within which to return place results. The maximum allowed
        /// radius is <code>50000</code> meters.</param>
        public PlacesNearbySearchOptions(double latitude, double longitude, int radius) {
            Location = new EssentialsLocation(latitude, longitude);
            Radius = radius;
        }

        /// <summary>
        /// Initializes a new instance with the specified <paramref name="location"/> and <paramref name="radius"/>.
        /// </summary>
        /// <param name="location">The center location the search should be based on.</param>
        /// <param name="radius">The distance (in meters) within which to return place results. The maximum allowed
        /// radius is <code>50000</code> meters.</param>
        public PlacesNearbySearchOptions(ILocation location, int radius) {
            if (location == null) throw new ArgumentNullException("location");
            Location = location;
            Radius = radius;
        }

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="pageToken"/>.
        /// </summary>
        /// <param name="pageToken">The page token for the next page.</param>
        public PlacesNearbySearchOptions(string pageToken) {
            Location = new EssentialsLocation();
            PageToken = pageToken;
        }

        #endregion

        public IHttpQueryString GetQueryString() {

            if (Location == null) throw new PropertyNotSetException("Location");

            SocialHttpQueryString query = new SocialHttpQueryString();

            // Add required parameters
            query.Add("location", String.Format(CultureInfo.InvariantCulture, "{0},{1}", Location.Latitude, Location.Longitude));
            if (Radius > 0) query.Add("radius", Radius);

            // Add optional parameters (if specified)
            if (!String.IsNullOrWhiteSpace(Keyword)) query.Add("keyword", Keyword);
            if (!String.IsNullOrWhiteSpace(Language)) query.Add("language", Language);
            if (MinPrice != PlacesPriceLevel.Unspecified) query.Add("minprice", (int) MinPrice - 1);
            if (MaxPrice != PlacesPriceLevel.Unspecified) query.Add("maxprice", (int) MaxPrice - 1);
            if (!String.IsNullOrWhiteSpace(Name)) query.Add("name", Name);
            query.Add("rankby", StringUtils.ToCamelCase(RankBy));
            if (!String.IsNullOrWhiteSpace(Type)) query.Add("type", Type);
            if (!String.IsNullOrWhiteSpace(PageToken)) query.Add("pagetoken", PageToken);

            return query;

        }
    
    }

}