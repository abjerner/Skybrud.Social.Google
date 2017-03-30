using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Google.Drive.Objects.Files {

    public class DriveFileList : DriveObject {

        #region Properties

        /// <summary>
        /// Gets the string value representing the kind of the object. Will always be <code>drive#fileList</code>.
        /// </summary>
        public string SelfLink { get; private set; }
        
        /// <summary>
        /// Gets the page token for the next page of files. This will be absent if the end of the files list has been
        /// reached. If the token is rejected for any reason, it should be discarded, and pagination should be
        /// restarted from the first page of results.
        /// </summary>
        public string NextPageToken { get; private set; }

        /// <summary>
        /// Gets the list of files. If <see cref="NextPageToken"/> is populated, then this list may be incomplete and
        /// an additional page of results should be fetched.
        /// </summary>
        public DriveFile[] Files { get; private set; }

        // TODO: Add support for the "incompleteSearch" property

        #endregion

        #region Constructors

        protected DriveFileList(JObject obj) : base(obj) {
            SelfLink = obj.GetString("selfLink");
            NextPageToken = obj.GetString("nextPageToken");
            Files = obj.GetArrayItems("files", DriveFile.Parse);
            // TODO: Add support for the "incompleteSearch" property
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="DriveFileList"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>An instance of <see cref="DriveFileList"/>.</returns>
        public static DriveFileList Parse(JObject obj) {
            return obj == null ? null : new DriveFileList(obj);
        }

        #endregion
    
    }

}