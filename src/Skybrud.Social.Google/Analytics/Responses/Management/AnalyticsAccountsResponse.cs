using Skybrud.Social.Google.Analytics.Objects.Accounts;
using Skybrud.Social.Http;

namespace Skybrud.Social.Google.Analytics.Responses.Management {

    /// <summary>
    /// Class representing the response of a request to get a list of Analytics accounts.
    /// </summary>
    public class AnalyticsAccountsResponse : AnalyticsResponse<AnalyticsAccountsResponseBody> {
        
        #region Constructors

        private AnalyticsAccountsResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, AnalyticsAccountsResponseBody.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <code>AnalyticsAccountsResponse</code>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns></returns>
        public static AnalyticsAccountsResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new AnalyticsAccountsResponse(response);
        }

        #endregion

    }

}