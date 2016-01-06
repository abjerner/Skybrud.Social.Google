using Skybrud.Social.Google.YouTube.Objects.Channels;
using Skybrud.Social.Http;

namespace Skybrud.Social.Google.YouTube.Responses {

    public class YouTubeChannelListResponse : YouTubeResponse<YouTubeChannelList> {

        #region Constructors

        private YouTubeChannelListResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, YouTubeChannelList.Parse);

        }

        #endregion

        #region Static methods

        public static YouTubeChannelListResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new YouTubeChannelListResponse(response);
        }

        #endregion

    }

}