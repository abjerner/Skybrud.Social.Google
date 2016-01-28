using Newtonsoft.Json.Linq;
using Skybrud.Social.Google.Common.Objects;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Social.Google.YouTube.Objects.Channels {

    /// <see>
    ///     <cref>https://developers.google.com/youtube/v3/docs/channels#resource</cref>
    /// </see>
    public class YouTubeChannel : GoogleApiResource {

        #region Properties

        public string Id { get; private set; }

        public YouTubeChannelSnippet Snippet { get; private set; }

        public YouTubeChannelStatistics Statistics { get; private set; }

        #endregion

        #region Constructors

        protected YouTubeChannel(JObject obj) : base(obj) { }

        #endregion
        
        #region Static methods

        /// <summary>
        /// Gets an instance of <code>YouTubeChannel</code> from the specified <code>JObject</code>.
        /// </summary>
        /// <param name="obj">The instance of <code>JObject</code> to parse.</param>
        public static YouTubeChannel Parse(JObject obj) {
            if (obj == null) return null;
            return new YouTubeChannel(obj) {
                Id = obj.GetString("id"),
                Snippet = obj.GetObject("snippet", YouTubeChannelSnippet.Parse),
                Statistics = obj.GetObject("statistics", YouTubeChannelStatistics.Parse)
            };
        }

        #endregion

    }

}