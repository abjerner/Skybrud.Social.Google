using Newtonsoft.Json.Linq;
using Skybrud.Social.Google.Common.Objects;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Social.Google.Analytics.Objects {

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
        /// Gets an instance of <var>AnalyticsDataQuery</var> from the specified <code>JObject</code>.
        /// </summary>
        /// <param name="obj">The instance of <code>JObject</code> to parse.</param>
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