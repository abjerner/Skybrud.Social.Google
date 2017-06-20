using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Essentials.Time;
using Skybrud.Social.Google.Drive.Models.Users;

namespace Skybrud.Social.Google.Drive.Models.Files {
    
    /// <summary>
    /// Class representing a file as returned by the Google Drive API.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.google.com/drive/v3/reference/files#methods</cref>
    /// </see>
    public class DriveFile : DriveObject {

        #region Properties

        /// <summary>
        /// Gets the unique ID of the file.
        /// </summary>
        public string Id { get; private set; }

        /// <summary>
        /// Gets the name of the file. This is not necessarily unique within a folder. Note that for immutable items
        /// such as the top level folders of Team Drives, My Drive root folder, and Application Data folder the name is
        /// constant.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Gets the MIME type of the file. Drive will attempt to automatically detect an appropriate value from
        /// uploaded content if no value is provided. The value cannot be changed unless a new revision is uploaded.
        /// </summary>
        public string MimeType { get; private set; }

        /// <summary>
        /// Gets whether the file represents a Google Apps folder.
        /// </summary>
        public bool IsFolder {
            get { return MimeType == "application/vnd.google-apps.folder"; }
        }

        /// <summary>
        /// Gets whether the file represents a Google Apps document.
        /// </summary>
        public bool IsDocument {
            get { return MimeType == "application/vnd.google-apps.document"; }
        }

        /// <summary>
        /// Gets whether the file represents a Google Apps spreadsheet.
        /// </summary>
        public bool IsSpreadsheet {
            get { return MimeType == "application/vnd.google-apps.spreadsheet"; }
        }

        /// <summary>
        /// Gets a short description of the file.
        /// </summary>
        public string Description { get; private set; }

        /// <summary>
        /// Gets whether the user has starred the file.
        /// </summary>
        public bool IsStarred { get; private set; }

        /// <summary>
        /// Gets whether the file has been trashed, either explicitly or from a trashed parent folder. Only the owner
        /// may trash a file, and other users cannot see files in the owner's trash.
        /// </summary>
        public bool IsTrashed { get; private set; }

        /// <summary>
        /// Gets whether the file has been explicitly trashed, as opposed to recursively trashed from a parent folder.
        /// </summary>
        public bool IsExplicitlyTrashed { get; private set; }

        // TODO: Add support for the "parents" property
        // TODO: Add support for the "properties" property
        // TODO: Add support for the "appProperties" property
        // TODO: Add support for the "spaces" property

        /// <summary>
        /// Gets a monotonically increasing version number for the file. This reflects every change made to the file on
        /// the server, even those not visible to the user.
        /// </summary>
        public string Version { get; private set; }

        /// <summary>
        /// Gets a link for downloading the content of the file in a browser. This is only available for files with
        /// binary content in Drive.
        /// </summary>
        public string WebContentLink { get; private set; }

        /// <summary>
        /// Gets a link for opening the file in a relevant Google editor or viewer in a browser.
        /// </summary>
        public string WebViewLink { get; private set; }

        /// <summary>
        /// Gets a static, unauthenticated link to the file's icon.
        /// </summary>
        public string IconLink { get; private set; }

        /// <summary>
        /// Gets a short-lived link to the file's thumbnail, if available. Typically lasts on the order of hours. Only
        /// populated when the requesting app can access the file's content.
        /// </summary>
        public string ThumbnailLink { get; private set; }

        // TODO: Add support for the "viewedByMe" property
        // TODO: Add support for the "viewedByMeTime" property

        /// <summary>
        /// Gets the time at which the file was created.
        /// </summary>
        public EssentialsDateTime CreatedTime { get; private set; }

        /// <summary>
        /// Gets the last time the file was modified by anyone.
        /// </summary>
        public EssentialsDateTime ModifiedTime { get; private set; }

        // TODO: Add support for the "modifiedByMeTime" property
        // TODO: Add support for the "sharedWithMeTime" property
        // TODO: Add support for the "sharingUser" property
        // TODO: Add support for the "owners" property

        /// <summary>
        /// Gets the owners of the file. Currently, only certain legacy files may have more than one owner. Not
        /// populated for Team Drive files.
        /// </summary>
        public DriveUser[] Owners { get; private set; }

