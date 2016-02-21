using System;
using Newtonsoft.Json.Linq;
using Skybrud.Social.Google.Common.Objects;
using Skybrud.Social.Json.Extensions.JObject;

namespace Skybrud.Social.Google.Analytics.Objects.Profiles {
    
    /// <summary>
    /// Class representing a web profile in a Google Analytics context.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.google.com/analytics/devguides/config/mgmt/v3/mgmtReference/management/profiles#resource</cref>
    /// </see>
    public class AnalyticsProfile : GoogleApiObject {

        #region Properties
        
        /// <summary>
        /// Gets the ID of the profile.
        /// </summary>
        public string Id { get; private set; }

        /// <summary>
        /// Gets the ID of the parent Analytics account.
        /// </summary>
        public string AccountId { get; private set; }

        /// <summary>
        /// Gets the eeb property ID of the form <code>UA-XXXXX-YY</code> to which this profile belongs.
        /// </summary>
        public string WebPropertyId { get; private set; }

        /// <summary>
        /// Gets the internal ID for the web property to which this profile belongs.
        /// </summary>
        public string InternalWebPropertyId { get; private set; }

        /// <summary>
        /// Gets the name of the 
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Gets the currency type associated with this profile, defaults to <code>USD</code>. 
        /// </summary>
        public string Currency { get; private set; }

        /// <summary>
        /// Gets the time zone for which this profile has been configured. 
        /// </summary>
        public string Timezone { get; private set; }

        /// <summary>
        /// Gets the website URL of the profile.
        /// </summary>
        public string WebsiteUrl { get; private set; }

        /// <summary>
        /// Gets the type of the profile. Can be either <code>WEB</code> or <code>APP</code>.
        /// </summary>
        public string Type { get; private set; }

        /// <summary>
        /// Gets the timestamp for when the profile was created.
        /// </summary>
        public DateTime Created { get; private set; }

        /// <summary>
        /// Gets the timestamp for when the profile was last modified.
        /// </summary>
        public DateTime Updated { get; private set; }

        #endregion

        #region Constructors

        private AnalyticsProfile(JObject obj) : base(obj) {
            Id = obj.GetString("id");
            AccountId = obj.GetString("accountId");
            WebPropertyId = obj.GetString("webPropertyId");
            InternalWebPropertyId = obj.GetString("internalWebPropertyId");
            Name = obj.GetString("name");
            Currency = obj.GetString("currency");
            Timezone = obj.GetString("timezone");
            WebsiteUrl = obj.GetString("websiteUrl");
            Type = obj.GetString("type");
            Created = obj.GetDateTime("created");
            Updated = obj.GetDateTime("updated");
        }

        #endregion

        #region Static methods
        
        /// <summary>
        /// Gets a profile from the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        /// <returns>Returns the parsed instance of <see cref="AnalyticsProfile"/>, or <code>null</code> if <code>obj</code> is <code>null</code>.</returns>
        public static AnalyticsProfile Parse(JObject obj) {
            return obj == null ? null : new AnalyticsProfile(obj);
        }

        #endregion

    }

}