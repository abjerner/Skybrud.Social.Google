using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Google.Drive.Objects.Users {

    /// <summary>
    /// Class representing a user as returned by the Google Drive API.
    /// </summary>
    public class DriveUser : DriveObject {

        #region Properties
        
        /// <summary>
        /// Gets a plain text displayable name for this user.
        /// </summary>
        public string DisplayName { get; private set; }

        /// <summary>
        /// Gets a link to the user's profile photo, if available.
        /// </summary>
        public string PhotoLink { get; private set; }

        /// <summary>
        /// Gets whether this user is the requesting user.
        /// </summary>
        public bool IsMe { get; private set; }

        /// <summary>
        /// Gets the user's ID as visible in Permission resources.
        /// </summary>
        public string PermissionId { get; private set; }

        /// <summary>
        /// Gets the email address of the user. This may not be present in certain contexts if the user has not made
        /// their email address visible to the requester.
        /// </summary>
        public string EmailAddress { get; private set; }

        #endregion

        #region Constructors

        protected DriveUser(JObject obj) : base(obj) {
            DisplayName = obj.GetString("displayName");
            PhotoLink = obj.GetString("photoLink");
            IsMe = obj.GetBoolean("me");
            PermissionId = obj.GetString("permissionId");
            EmailAddress = obj.GetString("emailAddress");
            
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="DriveUser"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="DriveUser"/>.</returns>
        public static DriveUser Parse(JObject obj) {
            return obj == null ? null : new DriveUser(obj);
        }

        #endregion

    }

}