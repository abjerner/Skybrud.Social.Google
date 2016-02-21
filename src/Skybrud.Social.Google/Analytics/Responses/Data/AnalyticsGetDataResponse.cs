using Skybrud.Social.Google.Analytics.Objects.Data;
using Skybrud.Social.Http;

namespace Skybrud.Social.Google.Analytics.Responses.Data {

    /// <summary>
    /// Class representing the response of a request to get Analytics data.
    /// </summary>
    public class AnalyticsGetDataResponse : AnalyticsResponse<AnalyticsGetDataResponseBody> {
        
        #region Constructors

        private AnalyticsGetDataResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, AnalyticsGetDataResponseBody.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <code>AnalyticsGetDataResponse</code>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        public static AnalyticsGetDataResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new AnalyticsGetDataResponse(response);
        }

        #endregion

    }

}