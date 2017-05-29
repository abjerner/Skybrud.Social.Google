using Skybrud.Social.Google.YouTube.Objects.Channels;
using Skybrud.Social.Http;

namespace Skybrud.Social.Google.YouTube.Responses.Channels {

    /// <summary>
    /// Class representing the response for getting a list of channels.
    /// </summary>
    public class YouTubeGetChannelListResponse : YouTubeResponse<YouTubeChannelList> {

        #region Constructors

        private YouTubeGetChannelListResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, YouTubeChannelList.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="response"/> into an instance of <see cref="YouTubeGetChannelListResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        public static YouTubeGetChannelListResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new YouTubeGetChannelListResponse(response);
        }

        #endregion

    }

}