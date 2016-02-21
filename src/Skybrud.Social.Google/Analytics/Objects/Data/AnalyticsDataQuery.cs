using Newtonsoft.Json.Linq;
using Skybrud.Social.Google.Common.Objects;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Social.Google.Analytics.Objects.Data {

    /// <summary>
    /// Class representing the query of a Analytics data response.
    /// </summary>
    public class AnalyticsDataQuery : GoogleApiObject {

        #region Properties
        
        public string Ids { get; internal set; }
        public string StartDate { get; internal set; }
        public string EndDate { get; internal set; }
        public int StartIndex { get; internal set; }
        public int MaxResults { get; internal set; }
        public string Dimensions { get; internal set; }
        public string[] Metrics { get; internal set; }

        #endregion
        
        #region Constructors

        private AnalyticsDataQuery(JObject obj) : base(obj) { }

        #endregion

        #region Static methods
        
        /// <summary>
        /// Gets an instance of <see cref="AnalyticsDataQuery"/> from the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        /// <returns>Returns an instance of <see cref="AnalyticsDataQuery"/>.</returns>
        public static AnalyticsDataQuery Parse(JObject obj) {
            if (obj == null) return null;
            return new AnalyticsDataQuery(obj) {
                Ids = obj.GetString("ids"),
                StartDate = obj.GetString("start-date"),
                EndDate = obj.GetString("end-date"),
                StartIndex = obj.GetInt32("start-index"),
                MaxResults = obj.GetInt32("max-results"),
                Dimensions = obj.GetString("dimensions"),
                Metrics = obj.GetStringArray("metrics")
            };
        }

        #endregion

    }

}