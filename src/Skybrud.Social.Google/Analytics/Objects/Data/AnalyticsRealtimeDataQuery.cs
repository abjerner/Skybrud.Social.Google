using System;
using Newtonsoft.Json.Linq;
using Skybrud.Social.Google.Common.Objects;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Social.Google.Analytics.Objects.Data {

    /// <summary>
    /// Class representing the query of a Analytics realtime data response.
    /// </summary>
    public class AnalyticsRealtimeDataQuery : GoogleApiObject {

        #region Properties

        /// <summary>
        /// Gets the ID of the profile.
        /// </summary>
        public string Ids { get; internal set; }

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

        private AnalyticsRealtimeDataQuery(JObject obj) : base(obj) {
            Ids = obj.GetString("ids");
            StartIndex = obj.GetInt32("start-index");
            MaxResults = obj.GetInt32("max-results");
            Dimensions = (obj.GetString("dimensions") ?? "").Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            Metrics = obj.GetStringArray("metrics");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets an instance of <see cref="AnalyticsDataQuery"/> from the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        /// <returns>Returns an instance of <see cref="AnalyticsDataQuery"/>.</returns>
        public static AnalyticsRealtimeDataQuery Parse(JObject obj) {
            return obj == null ? null : new AnalyticsRealtimeDataQuery(obj);
        }

        #endregion

    }

}