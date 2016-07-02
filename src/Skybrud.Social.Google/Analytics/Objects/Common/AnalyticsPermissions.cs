using Newtonsoft.Json.Linq;
using Skybrud.Social.Google.Common.Objects;
using Skybrud.Social.Json.Extensions;

namespace Skybrud.Social.Google.Analytics.Objects.Common {
    
    /// <summary>
    /// Class describing the permissions to an Analytics account.
    /// </summary>
    public class AnalyticsPermissions : GoogleApiObject {

        #region Properties

        /// <summary>
        /// Gets an array of permissions to the parent account.
        /// </summary>
        public string[] Effective { get; private set; }

        #endregion

        #region Constructors

        private AnalyticsPermissions(JObject obj) : base(obj) {
            Effective = obj.GetStringArray("effective") ?? new string[0];
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets an instance of <code>AnalyticsPermissions</code> from the specified <code>JObject</code>.
        /// </summary>
        /// <param name="obj">The instance of <code>JObject</code> to parse.</param>
        public static AnalyticsPermissions Parse(JObject obj) {
            return obj == null ? null : new AnalyticsPermissions(obj);
        }

        #endregion

    }

}