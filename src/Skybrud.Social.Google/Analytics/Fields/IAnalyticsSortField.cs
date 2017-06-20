using Skybrud.Social.Google.Analytics.Models.Data;

namespace Skybrud.Social.Google.Analytics.Models.Common {
    
    /// <summary>
    /// Interface representing a sort field in the Analytics API.
    /// </summary>
    public interface IAnalyticsSortField {

        /// <summary>
        /// Gets the order of the field.
        /// </summary>
        AnalyticsDataSortOrder Order { get; }

        /// <summary>
        /// Gets the field.
        /// </summary>
        IAnalyticsField Field { get; }

    }

}