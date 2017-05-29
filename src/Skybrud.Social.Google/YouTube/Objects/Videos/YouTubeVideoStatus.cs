using System;
using Newtonsoft.Json.Linq;
using Skybrud.Social.Google.Common.Objects;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Google.YouTube.Objects.Videos {

    /// <summary>
    /// Class representing the <code>status</code> part of a YouTube video.
    /// </summary>
    /// <see>
    ///     <cref>https://developers.google.com/youtube/v3/docs/videos#status</cref>
    /// </see>
    public class YouTubeVideoStatus : GoogleApiObject {

        #region Properties

        public YouTubeVideoUploadStatus UploadStatus { get; private set; }

        public YouTubeVideoFailureReason? FailureReason { get; private set; }

        public YouTubeVideoRejectionReason? RejectionReason { get; private set; }

        public YouTubePrivacyStatus PrivacyStatus { get; private set; }

        public YouTubeVideoLicense License { get; private set; }

        public bool IsEmbeddable { get; private set; }

        public bool PublicStatsViewable { get; private set; }

        #endregion

        #region Constructor

        protected YouTubeVideoStatus(JObject obj) : base(obj) {


            // Parse the upload status
            YouTubeVideoUploadStatus uploadStatus;
            string strUploadStatus = obj.GetString("uploadStatus");
            if (!Enum.TryParse(strUploadStatus, true, out uploadStatus)) {
                throw new Exception("Unknown upload status \"" + strUploadStatus + "\" - please create an issue so it can be fixed https://github.com/abjerner/Skybrud.Social.Google/issues/new");
            }

            // Parse the failure reason
            YouTubeVideoFailureReason? failureReason = null;
            if (obj.HasValue("failureReason")) {
                YouTubeVideoFailureReason reason;
                string strReason = obj.GetString("failureReason");
                if (Enum.TryParse(strReason, out reason)) {
                    failureReason = reason;
                } else {
                    throw new Exception("Unknown failure reason \"" + strReason + "\" - please create an issue so it can be fixed https://github.com/abjerner/Skybrud.Social.Google/issues/new");
                }
            }

            // Parse the rejection reason
            YouTubeVideoRejectionReason? rejectionReason = null;
            if (obj.HasValue("rejectionReason")) {
                YouTubeVideoRejectionReason reason;
                string strReason = obj.GetString("rejectionReason");
                if (Enum.TryParse(strReason, out reason)) {
                    rejectionReason = reason;
                } else {
                    throw new Exception("Unknown rejection reason \"" + strReason + "\" - please create an issue so it can be fixed https://github.com/abjerner/Skybrud.Social.Google/issues/new");
                }
            }

            // Parse the privacy status
            YouTubePrivacyStatus privacyStatus;
            string strPrivacyStatus = obj.GetString("privacyStatus");
            if (!Enum.TryParse(strPrivacyStatus, true, out privacyStatus)) {
                throw new Exception("Unknown privacy status \"" + strPrivacyStatus + "\" - please create an issue so it can be fixed https://github.com/abjerner/Skybrud.Social.Google/issues/new");
            }

            // Parse the privacy status
            YouTubeVideoLicense videoLicense;
            string strLicense = obj.GetString("license");
            if (!Enum.TryParse(strLicense, true, out videoLicense)) {
                throw new Exception("Unknown license \"" + strLicense + "\" - please create an issue so it can be fixed https://github.com/abjerner/Skybrud.Social.Google/issues/new");
            }

            // Update the properties
            UploadStatus = uploadStatus;
            PrivacyStatus = privacyStatus;
            FailureReason = failureReason;
            RejectionReason = rejectionReason;
            License = videoLicense;
            IsEmbeddable = obj.GetBoolean("embeddable");
            PublicStatsViewable = obj.GetBoolean("publicStatsViewable");

        }

        #endregion

        #region Static methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="YouTubeVideoStatus"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to parse.</param>
        /// <returns>An instance of <see cref="YouTubeVideoStatus"/>.</returns>
        public static YouTubeVideoStatus Parse(JObject obj) {
            return obj == null ? null : new YouTubeVideoStatus(obj);
        }

        #endregion

    }

}