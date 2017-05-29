using System;
using Skybrud.Social.Google.Common.OAuth;
using Skybrud.Social.Google.YouTube.Options.Channels;
using Skybrud.Social.Http;

namespace Skybrud.Social.Google.YouTube.Endpoints.Raw {

    /// <summary>
    /// Class representing the raw channels endpoint.
    /// </summary>
    public class YouTubeChannelsRawEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the OAuth client.
        /// </summary>
        public GoogleOAuthClient Client { get; private set; }

        #endregion

        #region Constructors

        internal YouTubeChannelsRawEndpoint(GoogleOAuthClient client) {
            Client = client;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets a list of channels for the authenticated user.
        /// </summary>
        /// <returns>An instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        public SocialHttpResponse GetChannels() {
            return GetChannels(new YouTubeGetChannelListOptions {
                Part = YouTubeChannelParts.Snippet,
                Mine = true
            });
        }

        /// <summary>
        /// Gets a list of channels for the specified <paramref name="username"/>.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <returns>An instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        public SocialHttpResponse GetChannels(string username) {
            return GetChannels(new YouTubeGetChannelListOptions {
                Part = YouTubeChannelParts.Snippet,
                Username = username
            });
        }

        /// <summary>
        /// Gets a list of channels based on the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>An instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        public SocialHttpResponse GetChannels(YouTubeGetChannelListOptions options) {
            if (options == null) throw new ArgumentNullException("options");
            return Client.DoHttpGetRequest("https://www.googleapis.com/youtube/v3/channels", options);
        }

        #endregion

    }

}