﻿using System;
using Skybrud.Social.Google.Analytics.Endpoints.Raw;
using Skybrud.Social.Google.Analytics.Options.Management;
using Skybrud.Social.Google.Analytics.Responses.Management;

namespace Skybrud.Social.Google.Analytics.Endpoints {
    
    /// <summary>
    /// Implementation of the management endpoint.
    /// </summary>
    public class AnalyticsManagementEndpoint {

        #region Properties

        /// <summary>
        /// Gets the parent endpoint of this endpoint.
        /// </summary>
        public AnalyticsEndpoint Analytics { get; private set; }

        /// <summary>
        /// Gets a reference to the raw endpoint.
        /// </summary>
        public AnalyticsManagementRawEndpoint Raw {
            get { return Analytics.Service.Client.Analytics.Management; }
        }

        #endregion

        #region Constructors

        internal AnalyticsManagementEndpoint(AnalyticsEndpoint analytics) {
            Analytics = analytics;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets a list of Analytics accounts of the authenticated user.
        /// </summary>
        public AnalyticsGetAccountsResponse GetAccounts() {
            return AnalyticsGetAccountsResponse.ParseResponse(Raw.GetAccounts());
        }

        /// <summary>
        /// Gets a list of Analytics accounts of the authenticated user matching the specified <code>options</code>.
        /// </summary>
        public AnalyticsGetAccountsResponse GetAccounts(AnalyticsGetAccountsOptions options) {
            if (options == null) throw new ArgumentNullException("options");
            return AnalyticsGetAccountsResponse.ParseResponse(Raw.GetAccounts(options));
        }

        /// <summary>
        /// Gets a list of web properties using default options.
        /// </summary>
        public AnalyticsGetWebPropertiesResponse GetWebProperties() {
            return GetWebProperties(new AnalyticsGetWebPropertiesOptions());
        }

        /// <summary>
        /// Gets a list of web properties based on the specified <code>options</code>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        public AnalyticsGetWebPropertiesResponse GetWebProperties(AnalyticsGetWebPropertiesOptions options) {
            if (options == null) throw new ArgumentNullException("options");
            return AnalyticsGetWebPropertiesResponse.ParseResponse(Raw.GetWebProperties(options));
        }

        /// <summary>
        /// Gets a list of profiles using default options.
        /// </summary>
        public AnalyticsGetProfilesResponse GetProfiles() {
            return GetProfiles(new AnalyticsGetProfilesOptions());
        }

        /// <summary>
        /// Gets a list of profiles based on the specified <code>options</code>.
        /// </summary>
        /// <param name="options">The options for the call to the API.</param>
        public AnalyticsGetProfilesResponse GetProfiles(AnalyticsGetProfilesOptions options) {
            if (options == null) throw new ArgumentNullException("options");
            return AnalyticsGetProfilesResponse.ParseResponse(Raw.GetProfiles(options));
        }
        
        #endregion

    }

}