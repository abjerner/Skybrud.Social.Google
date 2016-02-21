using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Skybrud.Social.Google.Analytics.Dimensions;
using Skybrud.Social.Google.Analytics.Enums;
using Skybrud.Social.Google.Analytics.Interfaces;
using Skybrud.Social.Google.Analytics.Metrics;
using Skybrud.Social.Google.Analytics.Options.Data.Dimensions;
using Skybrud.Social.Google.Analytics.Options.Data.Metrics;

namespace Skybrud.Social.Google.Analytics.Options.Data.Sorting {
    
    /// <summary>
    /// Class representing the options for sorting Analytics data or realtime data.
    /// </summary>
    public class AnalyticsDataSortOptions {

        #region Private fields

        private List<IAnalyticsSortField> _fields = new List<IAnalyticsSortField>();

        #endregion

        #region Properties

        /// <summary>
        /// Gets whether any fields have been added to the options.
        /// </summary>
        public bool HasFields {
            get { return _fields.Any(); }
        }

        /// <summary>
        /// Gets an array of the fields added to the options.
        /// </summary>
        public IAnalyticsSortField[] Fields {
            get { return _fields.ToArray(); }
            set { _fields = (value == null ? new List<IAnalyticsSortField>() : value.ToList()); }
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Resets the internal collection of fields added to the sort options.
        /// </summary>
        /// <returns></returns>
        public AnalyticsDataSortOptions Reset() {
            _fields = new List<IAnalyticsSortField>();
            return this;
        }

        /// <summary>
        /// Adds the specified sort <code>field</code>.
        /// </summary>
        /// <param name="field">The field to be added.</param>
        /// <returns>Returns th current instance of <see cref="AnalyticsDataSortOptions"/> for method chaining.</returns>
        public AnalyticsDataSortOptions Add(IAnalyticsSortField field) {
            if (field == null) throw new ArgumentNullException("field");
            _fields.Add(field);
            return this;
        }

        /// <summary>
        /// Adds the specified <code>dimension</code> as a sort field.
        /// </summary>
        /// <param name="dimension">The dimension to be added.</param>
        /// <param name="order">The order by which the field should be sorted.</param>
        /// <returns>Returns th current instance of <see cref="AnalyticsDataSortOptions"/> for method chaining.</returns>
        public AnalyticsDataSortOptions Add(AnalyticsDimension dimension, AnalyticsDataSortOrder order) {
            if (dimension == null) throw new ArgumentNullException("dimension");
            _fields.Add(new AnalyticsDimensionSortField(dimension, order));
            return this;
        }

        /// <summary>
        /// Adds the specified <code>metric</code> as a sort field.
        /// </summary>
        /// <param name="metric">The metric to be added.</param>
        /// <param name="order">The order by which the field should be sorted.</param>
        /// <returns>Returns th current instance of <see cref="AnalyticsDataSortOptions"/> for method chaining.</returns>
        public AnalyticsDataSortOptions Add(AnalyticsMetric metric, AnalyticsDataSortOrder order) {
            if (metric == null) throw new ArgumentNullException("metric");
            _fields.Add(new AnalyticsMetricSortField(metric, order));
            return this;
        }

        /// <summary>
        /// Adds the specified <code>dimension</code> as a sort field to be sorted in ascending order.
        /// </summary>
        /// <param name="dimension">The dimension to be added.</param>
        /// <returns>Returns th current instance of <see cref="AnalyticsDataSortOptions"/> for method chaining.</returns>
        public AnalyticsDataSortOptions AddAscending(AnalyticsDimension dimension) {
            if (dimension == null) throw new ArgumentNullException("dimension");
            return Add(dimension, AnalyticsDataSortOrder.Ascending);
        }

        /// <summary>
        /// Adds the specified <code>metric</code> as a sort field to be sorted in ascending order.
        /// </summary>
        /// <param name="metric">The metric to be added.</param>
        /// <returns>Returns th current instance of <see cref="AnalyticsDataSortOptions"/> for method chaining.</returns>
        public AnalyticsDataSortOptions AddAscending(AnalyticsMetric metric) {
            if (metric == null) throw new ArgumentNullException("metric");
            return Add(metric, AnalyticsDataSortOrder.Ascending);
        }

        /// <summary>
        /// Adds the specified <code>dimension</code> as a sort field to be sorted in descending order.
        /// </summary>
        /// <param name="dimension">The dimension to be added.</param>
        /// <returns>Returns th current instance of <see cref="AnalyticsDataSortOptions"/> for method chaining.</returns>
        public AnalyticsDataSortOptions AddDescending(AnalyticsDimension dimension) {
            if (dimension == null) throw new ArgumentNullException("dimension");
            return Add(dimension, AnalyticsDataSortOrder.Descending);
        }

        /// <summary>
        /// Adds the specified <code>metric</code> as a sort field to be sorted in descending order.
        /// </summary>
        /// <param name="metric">The metric to be added.</param>
        /// <returns>Returns th current instance of <see cref="AnalyticsDataSortOptions"/> for method chaining.</returns>
        public AnalyticsDataSortOptions AddDescending(AnalyticsMetric metric) {
            if (metric == null) throw new ArgumentNullException("metric");
            return Add(metric, AnalyticsDataSortOrder.Descending);
        }

        public override string ToString() {
            return String.Join(",", _fields.Select(hai => (hai.Order == AnalyticsDataSortOrder.Ascending ? "" : "-") + hai.Field.Name));
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Converts the string representation of the sort options.
        /// </summary>
        /// <param name="str">A string containing the sort options to convert.</param>
        /// <returns>The converted sort options.</returns>
        public static AnalyticsDataSortOptions Parse(string str) {

            // If the strign is NULL, we also return NULL
            if (str == null) return null;

            AnalyticsDataSortOptions options = new AnalyticsDataSortOptions();

            // The sort fields are separated by commas
            string[] b = str.Split(new [] {","}, StringSplitOptions.RemoveEmptyEntries);

            for (int j = 0; j < b.Length; j++) {

                string piece = b[j];

                AnalyticsDataSortOrder order = AnalyticsDataSortOrder.Ascending;
                if (piece.StartsWith("-")) {
                    order = AnalyticsDataSortOrder.Descending;
                    piece = piece.Substring(1);
                }

                // Does the piece have the characteristics of a metric or dimension?
                Match m = Regex.Match(piece, "^(ga:[a-zA-Z]+)$");
                if (!m.Success) throw new Exception("Unable to parse metric or dimension '" + piece + "'");

                AnalyticsMetric metric;
                AnalyticsDimension dimension;
                if (AnalyticsMetric.TryGet(m.Groups[1].Value, out metric)) {
                    options.Add(metric, order);
                } else if (AnalyticsDimension.TryGet(m.Groups[1].Value, out dimension)) {
                    options.Add(dimension, order);
                } else {
                    // Currently the parsing will only work if the specified dimension or
                    // metric name matches a defined constant, so if Google adds a new
                    // dimension or metric, the constants must be updated before the parsing
                    // will work. I'm not sure how often Google adds new dimensions or metric,
                    // so perhaps this isn't a problem
                    throw new Exception("Unable to parse metric or dimension '" + m.Groups[1].Value + "'");
                }

            }

            return options;

        }

        /// <summary>
        /// Converts the string representation of the sort options. A return value indicates
        /// whether the conversion succeeded.
        /// </summary>
        /// <param name="str">A string containing the sort options to convert.</param>
        /// <param name="options">The converted options if successful.</param>
        /// <returns><var>true</var> if str was converted successfully; otherwise, <var>false</var>.</returns>
        public static bool TryParse(string str, out AnalyticsDataSortOptions options) {
            try {
                options = Parse(str);
                return true;
            } catch {
                options = null;
                return false;
            }
        }

        #endregion

        #region Operator overloading

        /// <summary>
        /// Initializes a new instance of <see cref="AnalyticsDataSortOptions"/> from the specified <code>str</code>.
        /// </summary>
        /// <param name="str">The string representing the sort options.</param>
        /// <returns>Returns an instance of <see cref="AnalyticsDataSortOptions"/>.</returns>
        public static implicit operator AnalyticsDataSortOptions(string str) {
            return Parse(str);
        }

        /// <summary>
        /// Initializes a new instance of <see cref="AnalyticsDataSortOptions"/> from the specified <code>array</code>.
        /// </summary>
        /// <param name="array">The array representing the sort options.</param>
        /// <returns>Returns an instance of <see cref="AnalyticsDataSortOptions"/>.</returns>
        public static implicit operator AnalyticsDataSortOptions(IAnalyticsSortField[] array) {
            return new AnalyticsDataSortOptions { Fields = array };
        }

        #endregion

    }

}