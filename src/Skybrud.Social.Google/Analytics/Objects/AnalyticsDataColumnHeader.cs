using Newtonsoft.Json.Linq;
using Skybrud.Social.Google.Objects;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Social.Google.Analytics.Objects {

    public class AnalyticsDataColumnHeader : GoogleApiObject {

        #region Properties
        
        public string Name { get; internal set; }
        public string ColumnType { get; internal set; }
        public string DataType { get; internal set; }

        #endregion

        #region Constructors

        private AnalyticsDataColumnHeader(JObject obj) : base(obj) { }

        #endregion

        #region Static methods
        
        /// <summary>
        /// Gets an instance of <code>AnalyticsDataColumnHeader</code> from the specified <code>JObject</code>.
        /// </summary>
        /// <param name="obj">The instance of <code>JObject</code> to parse.</param>
        public static AnalyticsDataColumnHeader Parse(JObject obj) {
            if (obj == null) return null;
            return new AnalyticsDataColumnHeader(obj) {
                Name = obj.GetString("name"),
                ColumnType = obj.GetString("columnType"),
                DataType = obj.GetString("dataType")
            };
        }

        #endregion
        
    }

}