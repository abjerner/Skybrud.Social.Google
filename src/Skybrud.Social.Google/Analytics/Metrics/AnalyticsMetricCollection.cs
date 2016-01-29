using System;
using System.Collections.Generic;
using System.Linq;

namespace Skybrud.Social.Google.Analytics.Metrics {

    /// <summary>
    /// Class representing a collection of metrics.
    /// </summary>
    public class AnalyticsMetricCollection {

        #region Private fields

        private readonly List<AnalyticsMetric> _list = new List<AnalyticsMetric>();

        #endregion

        #region Properties

        /// <summary>
        /// Gets the amount of metrics currently in the collection.
        /// </summary>
        public int Count {
            get { return _list.Count; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes an empty collection.
        /// </summary>
        public AnalyticsMetricCollection() {
            // Expose parameterless constructor
        }

        /// <summary>
        /// Initializes a collection containing the specified metrics.
        /// </summary>
        /// <param name="metrics">The metrics to add.</param>
        public AnalyticsMetricCollection(params AnalyticsMetric[] metrics) {
            _list.AddRange(metrics);
        }

        /// <summary>
        /// Initializes a collection containing the specified metrics.
        /// </summary>
        /// <param name="metrics">The metrics to add.</param>
        public AnalyticsMetricCollection(IEnumerable<AnalyticsMetric> metrics) {
            _list.AddRange(metrics);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Adds the specified metric to the collection.
        /// </summary>
        /// <param name="metric">The metric to add.</param>
        public void Add(AnalyticsMetric metric) {
            _list.Add(metric);
        }


        /// <summary>
        /// Adds the specified range of metrics to the collection.
        /// </summary>
        /// <param name="metrics">The dimensions to add.</param>
        public void AddRange(IEnumerable<AnalyticsMetric> metrics) {
            _list.AddRange(metrics);
        }

        /// <summary>
        /// Gets an array of the metrics currently in the collection.
        /// </summary>
        public AnalyticsMetric[] ToArray() {
            return _list.ToArray();
        }

        /// <summary>
        /// Gets a string array of the metrics currently in the collection.
        /// </summary>
        public string[] ToStringArray() {
            return (from metric in _list select metric.Name).ToArray();
        }

        /// <summary>
        /// Gets a string representation if the metrics currently in the collection.
        /// </summary>
        public override string ToString() {
            return String.Join(",", from metric in _list select metric.Name);
        }

        #endregion

        #region Operator overloading

        /// <summary>
        /// Initializes a new collection from the specified <code>metric</code>.
        /// </summary>
        /// <param name="metric">The metric to be added to the collection.</param>
        /// <returns>Returns an instance of <code>AnalyticsMetricCollection</code>.</returns>
        public static implicit operator AnalyticsMetricCollection(AnalyticsMetric metric) {
            return new AnalyticsMetricCollection(metric);
        }

        /// <summary>
        /// Initializes a new collection based on the specified array of <code>metrics</code>.
        /// </summary>
        /// <param name="metrics">The array of metrics to be added to the collection.</param>
        /// <returns>Returns an instance of <code>AnalyticsMetricCollection</code>.</returns>
        public static implicit operator AnalyticsMetricCollection(AnalyticsMetric[] metrics) {
            return new AnalyticsMetricCollection(metrics);
        }

        /// <summary>
        /// Adds the specified <code>metric</code> to <code>collection</code>.
        /// </summary>
        /// <param name="collection">The collection to which the metric should be added.</param>
        /// <param name="metric">The metric to be added to the collection.</param>
        /// <returns>Returns an instance of <code>AnalyticsMetricCollection</code>.</returns>
        public static AnalyticsMetricCollection operator +(AnalyticsMetricCollection collection, AnalyticsMetric metric) {
            collection.Add(metric);
            return collection;
        }

        /// <summary>
        /// Initializes a new collection based on the specified string array of <code>metrics</code>.
        /// </summary>
        /// <param name="metrics">A string array containing the names of the metrics to be added.</param>
        /// <returns>Returns an instance of <code>AnalyticsMetricCollection</code>.</returns>
        public static implicit operator AnalyticsMetricCollection(string[] metrics) {
            return new AnalyticsMetricCollection(from AnalyticsMetric metric in metrics select metric);
        }

        #endregion

    }

}
