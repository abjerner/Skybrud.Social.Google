using System;
using Skybrud.Social.Google.Analytics.Models.Common;
using Skybrud.Social.Google.Analytics.Models.Data;
using Skybrud.Social.Google.Analytics.Models.Metrics;

namespace Skybrud.Social.Google.Analytics.Options.Data.Metrics {
    
    public class AnalyticsMetricSortField : IAnalyticsSortField {

        #region Properties

        public AnalyticsDataSortOrder Order { get; set; }

        public IAnalyticsField Field {
            get { return Metric; }
        }

        public AnalyticsMetric Metric { get; set; }

        #endregion

        #region Constructors

        public AnalyticsMetricSortField() {
            // Default constructor
        }

        public AnalyticsMetricSortField(AnalyticsMetric metric, AnalyticsDataSortOrder order) {
            if (metric == null) throw new ArgumentNullException("metric");
            Metric = metric;
            Order = order;
        }

        #endregion

    }

}