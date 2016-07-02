using System;
using Newtonsoft.Json.Linq;
using Skybrud.Social.Google.Common.Objects;
using Skybrud.Social.Json.Extensions;

namespace Skybrud.Social.Google.Analytics.Objects.WebProperties {
    
    /// <summary>
    /// Class representing a web property of a Google Analytics account.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.google.com/analytics/devguides/config/mgmt/v3/mgmtReference/management/webproperties</cref>
    /// </see>
    public class AnalyticsWebProperty : GoogleApiObject {

        #region Properties

        /// <summary>
        /// Gets the ID of the web property in the form <code>UA-XXXXX-YY</code>.
        /// </summary>
        public string Id { get; private set; }

        /// <summary>
        /// Gets the ID of the Analytics account to which this web property belongs.
        /// </summary>
        public string AccountId { get; private set; }

        /// <summary>
        /// Gets the internal ID of the web property.
        /// </summary>
        public string InternalWebPropertyId { get; private set; }

        /// <summary>
        /// Gets the name of the web property.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Gets the website URL of the web property.
        /// </summary>
        public string WebsiteUrl { get; private set; }

        /// <summary>
        /// Gets the level of the web property.
        /// </summary>
        public string Level { get; private set; }

        /// <summary>
        /// Gets the timestamp for when the web property was created.
        /// </summary>
        public DateTime Created { get; private set; }

        /// <summary>
        /// Gets the timestamp for when the web property was last modified.
        /// </summary>
        public DateTime Updated { get; private set; }

        #endregion

        #region Constructors

        private AnalyticsWebProperty(JObject obj) : base(obj) {
            Id = obj.GetString("id");
            AccountId = obj.GetString("accountId");
            InternalWebPropertyId = obj.GetString("internalWebPropertyId");
            Name = obj.GetString("name");
            WebsiteUrl = obj.GetString("websiteUrl");
            Level = obj.GetString("level");
            Created = obj.GetDateTime("created");
            Updated = obj.GetDateTime("updated");
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Gets a web property from the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        /// <returns>Returns the parsed instance of <see cref="AnalyticsWebProperty"/>, or <code>null</code> if <code>obj</code> is <code>null</code>.</returns>
        public static AnalyticsWebProperty Parse(JObject obj) {
            return obj == null ? null : new AnalyticsWebProperty(obj);
        }

        #endregion

    }

}