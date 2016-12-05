using System;
using Newtonsoft.Json.Linq;
using Skybrud.Social.Google.Common.Objects;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Google.YouTube.Objects.PlaylistItems {

    /// <summary>
    /// Class representing a YouTube playlist item.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.google.com/youtube/v3/docs/playlistItems#resource</cref>
    /// </see>
    public class YouTubePlaylistItem : GoogleApiResource {

        #region Properties

        /// <summary>
        /// Gets or sets the ID of the playlist item.
        /// </summary>
        public string Id { get; private set; }

        /// <summary>
        /// Gets a reference to the <code>statistics</code> object of the playlist item. 
        /// </summary>
        public YouTubePlaylistItemSnippet Snippet { get; private set; }

        /// <summary>
        /// Gets a reference to the <code>contentDetails</code> object of the playlist item. 
        /// </summary>
        public YouTubePlaylistItemContentDetails ContentDetails { get; private set; }

        /// <summary>
        /// Gets a reference to the <code>status</code> object of the playlist item. 
        /// </summary>
        public YouTubePlaylistItemStatus Status { get; private set; }

        #region Shortcuts

        /// <summary>
        /// Gets the YouTube ID of the video.
        /// </summary>
        public string VideoId {
            get { return Snippet.ResourceId.VideoId; }
        }

        /// <summary>
        /// Gets the title of the YouTube video.
        /// </summary>
        public string Title {
            get { return Snippet.Title; }
        }

        /// <summary>
        /// Gets the publish date of the YouTube video.
        /// </summary>
        public DateTime PublishedAt {
            get { return Snippet.PublishedAt; }
        }

        #endregion

        #endregion

        #region Constructors

        private YouTubePlaylistItem(JObject obj) : base(obj) {
            Id = obj.GetString("id");
            Snippet = obj.GetObject("snippet", YouTubePlaylistItemSnippet.Parse);
            ContentDetails = obj.GetObject("contentDetails", YouTubePlaylistItemContentDetails.Parse);
            Status = obj.GetObject("status", YouTubePlaylistItemStatus.Parse);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets an instance of <see cref="YouTubePlaylistItem"/> from the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        /// <returns>Returns the instance of <see cref="YouTubePlaylistItem"/>.</returns>
        public static YouTubePlaylistItem Parse(JObject obj) {
            if (obj == null) return null;
            return new YouTubePlaylistItem(obj) {
                Id = obj.GetString("id"),
                Snippet = obj.GetObject("snippet", YouTubePlaylistItemSnippet.Parse),
                ContentDetails = obj.GetObject("contentDetails", YouTubePlaylistItemContentDetails.Parse),
                Status = obj.GetObject("status", YouTubePlaylistItemStatus.Parse)
            };
        }

        #endregion

    }

}