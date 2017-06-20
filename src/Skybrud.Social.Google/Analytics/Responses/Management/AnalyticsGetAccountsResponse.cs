using Skybrud.Social.Google.Analytics.Models.Accounts;
using Skybrud.Social.Http;

namespace Skybrud.Social.Google.Analytics.Responses.Management {

    /// <summary>
    /// Class representing the response of a request to get a list of Analytics accounts.
    /// </summary>
    public class AnalyticsGetAccountsResponse : AnalyticsResponse<AnalyticsAccountsCollection> {
        
        #region Constructors

        private AnalyticsGetAccountsResponse(SocialHttpResponse response) : base(response) {

            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, AnalyticsAccountsCollection.Parse);

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <code>AnalyticsGetAccountsResponse</code>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns></returns>
        public static AnalyticsGetAccountsResponse ParseResponse(SocialHttpResponse response) {
            return response == null ? null : new AnalyticsGetAccountsResponse(response);
        }

        #endregion

    }

}