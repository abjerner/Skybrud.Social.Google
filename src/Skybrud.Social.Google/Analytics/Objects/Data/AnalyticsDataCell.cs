using System;
using System.Globalization;
using Newtonsoft.Json;

namespace Skybrud.Social.Google.Analytics.Objects.Data {

    /// <summary>
    /// Class representing a cell of Analytics data row.
    /// </summary>
    public class AnalyticsDataCell {

        #region Properties

        /// <summary>
        /// Gets a reference to the parent row.
        /// </summary>
        [JsonIgnore]
        public AnalyticsDataRow Row { get; internal set; }

        /// <summary>
        /// Gets the index of the cell.
        /// </summary>
        public int Index { get; internal set; }

        /// <summary>
        /// Gets the column header for the cell.
        /// </summary>
        public AnalyticsDataColumnHeader Column { get; internal set; }

        /// <summary>
        /// Gets the raw string value of the cell.
        /// </summary>
        public string Value { get; internal set; }

        #endregion

        #region Member properties

        /// <summary>
        /// Gets the value of the cell and converts it to <code>T</code>.
        /// </summary>
        public T GetValue<T>() {
            return (T) Convert.ChangeType(Value, typeof(T), CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Gets the value of the cell. Since the value is stored as a string internally, no
        /// conversion is required.
        /// </summary>
        /// <returns>Returns the value as an instance of <see cref="System.String"/>.</returns>
        public string GetString() {
            return Value;
        }

        /// <summary>
        /// Gets the value of the cell as an integer.
        /// </summary>
        /// <returns>Returns the value as an instance of <see cref="System.Int32"/>.</returns>
        public int GetInt32() {
            return GetValue<int>();
        }

        /// <summary>
        /// Gets the value of the cell as a float.
        /// </summary>
        /// <returns>Returns the value as an instance of <see cref="System.Single"/>.</returns>
        public float GetFloat() {
            return GetValue<float>();
        }

        /// <summary>
        /// Gets the value of the cell as a double.
        /// </summary>
        /// <returns>Returns the value as an instance of <see cref="System.Double"/>.</returns>
        public double GetDouble() {
            return GetValue<double>();
        }

        /// <summary>
        /// Gets the value of the cell as an instance of <see cref="System.TimeSpan"/>.
        /// </summary>
        /// <returns>Returns the value as an instance of <see cref="System.TimeSpan"/>.</returns>
        public TimeSpan GetTime() {
            return TimeSpan.FromSeconds(GetValue<double>());
        }

        public override string ToString() {
            return Value;
        }

        #endregion

    }

}