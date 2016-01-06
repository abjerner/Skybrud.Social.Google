using Skybrud.Social.Google.Analytics.Objects.Profiles;
using Skybrud.Social.Http;

namespace Skybrud.Social.Google.Analytics.Responses.Management {

    /// <summary>
    /// Class representing the response of a request to get a list of profiles.
    /// </summary>
    public class AnalyticsProfilesResponse : AnalyticsResponse<AnalyticsProfilesResponseBody> {
        
        #region Constructors

        private AnalyticsProfilesResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, AnalyticsProfilesResponseBody.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <code>AnalyticsProfilesResponse</code>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns></returns>
        public static AnalyticsProfilesResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new AnalyticsProfilesResponse(response);
        }

        #endregion

    }

}