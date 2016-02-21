using Newtonsoft.Json.Linq;
using Skybrud.Social.Google.Common.Objects;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Social.Google.Analytics.Objects.Data {

    /// <summary>
    /// Class representing the query of a Analytics realtime data response.
    /// </summary>
    public class AnalyticsRealtimeDataQuery : GoogleApiObject {

        #region Properties
        
        public string Ids { get; internal set; }
        public int StartIndex { get; internal set; }
        public int MaxResults { get; internal set; }
        public string Dimensions { get; internal set; }
        public string[] Metrics { get; internal set; }

        #endregion
        
        #region Constructors

        private AnalyticsRealtimeDataQuery(JObject obj) : base(obj) {
            Ids = obj.GetString("ids");
            StartIndex = obj.GetInt32("start-index");
            MaxResults = obj.GetInt32("max-results");
            Dimensions = obj.GetString("dimensions");
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