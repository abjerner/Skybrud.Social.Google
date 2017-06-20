using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.Google.Common.Models;

namespace Skybrud.Social.Google.YouTube.Models.Videos {

    /// <summary>
    /// Class representing a YouTube video:
    /// </summary>
    /// <see>
    ///     <cref>https://developers.google.com/youtube/v3/docs/videos#resource</cref>
    /// </see>
    public class YouTubeVideo : GoogleApiResource {

        #region Properties

        /// <summary>
        /// Gets the ID of the video.
        /// </summary>
        public string Id { get; private set; }

        public YouTubeVideoSnippet Snippet { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="Snippet"/> property was included in the response.
        /// </summary>
        public bool HasSnippet {
            get { return Snippet != null; }
        }

        public YouTubeVideoContentDetails ContentDetails { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="ContentDetails"/> property was included in the response.
        /// </summary>
        public bool HasContentDetails {
            get { return ContentDetails != null; }
        }

        public YouTubeVideoStatus Status { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="Status"/> property was included in the response.
        /// </summary>
        public bool HasStatus {
            get { return Status != null; }
        }

        public YouTubeVideoStatistics Statistics { get; private set; }

        /// <summary>
        /// Gets whether the <see cref="Statistics"/> property was included in the response.
        /// </summary>
        public bool HasStatistics {
            get { return Statistics != null; }
        }

        #endregion

        #region Constructors

        private YouTubeVideo(JObject obj) : base(obj) {
            Id = obj.GetString("id");
            Snippet = obj.GetObject("snippet", YouTubeVideoSnippet.Parse);
            ContentDetails = obj.GetObject("contentDetails", YouTubeVideoContentDetails.Parse);
            Status = obj.GetObject("status", YouTubeVideoStatus.Parse);
            Statistics = obj.GetObject("statistics", YouTubeVideoStatistics.Parse);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="YouTubeVideo"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        /// <returns>An instance of <see cref="YouTubeVideo"/>.</returns>
        public static YouTubeVideo Parse(JObject obj) {
            return obj == null ? null : new YouTubeVideo(obj);
        }

        #endregion
    
    }

}