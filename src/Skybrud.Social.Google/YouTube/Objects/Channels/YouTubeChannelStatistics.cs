using Newtonsoft.Json.Linq;
using Skybrud.Social.Google.Objects;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Social.Google.YouTube.Objects.Channels {

    /// <see>
    ///     <cref>https://developers.google.com/youtube/v3/docs/channels#statistics</cref>
    /// </see>
    public class YouTubeChannelStatistics : GoogleApiObject {

        #region Properties

        public long ViewCount { get; private set; }

        public long CommentCount { get; private set; }

        public long SubscriberCount { get; private set; }

        public bool HiddenSubscriberCount { get; private set; }

        public long VideoCount { get; private set; }

        #endregion

        #region Constructors

        protected YouTubeChannelStatistics(JObject obj) : base(obj) { }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets an instance of <code>YouTubeChannelStatistics</code> from the specified <code>JObject</code>.
        /// </summary>
        /// <param name="obj">The instance of <code>JObject</code> to parse.</param>
        public static YouTubeChannelStatistics Parse(JObject obj) {
            if (obj == null) return null;
            return new YouTubeChannelStatistics(obj) {
                ViewCount = obj.GetInt64("viewCount"),
                CommentCount = obj.GetInt64("commentCount"),
                SubscriberCount = obj.GetInt64("subscriberCount"),
                HiddenSubscriberCount = obj.GetBoolean("hiddenSubscriberCount"),
                VideoCount = obj.GetInt64("videoCount")
            };
        }

        #endregion

    }

}