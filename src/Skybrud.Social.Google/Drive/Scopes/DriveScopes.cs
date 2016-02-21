namespace Skybrud.Social.Google.Drive.Scopes {

    public static class DriveScopes {

        public static readonly DriveScope Default = new DriveScope(
            "https://www.googleapis.com/auth/drive",
            "Default",
            "View and manage the files in your Google Drive"
        );

        public static readonly DriveScope AppData = new DriveScope(
            "https://www.googleapis.com/auth/drive.appdata",
            "AppData",
            "View and manage its own configuration data in your Google Drive"
        );

        public static readonly DriveScope AppsReadonly = new DriveScope(
            "https://www.googleapis.com/auth/drive.apps.readonly",
            "Apps (readonly)",
            "View your Google Drive apps"
        );

        public static readonly DriveScope File = new DriveScope(
            "https://www.googleapis.com/auth/drive.file",
            "File",
            "View and manage Google Drive files and folders that you have opened or created with this app"
        );

        public static readonly DriveScope Metadata = new DriveScope(
            "https://www.googleapis.com/auth/drive.metadata",
            "Metadata",
            "View and manage metadata of files in your Google Drive"
        );

        public static readonly DriveScope MetadataReadonly = new DriveScope(
            "https://www.googleapis.com/auth/drive.metadata.readonly",
            "Metadata (readonly)",
            "View metadata for files in your Google Drive"
        );

        public static readonly DriveScope PhotosReadonly = new DriveScope(
            "https://www.googleapis.com/auth/drive.photos.readonly",
            "Photos (readonly)",
            "View the photos, videos and albums in your Google Photos"
        );

        public static readonly DriveScope Readonly = new DriveScope(
            "https://www.googleapis.com/auth/drive.readonly",
            "Files (readonly)",
            "View the files in your Google Drive"
        );

        public static readonly DriveScope Scripts = new DriveScope(
            "https://www.googleapis.com/auth/drive.scripts",
            "Scripts",
            "Modify your Google Apps Script scripts' behavior"
        );

    }

}