using System;
using Skybrud.Social.Google.Analytics.Dimensions;
using Skybrud.Social.Google.Analytics.Metrics;
using Skybrud.Social.Google.Analytics.Objects.Profiles;
using Skybrud.Social.Google.Analytics.Options.Data.Dimensions;
using Skybrud.Social.Google.Analytics.Options.Data.Filters;
using Skybrud.Social.Google.Analytics.Options.Data.Metrics;
using Skybrud.Social.Google.Analytics.Options.Data.Sorting;
using Skybrud.Social.Http;
using Skybrud.Social.Interfaces.Http;

namespace Skybrud.Social.Google.Analytics.Options.Data {

    /// <summary>
    /// Class representing the options for getting data from the Analytics API.
    /// </summary>
    public class AnalyticsGetDataOptions : IHttpGetOptions {

        #region Private fields

        private AnalyticsFilterOptions _filters = new AnalyticsFilterOptions();
        private AnalyticsDataSortOptions _sorting = new AnalyticsDataSortOptions();

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the ID of the profile.
        /// </summary>
        public string ProfileId { get; set; }

        /// <summary>
        /// Gets or sets the start date from when to pull data.
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets the end date.
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Gets or sets the metrics.
        /// </summary>
        public AnalyticsMetricCollection Metrics { get; set; }

        /// <summary>
        /// Gets or sets the dimensions.
        /// </summary>
        public AnalyticsDimensionCollection Dimensions { get; set; }

        /// <summary>
        /// Gets or sets the filter options.
        /// </summary>
        public AnalyticsFilterOptions Filters {
            get { return _filters; }
            set { _filters = value ?? new AnalyticsFilterOptions(); }
        }

        /// <summary>
        /// A list of metrics and dimensions indicating the sorting order and sorting direction for the returned data.
        /// </summary>
        public AnalyticsDataSortOptions Sorting {
            get { return _sorting; }
            set { _sorting = value ?? new AnalyticsDataSortOptions(); }
        }

        /// <summary>
        /// Gets or sets the start index.
        /// </summary>
        public int StartIndex { get; set; }

        /// <summary>
        /// Gets or sets the maximum amount of results returned. If <code>0</code>, the default maximum of the API will
        /// be used.
        /// </summary>
        public int MaxResults { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance with a period of the 31 most recent days.
        /// </summary>
        public AnalyticsGetDataOptions() {
            StartDate = DateTime.Now.Subtract(TimeSpan.FromDays(31));
            EndDate = DateTime.Now;
        }

        /// <summary>
        /// Initializes a new instance based on the the specified <code>profile</code>.
        /// </summary>
        /// <param name="profile">The profile.</param>
        public AnalyticsGetDataOptions(AnalyticsProfile profile) : this() {
            if (profile == null) throw new ArgumentNullException("profile");
            ProfileId = profile.Id;
        }

        /// <summary>
        /// Initializes a new instance based on the profile with the specified <code>profileId</code>.
        /// </summary>
        /// <param name="profileId">The ID of the profile.</param>
        public AnalyticsGetDataOptions(string profileId) : this() {
            ProfileId = profileId;
        }

        #endregion

        #region Methods

        public IHttpQueryString GetQueryString() {
            SocialHttpQueryString query = new SocialHttpQueryString();
            if (!String.IsNullOrWhiteSpace(ProfileId)) query.Add("ids", (ProfileId.StartsWith("ga:") ? ProfileId : "ga:" + ProfileId));
            query.Add("start-date", StartDate.ToString("yyyy-MM-dd"));
            query.Add("end-date", EndDate.ToString("yyyy-MM-dd"));
            query.Add("metrics", Metrics == null ? "" : Metrics.ToString());
            if (Dimensions != null && Dimensions.Count > 0) query.Add("dimensions", Dimensions.ToString());
            if (Filters.HasBlocks) query.Add("filters", Filters.ToString());
            if (Sorting.HasFields) query.Add("sort", Sorting.ToString());
            if (StartIndex > 0) query.Add("start-index", StartIndex);
            if (MaxResults > 0) query.Add("max-results", MaxResults);
            return query;
        }

        /// <summary>
        /// Adds the specified metric.
        /// </summary>
        /// <param name="metric">The metric to add.</param>
        public AnalyticsGetDataOptions AddMetric(AnalyticsMetric metric) {
            if (Metrics == null) Metrics = new AnalyticsMetricCollection();
            Metrics.Add(metric);
            return this;
        }

        /// <summary>
        /// Adds the specified sequence of metrics.
        /// </summary>
        /// <param name="metrics">The metrics to add.</param>
        public AnalyticsGetDataOptions AddMetrics(params AnalyticsMetric[] metrics) {
            if (Metrics == null) Metrics = new AnalyticsMetricCollection();
            Metrics.AddRange(metrics);
            return this;
        }

        /// <summary>
        /// Adds the specified dimension.
        /// </summary>
        /// <param name="dimension">The dimension to add.</param>
        public AnalyticsGetDataOptions AddDimension(AnalyticsDimension dimension) {
            if (Dimensions == null) Dimensions = new AnalyticsDimensionCollection();
            Dimensions.Add(dimension);
            return this;
        }

        /// <summary>
        /// Adds the specified sequence of dimensions.
        /// </summary>
        /// <param name="dimensions">The dimensions to add.</param>
        public AnalyticsGetDataOptions AddDimensions(params AnalyticsDimension[] dimensions) {
            if (Dimensions == null) Dimensions = new AnalyticsDimensionCollection();
            Dimensions.AddRange(dimensions);
            return this;
        }

        /// <summary>
        /// Adds the specified metric filter.
        /// </summary>
        /// <param name="filter">The filter to add.</param>
        public AnalyticsGetDataOptions AddMetricFilter(AnalyticsMetricFilter filter) {
            _filters.Add(filter);
            return this;
        }

        /// <summary>
        /// Adds a metric filter with the specified information.
        /// </summary>
        /// <param name="metric">The metric.</param>
        /// <param name="op">The operator.</param>
        /// <param name="value">The value.</param>
        public AnalyticsGetDataOptions AddMetricFilter(AnalyticsMetric metric, AnalyticsMetricOperator op, string value) {
            _filters.Add(new AnalyticsMetricFilter(metric, op, value));
            return this;
        }

        /// <summary>
        /// Adds the specified dimension filter.
        /// </summary>
        /// <param name="filter">The filter to add.</param>
        public AnalyticsGetDataOptions AddDimensionFilter(AnalyticsDimensionFilter filter) {
            _filters.Add(filter);
            return this;
        }

        /// <summary>
        /// Adds a dimension filter with the specified information.
        /// </summary>
        /// <param name="dimension">The dimension.</param>
        /// <param name="op">The operator.</param>
        /// <param name="value">The value.</param>
        public AnalyticsGetDataOptions AddDimensionFilter(AnalyticsDimension dimension, AnalyticsDimensionOperator op, string value) {
            _filters.Add(new AnalyticsDimensionFilter(dimension, op, value));
            return this;
        }

        #endregion

    }

}