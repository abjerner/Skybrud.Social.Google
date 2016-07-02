﻿using System;
using Skybrud.Social.Http;
using Skybrud.Social.Interfaces.Http;

namespace Skybrud.Social.Google.Analytics.Options.Management {

    /// <summary>
    /// Class representing the options for getting web properties from the Analytics API.
    /// </summary>
    public class AnalyticsGetWebPropertiesOptions : IHttpGetOptions {

        #region Properties

        /// <summary>
        /// Gets or sets the ID of the parent account. If set to <code>~all</code>, web properties of all accounts
        /// (that the authenticated user has access to) will be returned.
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Gets or sets the maximum amount of results returned. If <code>0</code>, the default maximum of the API will
        /// be used.
        /// </summary>
        public int MaxResults { get; set; }

        /// <summary>
        /// Gets or sets the start index.
        /// </summary>
        public int StartIndex { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance with default options.
        /// </summary>
        public AnalyticsGetWebPropertiesOptions() {
            AccountId = "~all";
        }

        /// <summary>
        /// Initializes a new instance based on the specified <code>maxResults</code>.
        /// </summary>
        /// <param name="maxResults">The maximum number of web properties to include in this response.</param>
        public AnalyticsGetWebPropertiesOptions(int maxResults) : this() {
            MaxResults = maxResults;
        }

        /// <summary>
        /// Initializes a new instance based on the specified <code>maxResults</code> and <code>startIndex</code>.
        /// </summary>
        /// <param name="maxResults">The maximum number of web properties to include in this response.</param>
        /// <param name="startIndex">The index of the first web property to retrieve. The first web property holds the index <code>1</code>.</param>
        public AnalyticsGetWebPropertiesOptions(int maxResults, int startIndex) : this() {
            MaxResults = maxResults;
            StartIndex = startIndex;
        }

        /// <summary>
        /// Initializes a new instance with default options.
        /// </summary>
        /// <param name="accountId">The ID of the parent account.</param>
        public AnalyticsGetWebPropertiesOptions(string accountId) : this() {
            if (string.IsNullOrWhiteSpace(accountId)) throw new ArgumentNullException("accountId");
            AccountId = accountId;
        }

        /// <summary>
        /// Initializes a new instance based on the specified <code>maxResults</code>.
        /// </summary>
        /// <param name="accountId">The ID of the parent web properties.</param>
        /// <param name="maxResults">The maximum number of web properties to include in this response.</param>
        public AnalyticsGetWebPropertiesOptions(string accountId, int maxResults) : this() {
            if (string.IsNullOrWhiteSpace(accountId)) throw new ArgumentNullException("accountId");
            AccountId = accountId;
            MaxResults = maxResults;
        }

        /// <summary>
        /// Initializes a new instance based on the specified <code>maxResults</code> and <code>startIndex</code>.
        /// </summary>
        /// <param name="accountId">The ID of the parent account.</param>
        /// <param name="maxResults">The maximum number of web properties to include in this response.</param>
        /// <param name="startIndex">The index of the first web property to retrieve. The first web property holds the index <code>1</code>.</param>
        public AnalyticsGetWebPropertiesOptions(string accountId, int maxResults, int startIndex) : this() {
            if (string.IsNullOrWhiteSpace(accountId)) throw new ArgumentNullException("accountId");
            AccountId = accountId;
            MaxResults = maxResults;
            StartIndex = startIndex;
        }
        
        #endregion

        #region Methods

        public IHttpQueryString GetQueryString() {
            SocialHttpQueryString query = new SocialHttpQueryString();
            if (StartIndex > 0) query.Add("start-index", StartIndex);
            if (MaxResults > 0) query.Add("max-results", MaxResults);
            return query;
        }

        #endregion

    }

}