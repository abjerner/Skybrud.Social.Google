namespace Skybrud.Social.Google.YouTube.Options.Videos {

    /// <see>
    ///     <cref>https://developers.google.com/youtube/v3/docs/videos/list#part</cref>
    /// </see>
    public class YouTubeVideoParts {

        #region Properties

        /// <summary>
        /// Indicates that the response from the YouTube API should include the ID of the video.
        /// </summary>
        public static readonly YouTubeVideoPart Id = new YouTubeVideoPart("id");

        /// <summary>
        /// Indicates that the response from the YouTube API should include the <code>snippet</code> object of the video.
        /// </summary>
        public static readonly YouTubeVideoPart Snippet = new YouTubeVideoPart("snippet");
        
        /// <summary>
        /// Indicates that the response from the YouTube API should include the <code>contentDetails</code> object of the video.
        /// </summary>
        public static readonly YouTubeVideoPart ContentDetails = new YouTubeVideoPart("contentDetails");

        /// <summary>
        /// Indicates that the response from the YouTube API should include the <code>fileDetails</code> object of the video.
        /// </summary>
        public static readonly YouTubeVideoPart FileDetails = new YouTubeVideoPart("fileDetails");

        /// <summary>
        /// Indicates that the response from the YouTube API should include the <code>liveStreamingDetails</code> object of the video.
        /// </summary>
        public static readonly YouTubeVideoPart LiveStreamingDetails = new YouTubeVideoPart("liveStreamingDetails");

        /// <summary>
        /// Indicates that the response from the YouTube API should include the <code>localizations</code> object of the video.
        /// </summary>
        public static readonly YouTubeVideoPart Localizations = new YouTubeVideoPart("localizations");

        /// <summary>
        /// Indicates that the response from the YouTube API should include the <code>processingDetails</code> object of the video.
        /// </summary>
        public static readonly YouTubeVideoPart ProcessingDetails = new YouTubeVideoPart("processingDetails");

        /// <summary>
        /// Indicates that the response from the YouTube API should include the <code>recordingDetails</code> object of the video.
        /// </summary>
        public static readonly YouTubeVideoPart RecordingDetails = new YouTubeVideoPart("recordingDetails");

        /// <summary>
        /// Indicates that the response from the YouTube API should include the <code>statistics</code> object of the video.
        /// </summary>
        public static readonly YouTubeVideoPart Statistics = new YouTubeVideoPart("statistics");

        /// <summary>
        /// Indicates that the response from the YouTube API should include the <code>status</code> object of the video.
        /// </summary>
        public static readonly YouTubeVideoPart Status = new YouTubeVideoPart("status");

        /// <summary>
        /// Indicates that the response from the YouTube API should include the <code>suggestions</code> object of the video.
        /// </summary>
        public static readonly YouTubeVideoPart Suggestions = new YouTubeVideoPart("suggestions");

        /// <summary>
        /// Indicates that the response from the YouTube API should include the <code>topicDetails</code> object of the video.
        /// </summary>
        public static readonly YouTubeVideoPart TopicDetails = new YouTubeVideoPart("topicDetails");
        
        /// <summary>
        /// Gets a collection of all parts available for a YouTube video.
        /// </summary>
        public static readonly YouTubeVideoPartsCollection All = new YouTubeVideoPartsCollection(
            Id, Snippet, ContentDetails, FileDetails, LiveStreamingDetails, Localizations, ProcessingDetails,
            RecordingDetails, Statistics, Status, Suggestions, TopicDetails
        );

        /// <summary>
        /// Gets an array of <see cref="YouTubeVideoPart"/> representing all parts available for a YouTube video.
        /// </summary>
        public static YouTubeVideoPart[] Values {
            get { return All.ToArray(); }
        }

        #endregion
    
    }

}