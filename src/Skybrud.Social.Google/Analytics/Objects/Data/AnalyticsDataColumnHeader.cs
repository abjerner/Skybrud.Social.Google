using Newtonsoft.Json.Linq;
using Skybrud.Social.Google.Common.Objects;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Social.Google.Analytics.Objects.Data {

    /// <summary>
    /// Class representing the column of a Analytics data response.
    /// </summary>
    public class AnalyticsDataColumnHeader : GoogleApiObject {

        #region Properties
        
        /// <summary>
        /// Gets the name of the column.
        /// </summary>
        public string Name { get; internal set; }

        /// <summary>
        /// Gets the type of the column.
        /// </summary>
        public string ColumnType { get; internal set; }

        /// <summary>
        /// Gets the data type of the column.
        /// </summary>
        public string DataType { get; internal set; }

        #endregion

        #region Constructors

        private AnalyticsDataColumnHeader(JObject obj) : base(obj) { }

        #endregion

        #region Static methods
        
        /// <summary>
        /// Gets an instance of <see cref="AnalyticsDataColumnHeader"/> from the specified <code>JObject</code>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
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