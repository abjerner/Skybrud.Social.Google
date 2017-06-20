using System;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.Google.Common.Models;

namespace Skybrud.Social.Google.YouTube.Objects.Videos {

    /// <summary>
    /// Class representing the <code>snippet</code> part of a YouTube video.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.google.com/youtube/v3/docs/videos#snippet</cref>
    /// </see>
    public class YouTubeVideoSnippet : GoogleApiObject {

        #region Properties
        
        /// <summary>
        /// Gets or sets the publish date of the video.
        /// </summary>
        public DateTime PublishedAt { get; private set; }

        /// <summary>
        /// Gets or sets the ID of the parent channel.
        /// </summary>
        public string ChannelId { get; private set; }

        /// <summary>
        /// Gets or sets the title of the YouTube video.
        /// </summary>
        public string Title { get; private set; }

        /// <summary>
        /// Gets or sets the description of the video.
        /// </summary>
        public string Description { get; private set; }

        /// <summary>
        /// Gets or set information about the thumbnails available for the video.
        /// </summary>
        public YouTubeVideoThumbnails Thumbnails { get; private set; }

        /// <summary>
        /// Gets or sets the title of the parent channel.
        /// </summary>
        public string ChannelTitle { get; private set; }

        /// <summary>
        /// Gets an array with all tags of the video.
        /// </summary>
        public string[] Tags { get; private set; }

        public string CategoryId { get; private set; }

        /// <summary>
        /// Gets or sets the "liveBroadcastContent" property.
        /// </summary>
        public YouTubeVideoLiveBroadcastContent LiveBroadcastContent { get; private set; } 

        #endregion
        
        #region Constructors

        private YouTubeVideoSnippet(JObject obj) : base(obj) {

            // Parse the "liveBroadcastContent" property
            YouTubeVideoLiveBroadcastContent broadcast;
            string strBroadcast = obj.GetString("liveBroadcastContent");
            if (!Enum.TryParse(strBroadcast, true, out broadcast)) {
                throw new Exception("Unknown value for liveBroadcastContent \"" + strBroadcast + "\" - please create an issue so it can be fixed https://github.com/abjerner/Skybrud.Social.Google/issues/new");
            }

            // Initialize the snippet object
            PublishedAt = obj.GetDateTime("publishedAt");
            ChannelId = obj.GetString("channelId");
            Title = obj.GetString("title");
            Description = obj.GetString("description");
            Thumbnails = obj.GetObject("thumbnails", YouTubeVideoThumbnails.Parse);
            ChannelTitle = obj.GetString("channelTitle");
            Tags = obj.GetStringArray("tags");
            CategoryId = obj.GetString("categoryId");
            LiveBroadcastContent = broadcast;

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="YouTubeVideoSnippet"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        /// <returns>An instance of <see cref="YouTubeVideoSnippet"/>.</returns>
        public static YouTubeVideoSnippet Parse(JObject obj) {
            return obj == null ? null : new YouTubeVideoSnippet(obj);
        }

        #endregion

    }

}