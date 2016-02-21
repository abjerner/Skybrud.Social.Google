using Skybrud.Social.Google.Analytics.Objects.Profiles;
using Skybrud.Social.Http;

namespace Skybrud.Social.Google.Analytics.Responses.Management {

    /// <summary>
    /// Class representing the response of a request to get a list of profiles.
    /// </summary>
    public class AnalyticsGetProfilesResponse : AnalyticsResponse<AnalyticsProfilesCollection> {
        
        #region Constructors

        private AnalyticsGetProfilesResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, AnalyticsProfilesCollection.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <code>AnalyticsGetProfilesResponse</code>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns></returns>
        public static AnalyticsGetProfilesResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new AnalyticsGetProfilesResponse(response);
        }

        #endregion

    }

}