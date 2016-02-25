using System;
using Newtonsoft.Json.Linq;
using Skybrud.Social.Google.Common.Objects;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Social.Google.YouTube.Objects.Channels {

    /// <summary>
    /// Class representing the <code>snippet</code> object of a YouTube channel.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.google.com/youtube/v3/docs/channels#snippet</cref>
    /// </see>
    public class YouTubeChannelSnippet : GoogleApiObject {

        #region Properties

        /// <summary>
        /// Gets the title of the channel.
        /// </summary>
        public string Title { get; private set; }

        /// <summary>
        /// Gets the description of the channel.
        /// </summary>
        public string Description { get; private set; }

        /// <summary>
        /// Gets the timestamp for when the channel was published.
        /// </summary>
        public DateTime PublishedAt { get; private set; }

        /// <summary>
        /// Gets a collection of thumbnails of the channel.
        /// </summary>
        public YouTubeChannelThumbnails Thumbnails { get; private set; }

        /// <summary>
        /// Gets a reference to an object containing a localized title and description for the channel or the channel's
        /// title and description in the default language.
        /// </summary>
        public YouTubeChannelLocalized Localized { get; private set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance based on the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="YouTubeChannelSnippet"/> to be parsed.</param>
        protected YouTubeChannelSnippet(JObject obj) : base(obj) {
            Title = obj.GetString("title");
            Description = obj.GetString("description");
            PublishedAt = obj.GetDateTime("publishedAt");
            Thumbnails = obj.GetObject("thumbnails", YouTubeChannelThumbnails.Parse);
            Localized = obj.GetObject("localized", YouTubeChannelLocalized.Parse);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets an instance of <see cref="YouTubeChannelSnippet"/> from the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        /// <returns>Returns the instance of <see cref="YouTubeChannelSnippet"/>.</returns>
        public static YouTubeChannelSnippet Parse(JObject obj) {
            return obj == null ? null : new YouTubeChannelSnippet(obj);
        }

        #endregion

    }

}