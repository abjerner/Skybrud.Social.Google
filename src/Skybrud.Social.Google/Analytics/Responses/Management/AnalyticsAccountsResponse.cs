using Skybrud.Social.Google.Analytics.Objects.Accounts;
using Skybrud.Social.Http;
using Skybrud.Social.Json;

namespace Skybrud.Social.Google.Analytics.Responses.Management {

    /// <summary>
    /// Class representing the response of a request to get a list of Analytics accounts.
    /// </summary>
    public class AnalyticsAccountsResponse : AnalyticsResponse<AnalyticsAccountsResponseBody> {
        
        #region Constructors

        private AnalyticsAccountsResponse(SocialHttpResponse response) : base(response) { }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <code>AnalyticsAccountsResponse</code>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns></returns>
        public static AnalyticsAccountsResponse ParseResponse(SocialHttpResponse response) {

            if (response == null) return null;

            // Parse the raw JSON response
            JsonObject obj = response.GetBodyAsJsonObject();
            // TODO: Should we throw an exception here?
            if (obj == null) return null;

            // Validate the response
            ValidateResponse(response, obj);

            // Initialize the response object
            return new AnalyticsAccountsResponse(response) {
                Body = AnalyticsAccountsResponseBody.Parse(obj)
            };

        }

        #endregion

    }

}