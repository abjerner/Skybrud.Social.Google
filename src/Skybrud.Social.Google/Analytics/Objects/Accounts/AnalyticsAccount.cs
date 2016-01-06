using System;
using Newtonsoft.Json.Linq;
using Skybrud.Social.Google.Analytics.Objects.Common;
using Skybrud.Social.Google.Objects;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Social.Google.Analytics.Objects {

    /// <summary>
    /// Class representing a Google Analytics account. This is not the same as a Google Account,
    /// since a Google Account can have multiple Analytics accounts.
    /// </summary>
    public class AnalyticsAccount : GoogleApiObject {

        #region Properties
        
        /// <summary>
        /// Gets the ID of the account.
        /// </summary>
        public string Id { get; private set; }

        /// <summary>
        /// Gets the name of the account.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Gets a reference to an object describing the permissions to the account.
        /// </summary>
        public AnalyticsPermissions Permissions { get; private set; }

        /// <summary>
        /// Gets the creation date of the account.
        /// </summary>
        public DateTime Created { get; private set; }

        /// <summary>
        /// Gets the update date of the account.
        /// </summary>
        public DateTime Updated { get; private set; }

        #endregion

        #region Constructors

        private AnalyticsAccount(JObject obj) : base(obj) { }

        #endregion

        #region Static methods
        
        /// <summary>
        /// Gets an account from the specified <code>JObject</code>.
        /// </summary>
        /// <param name="obj">The instance of <code>JObject</code> to parse.</param>
        public static AnalyticsAccount Parse(JObject obj) {
            return new AnalyticsAccount(obj) {
                Id = obj.GetString("id"),
                Name = obj.GetString("name"),
                Permissions = obj.GetObject("permissions", AnalyticsPermissions.Parse),
                Created = obj.GetDateTime("created"),
                Updated = obj.GetDateTime("updated")
            };
        }

        #endregion

    }

}