﻿using System;
using Skybrud.Social.Exceptions;
using Skybrud.Social.Google.Analytics.Options.Management;
using Skybrud.Social.Google.Common.OAuth;
using Skybrud.Social.Http;

namespace Skybrud.Social.Google.Analytics.Endpoints.Raw {
    
    /// <summary>
    /// Raw implementation of the management endpoint.
    /// </summary>
    public class AnalyticsManagementRawEndpoint {

        protected const string ManagementUrl = "https://www.googleapis.com/analytics/v3/management/";

        #region Properties

        /// <summary>
        /// Gets a reference to the Google OAuth client.
        /// </summary>
        public GoogleOAuthClient Client { get; private set; }

        #endregion

        #region Constructors

        internal AnalyticsManagementRawEndpoint(GoogleOAuthClient client) {
            Client = client;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets a list of Analytics accounts of the authenticated user.
        /// </summary>
        /// <returns>Returns an instance of <code>SocialHttpResponse</code> representing the response.</returns>
        public SocialHttpResponse GetAccounts() {
            return GetAccounts(new AnalyticsGetAccountsOptions());
        }

        /// <summary>
        /// Gets a list of Analytics accounts of the authenticated user.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>Returns an instance of <see cref="SocialHttpResponse"/> representing the response.</returns>
        public SocialHttpResponse GetAccounts(AnalyticsGetAccountsOptions options) {
            if (options == null) throw new ArgumentNullException("options");
            return Client.DoHttpGetRequest("https://www.googleapis.com/analytics/v3/management/accounts", options);
        }

        /// <summary>
        /// Gets a list of web properties based on the specified <code>options</code>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>Returns an instance of <see cref="SocialHttpResponse"/> representing the response.</returns>
        public SocialHttpResponse GetWebProperties(AnalyticsGetWebPropertiesOptions options) {
            
            // Some input validation
            if (options == null) throw new ArgumentNullException("options");
            if (String.IsNullOrWhiteSpace(options.AccountId)) throw new PropertyNotSetException("options.AccountId");

            // Construct the URL
            string url = String.Format(
               "{0}accounts/" + options.AccountId + "/webproperties",
               ManagementUrl,
               options.AccountId
            );
            
            return Client.DoHttpGetRequest(url, options);
        
        }

        /// <summary>
        /// Gets a list of profiles based on the specified <code>options</code>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        /// <returns>Returns an instance of <see cref="SocialHttpResponse"/> representing the response.</returns>
        public SocialHttpResponse GetProfiles(AnalyticsGetProfilesOptions options) {

            
            // Some input validation
            if (options == null) throw new ArgumentNullException("options");
            if (String.IsNullOrWhiteSpace(options.AccountId)) throw new PropertyNotSetException("options.AccountId");
            if (String.IsNullOrWhiteSpace(options.WebPropertyId)) throw new PropertyNotSetException("options.WebPropertyId");

            // Construct the URL
            string url = String.Format(
               "{0}accounts/" + options.AccountId + "/webproperties/" + options.WebPropertyId + "/profiles",
               ManagementUrl,
               options.AccountId,
               options.WebPropertyId
            );

            // Make the call to the API
            return Client.DoHttpGetRequest(url, options);

        }
        
        #endregion

    }

}