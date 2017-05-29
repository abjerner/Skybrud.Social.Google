using Newtonsoft.Json.Linq;
using Skybrud.Social.Google.Common.Objects;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Google.YouTube.Objects.Videos {

    /// <summary>
    /// Class representing the <code>statistics</code> part of a YouTube video.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.google.com/youtube/v3/docs/videos#statistics</cref>
    /// </see>
    public class YouTubeVideoStatistics : GoogleApiObject {

        #region Properties

        public long ViewCount { get; private set; }

        public long LikeCount { get; private set; }

        public long DislikeCount { get; private set; }

        public long FavoriteCount { get; private set; }

        public long CommentCount { get; private set; }

        #endregion

        #region Constructors

        protected YouTubeVideoStatistics(JObject obj) : base(obj) {
            ViewCount = obj.GetInt64("viewCount");
            LikeCount = obj.GetInt64("likeCount");
            DislikeCount = obj.GetInt64("dislikeCount");
            FavoriteCount = obj.GetInt64("favoriteCount");
            CommentCount = obj.GetInt64("commentCount");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="YouTubeVideoStatistics"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        /// <returns>An instance of <see cref="YouTubeVideoStatistics"/>.</returns>
        public static YouTubeVideoStatistics Parse(JObject obj) {
            return obj == null ? null : new YouTubeVideoStatistics(obj);
        }

        #endregion

    }

}