        // TODO: Add support for the "lastModifyingUser" property
        // TODO: Add support for the "shared" property
        // TODO: Add support for the "ownedByMe" property
        // TODO: Add support for the "viewersCanCopyContent" property
        // TODO: Add support for the "writersCanShare" property
        // TODO: Add support for the "permissions" property
        // TODO: Add support for the "folderColorRgb" property
        // TODO: Add support for the "originalFilename" property
        // TODO: Add support for the "fullFileExtension" property
        // TODO: Add support for the "fileExtension" property
        // TODO: Add support for the "md5Checksum" property
        // TODO: Add support for the "size" property
        // TODO: Add support for the "quotaBytesUsed" property
        // TODO: Add support for the "headRevisionId" property
        // TODO: Add support for the "contentHints" property
        // TODO: Add support for the "imageMediaMetadata" property
        // TODO: Add support for the "videoMediaMetadata" property
        // TODO: Add support for the "capabilities" property
        // TODO: Add support for the "isAppAuthorized" property
        // TODO: Add support for the "hasThumbnail" property
        // TODO: Add support for the "thumbnailVersion" property
        // TODO: Add support for the "modifiedByMe" property
        // TODO: Add support for the "trashingUser" property
        // TODO: Add support for the "trashedTime" property
        // TODO: Add support for the "teamDriveId" property
        // TODO: Add support for the "hasAugmentedPermissions" property

        #endregion

        #region Constructors

        protected DriveFile(JObject obj) : base(obj) {
            Id = obj.GetString("id");
            Name = obj.GetString("name");
            MimeType = obj.GetString("mimeType");
            Description = obj.GetString("description");
            IsStarred = obj.GetBoolean("starred");
            IsTrashed = obj.GetBoolean("trashed");
            IsExplicitlyTrashed = obj.GetBoolean("explicitlyTrashed");
            // TODO: Add support for the "parents" property
            // TODO: Add support for the "properties" property
            // TODO: Add support for the "appProperties" property
            // TODO: Add support for the "spaces" property
            Version = obj.GetString("version");
            WebContentLink = obj.GetString("webContentLink");
            WebViewLink = obj.GetString("webViewLink");
            IconLink = obj.GetString("iconLink");
            ThumbnailLink = obj.GetString("thumbnailLink");
            // TODO: Add support for the "viewedByMe" property
            // TODO: Add support for the "viewedByMeTime" property
            CreatedTime = obj.GetString("createdTime", EssentialsDateTime.Parse);
            ModifiedTime = obj.GetString("modifiedTime", EssentialsDateTime.Parse);
            // TODO: Add support for the "modifiedByMeTime" property
            // TODO: Add support for the "sharedWithMeTime" property
            // TODO: Add support for the "sharingUser" property
            // TODO: Add support for the "owners" property
            Owners = obj.GetArrayItems("owners", DriveUser.Parse);
            // TODO: Add support for the "lastModifyingUser" property
            // TODO: Add support for the "shared" property
            // TODO: Add support for the "ownedByMe" property
            // TODO: Add support for the "viewersCanCopyContent" property
            // TODO: Add support for the "writersCanShare" property
            // TODO: Add support for the "permissions" property
            // TODO: Add support for the "folderColorRgb" property
            // TODO: Add support for the "originalFilename" property
            // TODO: Add support for the "fullFileExtension" property
            // TODO: Add support for the "fileExtension" property
            // TODO: Add support for the "md5Checksum" property
            // TODO: Add support for the "size" property
            // TODO: Add support for the "quotaBytesUsed" property
            // TODO: Add support for the "headRevisionId" property
            // TODO: Add support for the "contentHints" property
            // TODO: Add support for the "imageMediaMetadata" property
            // TODO: Add support for the "videoMediaMetadata" property
            // TODO: Add support for the "capabilities" property
            // TODO: Add support for the "isAppAuthorized" property
            // TODO: Add support for the "hasThumbnail" property
            // TODO: Add support for the "thumbnailVersion" property
            // TODO: Add support for the "modifiedByMe" property
            // TODO: Add support for the "trashingUser" property
            // TODO: Add support for the "trashedTime" property
            // TODO: Add support for the "teamDriveId" property
            // TODO: Add support for the "hasAugmentedPermissions" property
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="DriveFile"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="DriveFile"/>.</returns>
        public static DriveFile Parse(JObject obj) {
            return obj == null ? null : new DriveFile(obj);
        }

        #endregion

    }

}