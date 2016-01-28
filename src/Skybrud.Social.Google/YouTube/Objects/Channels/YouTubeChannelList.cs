using Newtonsoft.Json.Linq;
using Skybrud.Social.Google.Common.Objects;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Social.Google.YouTube.Objects.Channels {

    /// <see>
    ///     <cref>https://developers.google.com/youtube/v3/docs/channels/list</cref>
    /// </see>
    public class YouTubeChannelList : GoogleApiResource {

        #region Properties

        public YouTubePageInfo PageInfo { get; private set; }

        public YouTubeChannel[] Items { get; private set; }

        #endregion

        #region Constructors

        protected YouTubeChannelList(JObject obj) : base(obj) { }

        #endregion
        
        #region Static methods

        /// <summary>
        /// Gets an instance of <code>YouTubeChannelList</code> from the specified <code>JObject</code>.
        /// </summary>
        /// <param name="obj">The instance of <code>JObject</code> to parse.</param>
        public static YouTubeChannelList Parse(JObject obj) {
            if (obj == null) return null;
            return new YouTubeChannelList(obj) {
                PageInfo = obj.GetObject("pageInfo", YouTubePageInfo.Parse),
                Items = obj.GetArray("items", YouTubeChannel.Parse)
            };
        }

        #endregion

    }

}