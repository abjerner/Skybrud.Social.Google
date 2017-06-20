using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.Google.Common.Models;

namespace Skybrud.Social.Google.YouTube.Objects.PlaylistItems {

    public class YouTubePlaylistItemList : GoogleApiResource {

        #region Properties

        public string NextPageToken { get; private set; }

        public string PrevPageToken { get; private set; }

        public YouTubePageInfo PageInfo { get; private set; }

        public YouTubePlaylistItem[] Items { get; private set; }

        #endregion

        #region Constructors

        protected YouTubePlaylistItemList(JObject obj) : base(obj) { }

        #endregion
        
        #region Static methods

        /// <summary>
        /// Gets an instance of <code>YouTubePlaylistItemList</code> from the specified <code>JObject</code>.
        /// </summary>
        /// <param name="obj">The instance of <code>JObject</code> to parse.</param>
        public static YouTubePlaylistItemList Parse(JObject obj) {
            if (obj == null) return null;
            return new YouTubePlaylistItemList(obj) {
                NextPageToken = obj.GetString("nextPageToken"),
                PrevPageToken = obj.GetString("prevPageToken"),
                PageInfo = obj.GetObject("pageInfo", YouTubePageInfo.Parse),
                Items = obj.GetArray("items", YouTubePlaylistItem.Parse)
            };
        }

        #endregion

    }

}