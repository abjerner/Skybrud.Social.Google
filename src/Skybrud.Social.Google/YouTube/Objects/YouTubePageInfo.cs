using Newtonsoft.Json.Linq;
using Skybrud.Social.Google.Common.Objects;
using Skybrud.Social.Json.Extensions;

namespace Skybrud.Social.Google.YouTube.Objects {

    public class YouTubePageInfo : GoogleApiObject {

        #region Properties

        public int TotalResults { get; private set; }

        public int ResultsPerPage { get; private set; }

        #endregion

        #region Constructors

        protected YouTubePageInfo(JObject obj) : base(obj) { }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets an instance of <code>YouTubePageInfo</code> from the specified <code>JObject</code>.
        /// </summary>
        /// <param name="obj">The instance of <code>JObject</code> to parse.</param>
        public static YouTubePageInfo Parse(JObject obj) {
            if (obj == null) return null;
            return new YouTubePageInfo(obj) {
                TotalResults = obj.GetInt32("totalResults"),
                ResultsPerPage = obj.GetInt32("resultsPerPage")
            };
        }

        #endregion

    }

}