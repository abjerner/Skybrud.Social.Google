using System;
using Newtonsoft.Json.Linq;
using Skybrud.Social.Google.Common.Objects;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Google.YouTube.Objects.Playlists {

    /// <see>
    ///     <cref>https://developers.google.com/youtube/v3/docs/playlists#snippet</cref>
    /// </see>
    public class YouTubePlaylistSnippet : GoogleApiObject {

        #region Properties

        public DateTime PublishedAt { get; private set; }
        
        public string ChannelId { get; private set; }
        
        public string ChannelTitle { get; private set; }
        
        public string Title { get; private set; }
        
        public string Description { get; private set; }

        #endregion

        #region Constructor

        protected YouTubePlaylistSnippet(JObject obj) : base(obj) { }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets an instance of <code>YouTubePlaylistSnippet</code> from the specified <code>JObject</code>.
        /// </summary>
        /// <param name="obj">The instance of <code>JObject</code> to parse.</param>
        public static YouTubePlaylistSnippet Parse(JObject obj) {
            if (obj == null) return null;
            return new YouTubePlaylistSnippet(obj) {
                ChannelId = obj.GetString("channelId"),
                ChannelTitle = obj.GetString("channelTitle"),
                PublishedAt = obj.GetDateTime("publishedAt"),
                Title = obj.GetString("title"),
                Description = obj.GetString("description")
            };
        }

        #endregion

    }

}