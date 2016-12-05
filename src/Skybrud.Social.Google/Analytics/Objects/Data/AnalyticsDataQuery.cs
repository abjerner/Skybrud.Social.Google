using System;
using Newtonsoft.Json.Linq;
using Skybrud.Social.Google.Common.Objects;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Google.Analytics.Objects.Data {

    /// <summary>
    /// Class representing the query of a Analytics data response.
    /// </summary>
    public class AnalyticsDataQuery : GoogleApiObject {

        #region Properties
        
        /// <summary>
        /// Gets the ID of the profile.
        /// </summary>
        public string Ids { get; internal set; }

        /// <summary>
        /// Gets the start date of the query.
        /// </summary>
        public string StartDate { get; internal set; }

        /// <summary>
        /// Gets the end date of the query.
        /// </summary>
        public string EndDate { get; internal set; }

        /// <summary>
        /// Gets the start index of the current page of results.
        /// </summary>
        public int StartIndex { get; internal set; }

        /// <summary>
        /// Gets the maximum results per page.
        /// </summary>
        public int MaxResults { get; internal set; }

        /// <summary>
        /// Gets an array of the dimensions specified for the current query.
        /// </summary>
        public string[] Dimensions { get; internal set; }

        /// <summary>
        /// Gets an array of the metrics specified for the current query.
        /// </summary>
        public string[] Metrics { get; internal set; }

        #endregion
        
        #region Constructors

        private AnalyticsDataQuery(JObject obj) : base(obj) {
            Ids = obj.GetString("ids");
            StartDate = obj.GetString("start-date");
            EndDate = obj.GetString("end-date");
            StartIndex = obj.GetInt32("start-index");
            MaxResults = obj.GetInt32("max-results");
            Dimensions = (obj.GetString("dimensions") ?? "").Split(new[] {','}, StringSplitOptions.RemoveEmptyEntries);
            Metrics = obj.GetStringArray("metrics");
        }

        #endregion

        #region Static methods
        
        /// <summary>
        /// Gets an instance of <see cref="AnalyticsDataQuery"/> from the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        /// <returns>Returns an instance of <see cref="AnalyticsDataQuery"/>.</returns>
        public static AnalyticsDataQuery Parse(JObject obj) {
            return obj == null ? null : new AnalyticsDataQuery(obj);
        }

        #endregion

    }

}