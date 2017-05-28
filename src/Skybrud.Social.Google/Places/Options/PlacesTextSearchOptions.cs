using System;
using System.Globalization;
using Skybrud.Essentials.Common;
using Skybrud.Essentials.Locations;
using Skybrud.Social.Google.Places.Enums;
using Skybrud.Social.Http;
using Skybrud.Social.Interfaces.Http;

namespace Skybrud.Social.Google.Places.Options {

    /// <see>
    ///     <cref>https://developers.google.com/places/web-service/search#TextSearchRequests</cref>
    /// </see>
    public class PlacesTextSearchOptions : IHttpGetOptions {

        #region Properties

        /// <summary>
        /// Required: Gets or sets the text string on which to search, for example: <code>restaurant</code> or
        /// <code>123 Main Street</code>. The Google Places service will return candidate matches based on this string
        /// and order the results based on their perceived relevance. This parameter becomes optional if the
        /// <see cref="Type"/> parameter is also used in the search request.
        /// </summary>
        public string Query { get; set; }

        /// <summary>
        /// Optional: Gets or sets the latitude/longitude around which to retrieve place information. If you specify a
        /// <see cref="Location"/> parameter, you must also specify a <see cref="Radius"/> parameter.
        /// </summary>
        public ILocation Location { get; set; }

        /// <summary>
        /// Required: Gets or sets the distance (in meters) within which to bias place results. The maximum allowed
        /// radius is <code>50000</code> meters. Results inside of this region will be ranked higher than results
        /// outside of the search circle; however, prominent results from outside of the search radius may be included.
        /// </summary>
        public int Radius { get; set; }

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
        /// Gets or sets the type of the places that should be returned by the search.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets a page token from a from a previously run search to return the next 20 results. Setting a
        /// <see cref="PageToken"/> parameter will execute a search with the same parameters used previously — all
        /// parameters other than <see cref="PageToken"/> will be ignored.
        /// </summary>
        public string PageToken { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance with default options.
        /// </summary>
        public PlacesTextSearchOptions() {
            Location = new EssentialsLocation();
        }

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="query"/>.
        /// </summary>
        public PlacesTextSearchOptions(string query) {
            Query = query;
            Location = new EssentialsLocation();
        }
        
        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="query"/>, <paramref name="latitude"/>, <paramref name="longitude"/> and <paramref name="radius"/>.
        /// </summary>
        /// <param name="query">The text string to search for.</param>
        /// <param name="latitude">The latitude of the center location the search should be based on.</param>
        /// <param name="longitude">The longitude of the center location the search should be based on.</param>
        /// <param name="radius">The distance (in meters) within which to return place results. The maximum allowed
        /// radius is <code>50000</code> meters.</param>
        public PlacesTextSearchOptions(string query, double latitude, double longitude, int radius) {

            Query = query;
            Location = new EssentialsLocation(latitude, longitude);
            Radius = radius;
        }

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="query"/>, <paramref name="location"/> and <paramref name="radius"/>.
        /// </summary>
        /// <param name="query">The text string to search for.</param>
        /// <param name="location">The center location the search should be based on.</param>
        /// <param name="radius">The distance (in meters) within which to return place results. The maximum allowed
        /// radius is <code>50000</code> meters.</param>
        public PlacesTextSearchOptions(string query, ILocation location, int radius) {
            Query = query;
            Location = location;
            Radius = radius;
        }
        
        #endregion

        public IHttpQueryString GetQueryString() {

            if (Location == null) throw new PropertyNotSetException("Location");

            SocialHttpQueryString query = new SocialHttpQueryString();

            if (!String.IsNullOrWhiteSpace(Query)) query.Add("query", Query);
            query.Add("location", String.Format(CultureInfo.InvariantCulture, "{0},{1}", Location.Latitude, Location.Longitude));
            if (Radius > 0) query.Add("radius", Radius);
            if (!String.IsNullOrWhiteSpace(Language)) query.Add("language", Language);
            if (MinPrice != PlacesPriceLevel.Unspecified) query.Add("minprice", (int) MinPrice - 1);
            if (MaxPrice != PlacesPriceLevel.Unspecified) query.Add("maxprice", (int) MaxPrice - 1);
            if (!String.IsNullOrWhiteSpace(Type)) query.Add("type", Type);
            if (!String.IsNullOrWhiteSpace(PageToken)) query.Add("pagetoken", PageToken);

            return query;

        }
    
    }

}