namespace Skybrud.Social.Google.YouTube.Options.Channels {

    /// <see>
    ///     <cref>https://developers.google.com/youtube/v3/docs/channels/list#part</cref>
    /// </see>
    public class YouTubeChannelParts {

        #region Properties

        /// <summary>
        /// Indicates that the response from the YouTube API should include the ID of the channel.
        /// </summary>
        public static readonly YouTubeChannelPart Id = new YouTubeChannelPart("id");

        /// <summary>
        /// Indicates that the response from the YouTube API should include the <code>snippet</code> object of the channel.
        /// </summary>
        public static readonly YouTubeChannelPart Snippet = new YouTubeChannelPart("snippet");

        /// <summary>
        /// Indicates that the response from the YouTube API should include the <code>contentDetails</code> object of the channel.
        /// </summary>
        public static readonly YouTubeChannelPart ContentDetails = new YouTubeChannelPart("contentDetails");

        /// <summary>
        /// Indicates that the response from the YouTube API should include the <code>statistics</code> object of the channel.
        /// </summary>
        public static readonly YouTubeChannelPart Statistics = new YouTubeChannelPart("statistics");

        /// <summary>
        /// Indicates that the response from the YouTube API should include the <code>status</code> object of the channel.
        /// </summary>
        public static readonly YouTubeChannelPart Status = new YouTubeChannelPart("status");

        /// <summary>
        /// Indicates that the response from the YouTube API should include the <code>topicDetails</code> object of the channel.
        /// </summary>
        public static readonly YouTubeChannelPart TopicDetails = new YouTubeChannelPart("topicDetails");

        /// <summary>
        /// Gets a collection all parts available for a YouTube channel.
        /// </summary>
        public static readonly YouTubeChannelPartsCollection All = new YouTubeChannelPartsCollection(
            Id, Snippet, ContentDetails, Statistics, Status, TopicDetails
        );

        /// <summary>
        /// Gets an array of <see cref="YouTubeChannelPart"/> representing all parts available for a YouTube channel.
        /// </summary>
        public static YouTubeChannelPart[] Values {
            get { return All.ToArray(); }
        }

        #endregion
    
    }

}