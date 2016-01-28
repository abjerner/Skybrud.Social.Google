using Skybrud.Social.Google.Common.OAuth;

namespace Skybrud.Social.Google.Analytics.Endpoints.Raw {

    /// <summary>
    /// Raw implementation of the Analytics endpoint.
    /// </summary>
    public class AnalyticsRawEndpoint {

        protected const string ManagementUrl = "https://www.googleapis.com/analytics/v3/management/";

        #region Properties

        /// <summary>
        /// Gets a reference to the Google OAuth client.
        /// </summary>
        public GoogleOAuthClient Client { get; private set; }

        /// <summary>
        /// Gets a reference to the raw management endpoint.
        /// </summary>
        public AnalyticsManagementRawEndpoint Management { get; private set; }

        /// <summary>
        /// Gets a reference to the raw data endpoint.
        /// </summary>
        public AnalyticsDataRawEndpoint Data { get; private set; }

        #endregion

        #region Constructors

        internal AnalyticsRawEndpoint(GoogleOAuthClient client) {
            Client = client;
            Management = new AnalyticsManagementRawEndpoint(client);
            Data = new AnalyticsDataRawEndpoint(client);
        }

        #endregion

    }

}