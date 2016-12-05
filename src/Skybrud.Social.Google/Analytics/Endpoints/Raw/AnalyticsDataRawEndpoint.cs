using System;
using Skybrud.Essentials.Common;
using Skybrud.Social.Google.Analytics.Options.Data;
using Skybrud.Social.Google.Common.OAuth;
using Skybrud.Social.Http;

namespace Skybrud.Social.Google.Analytics.Endpoints.Raw {
    
    /// <summary>
    /// Raw implementation of the data endpoint.
    /// </summary>
    public class AnalyticsDataRawEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the Google OAuth client.
        /// </summary>
        public GoogleOAuthClient Client { get; private set; }

        #endregion

        #region Constructors

        internal AnalyticsDataRawEndpoint(GoogleOAuthClient client) {
            Client = client;
        }

        #endregion

        #region Member methods
        
        /// <summary>
        /// Gets historical data based on the specified <code>options</code>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>Returns an instance of <see cref="SocialHttpResponse"/> representing the response.</returns>
        public SocialHttpResponse GetData(AnalyticsGetDataOptions options) {
            if (options == null) throw new ArgumentNullException("options");
            if (String.IsNullOrWhiteSpace(options.ProfileId)) throw new PropertyNotSetException("options.ProfileId");
            return Client.DoHttpGetRequest("https://www.googleapis.com/analytics/v3/data/ga", options);
        }

        /// <summary>
        /// Gets realtime data based on the specified <code>options</code>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>Returns an instance of <see cref="SocialHttpResponse"/> representing the response.</returns>
        public SocialHttpResponse GetRealtimeData(AnalyticsGetRealtimeDataOptions options) {
            if (options == null) throw new ArgumentNullException("options");
            if (String.IsNullOrWhiteSpace(options.ProfileId)) throw new PropertyNotSetException("options.ProfileId");
            return Client.DoHttpGetRequest("https://www.googleapis.com/analytics/v3/data/realtime", options);
        }
        
        #endregion

    }

}