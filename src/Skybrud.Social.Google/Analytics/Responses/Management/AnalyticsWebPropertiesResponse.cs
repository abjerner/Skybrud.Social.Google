using Skybrud.Social.Google.Analytics.Objects.WebProperties;
using Skybrud.Social.Http;

namespace Skybrud.Social.Google.Analytics.Responses.Management {

    /// <summary>
    /// Class representing the response of a request to get a list of web properties.
    /// </summary>
    public class AnalyticsWebPropertiesResponse : AnalyticsResponse<AnalyticsWebPropertiesResponseBody> {
        
        #region Constructors

        private AnalyticsWebPropertiesResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, AnalyticsWebPropertiesResponseBody.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <code>AnalyticsWebPropertiesResponse</code>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns></returns>
        public static AnalyticsWebPropertiesResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new AnalyticsWebPropertiesResponse(response);
        }

        #endregion

    }

}