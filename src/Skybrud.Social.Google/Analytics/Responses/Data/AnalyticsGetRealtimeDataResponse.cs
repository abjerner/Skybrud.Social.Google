using Skybrud.Social.Google.Analytics.Objects.Data;
using Skybrud.Social.Http;

namespace Skybrud.Social.Google.Analytics.Responses.Data {

    /// <summary>
    /// Class representing the response of a request to get Analytics realtime data.
    /// </summary>
    public class AnalyticsGetRealtimeDataResponse : AnalyticsResponse<AnalyticsDataCollection> {
        
        #region Constructors

        private AnalyticsGetRealtimeDataResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, AnalyticsDataCollection.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <code>AnalyticsGetDataResponse</code>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns></returns>
        public static AnalyticsGetRealtimeDataResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new AnalyticsGetRealtimeDataResponse(response);
        }

        #endregion

    }

}