using Skybrud.Social.Google.YouTube.Objects.Videos;
using Skybrud.Social.Http;

namespace Skybrud.Social.Google.YouTube.Responses {

    public class YouTubeVideoListResponse : YouTubeResponse<YouTubeVideoList> {

        #region Constructors

        private YouTubeVideoListResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, YouTubeVideoList.Parse);

        }

        #endregion

        #region Static methods

        public static YouTubeVideoListResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new YouTubeVideoListResponse(response);
        }

        #endregion

    }

}