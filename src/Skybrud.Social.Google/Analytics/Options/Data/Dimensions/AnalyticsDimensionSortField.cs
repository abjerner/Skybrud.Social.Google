using System;
using Skybrud.Social.Google.Analytics.Dimensions;
using Skybrud.Social.Google.Analytics.Enums;
using Skybrud.Social.Google.Analytics.Interfaces;

namespace Skybrud.Social.Google.Analytics.Options.Data.Dimensions {
    
    public class AnalyticsDimensionSortField : IAnalyticsSortField {

        #region Properties

        public AnalyticsDataSortOrder Order { get; set; }

        public IAnalyticsField Field {
            get { return Dimension; }
        }

        public AnalyticsDimension Dimension { get; set; }

        #endregion

        #region Constructors

        public AnalyticsDimensionSortField() {
            // Default constructor
        }

        public AnalyticsDimensionSortField(AnalyticsDimension dimension, AnalyticsDataSortOrder order) {
            if (dimension == null) throw new ArgumentNullException("dimension");
            Dimension = dimension;
            Order = order;
        }

        #endregion

    }

}