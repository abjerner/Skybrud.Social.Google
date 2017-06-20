using System;
using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.Google.Common.Models;

namespace Skybrud.Social.Google.YouTube.Models.PlaylistItems {

    /// <summary>
    /// Class representing the <code>snippet</code> object of a YouTube playlist item.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.google.com/youtube/v3/docs/playlistItems#snippet</cref>
    /// </see> 
    public class YouTubePlaylistItemSnippet : GoogleApiObject {

        #region Properties
        
        /// <summary>
        /// gets the timestamp for when the item was added to the playlist.
        /// </summary>
        public DateTime PublishedAt { get; private set; }

        /// <summary>
        /// Gets the ID of the parent YouTube channel.
        /// </summary>
        public string ChannelId { get; private set; }

        /// <summary>
        /// Gets the title of the playlist item.
        /// </summary>
        public string Title { get; private set; }

        /// <summary>
        /// Gets the description of the playlist item.
        /// </summary>
        public string Description { get; private set; }

        /// <summary>
        /// Gets a collection of thumbnails of the playlist item.
        /// </summary>
        public YouTubePlaylistItemThumbnails Thumbnails { get; private set; }
        
        /// <summary>
        /// Gets the title of the parent YouTube channel.
        /// </summary>
        public string ChannelTitle { get; private set; }

        /// <summary>
        /// Gets the title of the parent YouTube playlist.
        /// </summary>
        public string PlaylistId { get; private set; }

        /// <summary>
        /// Gets the order in which the item appears in the parent playlist. The value uses a zero-based index, so the
        /// first item has a position of <code>0</code>, the second item has a position of <code>1</code>, and so forth.
        /// </summary>
        public int Position { get; private set; }

        public YouTubePlaylistItemResourceId ResourceId { get; private set; }

        #endregion
        
        #region Constructors

        private YouTubePlaylistItemSnippet(JObject obj) : base(obj) {
            PublishedAt = obj.GetDateTime("publishedAt");
            ChannelId = obj.GetString("channelId");
            Title = obj.GetString("title");
            Description = obj.GetString("description");
            Thumbnails = obj.GetObject("thumbnails", YouTubePlaylistItemThumbnails.Parse);
            ChannelTitle = obj.GetString("channelTitle");
            PlaylistId = obj.GetString("playlistId");
            Position = obj.GetInt32("position");
            ResourceId = obj.GetObject("resourceId", YouTubePlaylistItemResourceId.Parse);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets an instance of <see cref="YouTubePlaylistItemSnippet"/> from the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        /// <returns>Returns the instance of <see cref="YouTubePlaylistItemSnippet"/>.</returns>
        public static YouTubePlaylistItemSnippet Parse(JObject obj) {
            return obj == null ? null : new YouTubePlaylistItemSnippet(obj);
        }

        #endregion

    }

}