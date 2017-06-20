using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.Google.Common.Models;

namespace Skybrud.Social.Google.YouTube.Models.PlaylistItems {

    /// <see>
    ///     <cref>https://developers.google.com/youtube/v3/docs/playlistItems#snippet.thumbnails</cref>
    /// </see>
    public class YouTubePlaylistItemThumbnail : GoogleApiObject {

        #region Properties

        public string Url { get; private set; }

        public int Width { get; private set; }

        public int Height { get; private set; }

        #endregion

        #region Constructors

        protected YouTubePlaylistItemThumbnail(JObject obj) : base(obj) { }

        #endregion

        #region Static methods

        public static YouTubePlaylistItemThumbnail Parse(JObject obj) {
            if (obj == null) return null;
            return new YouTubePlaylistItemThumbnail(obj) {
                Url = obj.GetString("url"),
                Width = obj.GetInt32("width"),
                Height = obj.GetInt32("height")
            };
        }

        #endregion

    }

}