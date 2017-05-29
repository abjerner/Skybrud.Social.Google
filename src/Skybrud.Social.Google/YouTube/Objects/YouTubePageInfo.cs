using Newtonsoft.Json.Linq;
using Skybrud.Social.Google.Common.Objects;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Google.YouTube.Objects {

    public class YouTubePageInfo : GoogleApiObject {

        #region Properties

        public int TotalResults { get; private set; }

        public int ResultsPerPage { get; private set; }

        #endregion

        #region Constructors

        protected YouTubePageInfo(JObject obj) : base(obj) {
            TotalResults = obj.GetInt32("totalResults");
            ResultsPerPage = obj.GetInt32("resultsPerPage");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="YouTubePageInfo"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        /// <returns>Returns an instance of <see cref="YouTubePageInfo"/>.</returns>
        public static YouTubePageInfo Parse(JObject obj) {
            return obj == null ? null : new YouTubePageInfo(obj);
        }

        #endregion

    }

}