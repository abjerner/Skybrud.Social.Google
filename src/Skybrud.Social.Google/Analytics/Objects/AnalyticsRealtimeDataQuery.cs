using Newtonsoft.Json.Linq;
using Skybrud.Social.Google.Common.Objects;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Social.Google.Analytics.Objects {

    public class AnalyticsRealtimeDataQuery : GoogleApiObject {

        #region Properties
        
        public string Ids { get; internal set; }
        public int StartIndex { get; internal set; }
        public int MaxResults { get; internal set; }
        public string Dimensions { get; internal set; }
        public string[] Metrics { get; internal set; }

        #endregion
        
        #region Constructors

        private AnalyticsRealtimeDataQuery(JObject obj) : base(obj) { }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets a user from the specified <var>JObject</var>.
        /// </summary>
        /// <param name="obj">The instance of <var>JObject</var> to parse.</param>
        public static AnalyticsRealtimeDataQuery Parse(JObject obj) {
            if (obj == null) return null;
            return new AnalyticsRealtimeDataQuery(obj) {
                Ids = obj.GetString("ids"),
                StartIndex = obj.GetInt32("start-index"),
                MaxResults = obj.GetInt32("max-results"),
                Dimensions = obj.GetString("dimensions"),
                Metrics = obj.GetStringArray("metrics")
            };
        }

        #endregion

    }

}