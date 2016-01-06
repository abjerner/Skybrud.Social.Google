using Newtonsoft.Json.Linq;
using Skybrud.Social.Google.Objects;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Social.Google.YouTube.Objects.Videos {

    /// <see>
    ///     <cref>https://developers.google.com/youtube/v3/docs/videos#resource</cref>
    /// </see>
    public class YouTubeVideo : GoogleApiResource {

        #region Properties

        /// <summary>
        /// Gets or sets the ID of the video.
        /// </summary>
        public string Id { get; private set; }

        public YouTubeVideoSnippet Snippet { get; private set; }

        public YouTubeVideoContentDetails ContentDetails { get; private set; }

        public YouTubeVideoStatus Status { get; private set; }

        public YouTubeVideoStatistics Statistics { get; private set; }

        #endregion

        #region Constructors

        private YouTubeVideo(JObject obj) : base(obj) { }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets an instance of <code>YouTubeVideo</code> from the specified <code>JObject</code>.
        /// </summary>
        /// <param name="obj">The instance of <var>JObject</var> to parse.</param>
        public static YouTubeVideo Parse(JObject obj) {
            if (obj == null) return null;
            return new YouTubeVideo(obj) {
                Id = obj.GetString("id"),
                Snippet = obj.GetObject("snippet", YouTubeVideoSnippet.Parse),
                ContentDetails = obj.GetObject("contentDetails", YouTubeVideoContentDetails.Parse),
                Status = obj.GetObject("status", YouTubeVideoStatus.Parse),
                Statistics = obj.GetObject("statistics", YouTubeVideoStatistics.Parse)
            };
        }

        #endregion
    
    }

}
