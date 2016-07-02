using Newtonsoft.Json.Linq;
using Skybrud.Social.Google.Common.Objects;
using Skybrud.Social.Json.Extensions;

namespace Skybrud.Social.Google.YouTube.Objects.Videos {

    /// <see>
    ///     <cref>https://developers.google.com/youtube/v3/docs/videos/list</cref>
    /// </see>
    public class YouTubeVideoList : GoogleApiResource {

        #region Properties

        public string NextPageToken { get; private set; }

        public string PrevPageToken { get; private set; }

        public YouTubePageInfo PageInfo { get; private set; }

        public YouTubeVideo[] Items { get; private set; }

        #endregion

        #region Constructors

        protected YouTubeVideoList(JObject obj) : base(obj) { }

        #endregion
        
        #region Static methods

        /// <summary>
        /// Gets an instance of <code>YouTubePlaylistItemList</code> from the specified <code>JObject</code>.
        /// </summary>
        /// <param name="obj">The instance of <code>JObject</code> to parse.</param>
        public static YouTubeVideoList Parse(JObject obj) {
            if (obj == null) return null;
            return new YouTubeVideoList(obj) {
                NextPageToken = obj.GetString("nextPageToken"),
                PrevPageToken = obj.GetString("prevPageToken"),
                PageInfo = obj.GetObject("pageInfo", YouTubePageInfo.Parse),
                Items = obj.GetArray("items", YouTubeVideo.Parse)
            };
        }

        #endregion

    }

}