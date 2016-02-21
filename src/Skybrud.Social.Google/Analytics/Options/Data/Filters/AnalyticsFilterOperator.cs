using Skybrud.Social.Google.Analytics.Interfaces;

namespace Skybrud.Social.Google.Analytics.Options.Data.Filters {
    
    /// <summary>
    /// Class describing a filter for querying the Analytics Data API.
    /// </summary>
    public class AnalyticsFilterOperator : IAnalyticsFilterBlock {

        #region Properties

        /// <summary>
        /// Gets the operator.
        /// </summary>
        public string Operator { get; private set; }

        /// <summary>
        /// Gets a reference to the <strong>AND</strong> operator.
        /// </summary>
        public static readonly AnalyticsFilterOperator And = new AnalyticsFilterOperator(";");

        /// <summary>
        /// Gets a reference to the <strong>OR</strong> operator.
        /// </summary>
        public static readonly AnalyticsFilterOperator Or = new AnalyticsFilterOperator(",");

        #endregion

        #region Constructors

        private AnalyticsFilterOperator(string op) {
            Operator = op;
        }

        #endregion

        #region Member methods

        public override string ToString() {
            return Operator;
        }

        #endregion

    }

}