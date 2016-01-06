using Skybrud.Social.Google.Analytics.Objects.Data;
using Skybrud.Social.Http;

namespace Skybrud.Social.Google.Analytics.Responses.Data {

    /// <summary>
    /// Class representing the response of a request to get Analytics realtime data.
    /// </summary>
    public class AnalyticsRealtimeDataResponse : AnalyticsResponse<AnalyticsDataResponseBody> {
        
        #region Constructors

        private AnalyticsRealtimeDataResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, AnalyticsDataResponseBody.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <code>AnalyticsDataResponse</code>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns></returns>
        public static AnalyticsRealtimeDataResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new AnalyticsRealtimeDataResponse(response);
        }

        #endregion

    }

}