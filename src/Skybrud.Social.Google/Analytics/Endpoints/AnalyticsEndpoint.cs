using Skybrud.Social.Google.Analytics.Endpoints.Raw;

namespace Skybrud.Social.Google.Analytics.Endpoints {

    /// <summary>
    /// Implementation of the Analytics API/endpoint.
    /// </summary>
    public class AnalyticsEndpoint {

        #region Properties

        /// <summary>
        /// Gets the parent service of this endpoint.
        /// </summary>
        public GoogleService Service { get; private set; }

        /// <summary>
        /// Gets a reference to the raw Analytics endpoint.
        /// </summary>
        public AnalyticsRawEndpoint Raw {
            get { return Service.Client.Analytics; }
        }

        /// <summary>
        /// Gets a reference to the management endpoint.
        /// </summary>
        public AnalyticsManagementEndpoint Management { get; private set; }

        /// <summary>
        /// Gets a reference to the data endpoint.
        /// </summary>
        public AnalyticsDataEndpoint Data { get; private set; }

        #endregion

        #region Constructors

        internal AnalyticsEndpoint(GoogleService service) {
            Service = service;
            Management = new AnalyticsManagementEndpoint(this);
            Data = new AnalyticsDataEndpoint(this);
        }

        #endregion
        
    }

}