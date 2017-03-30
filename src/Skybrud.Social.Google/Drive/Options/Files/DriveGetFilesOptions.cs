using System;
using Skybrud.Social.Google.Drive.Objects.Files;
using Skybrud.Social.Http;
using Skybrud.Social.Interfaces.Http;

namespace Skybrud.Social.Google.Drive.Options.Files {

    public class DriveGetFilesOptions : IHttpGetOptions {

        #region Properties

        /// <summary>
        /// Gets or sets a comma-separated list of sort keys. Valid keys are <code>createdTime</code>,
        /// <code>folder</code>, <code>modifiedByMeTime</code>, <code>modifiedTime</code>, <code>name</code>,
        /// <code>quotaBytesUsed</code>, <code>recency</code>, <code>sharedWithMeTime</code>, <code>starred</code>, and
        /// <code>viewedByMeTime</code>.
        /// 
        /// Each key sorts ascending by default, but may be reversed with the <code>desc</code> modifier. Example
        /// usage: <code>?orderBy=folder,modifiedTime desc,name</code>. Please note that there is a current limitation
        /// for users with approximately one million files in which the requested sort order is ignored.
        /// </summary>
        public string OrderBy { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of files to return per page. Acceptable values are <code>1</code> to
        /// <code>1000</code>, inclusive (Default: <code>100</code>).
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// Gets or sets the token for continuing a previous list request on the next page. This should be set to the
        /// value of <see cref="DriveFileList.NextPageToken"/> from the previous response.
        /// </summary>
        public string PageToken { get; set; }
        
        /// <summary>
        /// Gets or sets a query for filtering the file results. See the
        /// <a href="https://developers.google.com/drive/v3/web/search-parameters">Search for Files</a> guide for
        /// supported syntax.
        /// </summary>
        public string Query { get; set; }

        /// <summary>
        /// Gets or sets a collection of the fields to be returned by the Google Drive API.
        /// </summary>
        public string Fields { get; set; }

        #endregion

        #region Constructors

        public DriveGetFilesOptions() {
            PageSize = 100;
        }

        /// <summary>
        /// Initializes a new instance with the specified <paramref name="pageSize"/>.
        /// </summary>
        /// <param name="pageSize">The maximum number of files to return per page. Acceptable values are <code>1</code>
        /// to <code>1000</code>, inclusive.</param>
        public DriveGetFilesOptions(int pageSize) {
            PageSize = pageSize;
        }

        /// <summary>
        /// Initializes a new instance with the specified <paramref name="pageSize"/> and <paramref name="pageToken"/>.
        /// </summary>
        /// <param name="pageSize">The maximum number of files to return per page. Acceptable values are <code>1</code>
        /// to <code>1000</code>, inclusive.</param>
        /// <param name="pageToken">The token for continuing a previous list request on the next page. This should be
        /// set to the value of <see cref="DriveFileList.NextPageToken"/> from the previous response.</param>
        public DriveGetFilesOptions(int pageSize, string pageToken) {
            PageSize = pageSize;
            PageToken = pageToken;
        }

        #endregion

        #region Member methods

        public IHttpQueryString GetQueryString() {
            
            IHttpQueryString query = new SocialHttpQueryString();

            if (!String.IsNullOrWhiteSpace(OrderBy)) query.Add("orderBy", OrderBy);
            if (PageSize > 0) query.Add("pageSize", PageSize);
            if (!String.IsNullOrWhiteSpace(PageToken)) query.Add("pageToken", PageToken);
            if (!String.IsNullOrWhiteSpace(Query)) query.Add("q", Query);
            if (!String.IsNullOrWhiteSpace(Fields)) query.Add("fields", Fields);

            return query;

        }

        #endregion

    }

}