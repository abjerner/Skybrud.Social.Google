using Newtonsoft.Json.Linq;
using Skybrud.Social.Google.Common.Objects;
using Skybrud.Essentials.Json.Extensions;

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
        /// Gets an instance of <see cref="YouTubeVideo"/> from the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
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
