using System;
using Skybrud.Social.Google.Analytics.Interfaces;

namespace Skybrud.Social.Google.Analytics.Metrics {

    /// <summary>
    /// Class representing a metric in the Google Analytics API.
    /// </summary>
    public class AnalyticsMetric : IAnalyticsField {

        #region Properties

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
        /// Initializes a new metric from the specified <code>name</code>.
        /// </summary>
        /// <param name="name">The name of the metric.</param>
        public AnalyticsMetric(string name) {
            Name = name;
        }

        /// <summary>
        /// Initializes a new metric from the specified <code>name</code> and <code>groupName</code>.
        /// </summary>
        /// <param name="name">The name of the metric.</param>
        /// <param name="groupName">The name of group of the metric.</param>
        public AnalyticsMetric(string name, string groupName) {
            Name = name;
            GroupName = groupName;
        }

        /// <summary>
        /// Initializes a new metric from the specified <code>name</code> and <code>groupName</code>.
        /// </summary>
        /// <param name="name">The name of the metric.</param>
        /// <param name="groupName">The name of group of the metric.</param>
        /// <param name="obsolete">Indicates whether the metric is obsolete.</param>
        public AnalyticsMetric(string name, string groupName, bool obsolete) {
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

        #region Operator overloading

        /// <summary>
        /// Initializes a new metric from the specified <code>name</code>.
        /// </summary>
        /// <param name="name">The name of the metric.</param>
        /// <returns>Returns an instance of <code>AnalyticsMetric</code> representing the metric.</returns>
        public static implicit operator AnalyticsMetric(string name) {
            if (String.IsNullOrWhiteSpace(name)) throw new ArgumentNullException("name");
            return new AnalyticsMetric(name);
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