using Newtonsoft.Json.Linq;
using Skybrud.Social.Google.Common.Objects;
using Skybrud.Social.Json.Extensions;

namespace Skybrud.Social.Google.YouTube.Objects.Channels {

    /// <summary>
    /// Class representing the <code>statistics</code> object of a TouTube channel.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.google.com/youtube/v3/docs/channels#statistics</cref>
    /// </see>
    public class YouTubeChannelStatistics : GoogleApiObject {

        #region Properties

        /// <summary>
        /// Gets the number of times the channel has been viewed.
        /// </summary>
        public long ViewCount { get; private set; }

        /// <summary>
        /// Gets the number of comments the channel has received.
        /// </summary>
        public long CommentCount { get; private set; }

        /// <summary>
        /// Gets the number of subscribers of the channel.
        /// </summary>
        public long SubscriberCount { get; private set; }

        /// <summary>
        /// Gets whether the subscriber count of the channel is hidden or publicly visible.
        /// </summary>
        public bool HiddenSubscriberCount { get; private set; }

        /// <summary>
        /// Gets the number of videos uploaded to the channel.
        /// </summary>
        public long VideoCount { get; private set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance based on the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="YouTubeChannelStatistics"/> to be parsed.</param>
        protected YouTubeChannelStatistics(JObject obj) : base(obj) {
            ViewCount = obj.GetInt64("viewCount");
            CommentCount = obj.GetInt64("commentCount");
            SubscriberCount = obj.GetInt64("subscriberCount");
            HiddenSubscriberCount = obj.GetBoolean("hiddenSubscriberCount");
            VideoCount = obj.GetInt64("videoCount");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets an instance of <see cref="YouTubeChannelStatistics"/> from the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        /// <returns>Returns the instance of <see cref="YouTubeChannelStatistics"/>.</returns>
        public static YouTubeChannelStatistics Parse(JObject obj) {
            return obj == null ? null : new YouTubeChannelStatistics(obj);
        }

        #endregion

    }

}