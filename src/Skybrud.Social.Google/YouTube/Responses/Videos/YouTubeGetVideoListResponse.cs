using Skybrud.Social.Google.YouTube.Objects.Videos;
using Skybrud.Social.Http;

namespace Skybrud.Social.Google.YouTube.Responses.Videos {

    /// <summary>
    /// Class representing the response for getting a list of videos.
    /// </summary>
    public class YouTubeGetVideoListResponse : YouTubeResponse<YouTubeVideoList> {

        #region Constructors

        private YouTubeGetVideoListResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, YouTubeVideoList.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="response"/> into an instance of <see cref="YouTubeGetVideoListResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        public static YouTubeGetVideoListResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new YouTubeGetVideoListResponse(response);
        }

        #endregion

    }

}