using Skybrud.Social.Google.Analytics.Objects.WebProperties;
using Skybrud.Social.Http;

namespace Skybrud.Social.Google.Analytics.Responses.Management {

    /// <summary>
    /// Class representing the response of a request to get a list of web properties.
    /// </summary>
    public class AnalyticsGetWebPropertiesResponse : AnalyticsResponse<AnalyticsWebPropertiesResponseBody> {
        
        #region Constructors

        private AnalyticsGetWebPropertiesResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, AnalyticsWebPropertiesResponseBody.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <code>AnalyticsGetWebPropertiesResponse</code>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns></returns>
        public static AnalyticsGetWebPropertiesResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new AnalyticsGetWebPropertiesResponse(response);
        }

        #endregion

    }

}