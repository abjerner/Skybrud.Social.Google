using Newtonsoft.Json.Linq;
using Skybrud.Social.Google.Common.Objects;
using Skybrud.Social.Json.Extensions;

namespace Skybrud.Social.Google.YouTube.Objects.Channels {
    
    /// <summary>
    /// Class representing a YouTube channel.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.google.com/youtube/v3/docs/channels#resource</cref>
    /// </see>
    public class YouTubeChannel : GoogleApiResource {

        #region Properties

        /// <summary>
        /// Gets the ID of the channel.
        /// </summary>
        public string Id { get; private set; }

        /// <summary>
        /// Gets a reference to the <code>snippet</code> object of the channel, which contains details such as the
        /// title, description and thumbnail images of the channel.
        /// </summary>
        public YouTubeChannelSnippet Snippet { get; private set; }

        /// <summary>
        /// Gets a reference to the <code>statistics</code> object of the channel. 
        /// </summary>
        public YouTubeChannelStatistics Statistics { get; private set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance based on the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="YouTubeChannel"/> to be parsed.</param>
        protected YouTubeChannel(JObject obj) : base(obj) {
            Id = obj.GetString("id");
            Snippet = obj.GetObject("snippet", YouTubeChannelSnippet.Parse);
            Statistics = obj.GetObject("statistics", YouTubeChannelStatistics.Parse);
        }

        #endregion
        
        #region Static methods

        /// <summary>
        /// Gets an instance of <see cref="YouTubeChannel"/> from the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        /// <returns>Returns the instance of <see cref="YouTubeChannel"/>.</returns>
        public static YouTubeChannel Parse(JObject obj) {
            return obj == null ? null : new YouTubeChannel(obj);
        }

        #endregion

    }

}