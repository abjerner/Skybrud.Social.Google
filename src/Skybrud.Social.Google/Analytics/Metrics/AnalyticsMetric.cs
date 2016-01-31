using System;
using System.Collections.Generic;
using Skybrud.Social.Google.Analytics.Interfaces;

namespace Skybrud.Social.Google.Analytics.Metrics {

    /// <summary>
    /// Class representing a metric in the Google Analytics API.
    /// </summary>
    public class AnalyticsMetric : IAnalyticsField {

        #region Private fields

        private static readonly Dictionary<string, AnalyticsMetric> Metrics = new Dictionary<string, AnalyticsMetric>();

        #endregion

        #region Properties

        /// <summary>
        /// Gets a dictionary containing all metrics. 
        /// </summary>
        public static Dictionary<string, AnalyticsMetric> All {
            get {
                AnalyticsMetrics.GetAll();
                AnalyticsRealtimeMetrics.GetAll();
                return Metrics;
            }
        }

        /// <summary>
        /// Gets the name of the metric.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Gets the name of the group of the metric.
        /// </summary>
        public string GroupName { get; private set; }

        /// <summary>
        /// Gets whether the metric is obsolete.
        /// </summary>
        public bool IsObsolete { get; private set; }

        #endregion

        #region Constructor
        
        /// <summary>
        /// Initializes a new metric from the specified <code>name</code> and <code>groupName</code>.
        /// </summary>
        /// <param name="name">The name of the metric.</param>
        /// <param name="groupName">The name of group of the metric.</param>
        /// <param name="obsolete">Indicates whether the metric is obsolete.</param>
        private AnalyticsMetric(string name, string groupName, bool obsolete) {
            Name = name;
            GroupName = groupName;
            IsObsolete = obsolete;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets the name of the metric (eg. "ga:visits").
        /// </summary>
        public override string ToString() {
            return Name;
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Registers a new metric with the specified <code>name</code> and returns the created metric. If a metric
        /// with the specified name already exists, the existing metric will be returned instead.
        /// </summary>
        /// <param name="name">The name of the metric.</param>
        public static AnalyticsMetric Register(string name) {
            return Register(name, null, false);
        }

        /// <summary>
        /// Registers a new dmetricimension with the specified <code>name</code> and returns the created metric. If a
        /// metric with the specified name already exists, the existing metric will be returned instead.
        /// </summary>
        /// <param name="name">The name of the metric.</param>
        /// <param name="groupName">The group name of the metric.</param>
        public static AnalyticsMetric Register(string name, string groupName) {
            return Register(name, groupName, false);
        }

        /// <summary>
        /// Registers a new metric with the specified <code>name</code> and returns the created metric. If a metric
        /// with the specified name already exists, the existing metric will be returned instead.
        /// </summary>
        /// <param name="name">The name of the metric.</param>
        /// <param name="groupName">The group name of the metric.</param>
        /// <param name="obsolete">Whether the metric is obsolete.</param>
        public static AnalyticsMetric Register(string name, string groupName, bool obsolete) {
            AnalyticsMetric metric;
            if (All.TryGetValue(name, out metric)) return metric;
            metric = new AnalyticsMetric(name, groupName, obsolete);
            All.Add(metric.Name, metric);
            return metric;
        }

        /// <summary>
        /// Gets a reference to the metric with the specified <code>name</code>, or <code>null</code> if not found.
        /// </summary>
        /// <param name="name">The name of the metric.</param>
        /// <returns>Returns an instance of <code>AnalyticsMetric</code> if the metric is found, otherwise <code>null</code>.</returns>
        public static AnalyticsMetric Get(string name) {
            AnalyticsMetric metric;
            return All.TryGetValue(name, out metric) ? metric : null;
        }

        /// <summary>
        /// Attempts to find metric with the specified <code>name</code>.
        /// </summary>
        /// <param name="name">The name of the metric.</param>
        /// <param name="metric">The metric.</param>
        /// <returns>Returns <code>true</code> if the metric was found, otherwise <code>false</code>.</returns>
        public static bool TryGet(string name, out AnalyticsMetric metric) {
            return All.TryGetValue(name, out metric);
        }

        /// <summary>
        /// Gets whether a metric with the specified <code>name</code> already exists.
        /// </summary>
        /// <param name="name">The name of the metric.</param>
        /// <returns>Returns <code>true</code> if the metric exists, otherwise <code>false</code>.</returns>
        public static bool Exists(string name) {
            return All.ContainsKey(name);
        }

        #endregion

        #region Operator overloading

        /// <summary>
        /// Initializes a new metric from the specified <code>name</code>.
        /// </summary>
        /// <param name="name">The name of the metric.</param>
        /// <returns>Returns an instance of <code>AnalyticsMetric</code> representing the metric.</returns>
        public static implicit operator AnalyticsMetric(string name) {
            if (String.IsNullOrWhiteSpace(name)) throw new ArgumentNullException("name");
            return Register(name);
        }

        /// <summary>
        /// Gets a new collection containg the <code>left</code> and <code>right</code> metrics.
        /// </summary>
        /// <param name="left">The metric to the left of the operator.</param>
        /// <param name="right">The metric to the right of the operator.</param>
        /// <returns>Returns an instance of <code>AnalyticsMetricCollection</code>.</returns>
        public static AnalyticsMetricCollection operator +(AnalyticsMetric left, AnalyticsMetric right) {
            return new AnalyticsMetricCollection(left, right);
        }

        #endregion

    }

}