namespace Skybrud.Social.Google.Drive.Scopes {

    public static class DriveScopes {

        public static readonly DriveScope Default = new DriveScope("https://www.googleapis.com/auth/drive", "View and manage the files in your Google Drive");


        public static readonly DriveScope AppData = new DriveScope("https://www.googleapis.com/auth/drive.appdata", "View and manage its own configuration data in your Google Drive");


        public static readonly DriveScope AppsReadonly = new DriveScope("https://www.googleapis.com/auth/drive.apps.readonly", "View your Google Drive apps");


        public static readonly DriveScope File = new DriveScope("https://www.googleapis.com/auth/drive.file", "View and manage Google Drive files and folders that you have opened or created with this app");


        public static readonly DriveScope Metadata = new DriveScope("https://www.googleapis.com/auth/drive.metadata", "View and manage metadata of files in your Google Drive");


        public static readonly DriveScope MetadataReadonly = new DriveScope("https://www.googleapis.com/auth/drive.metadata.readonly", "View metadata for files in your Google Drive");


        public static readonly DriveScope PhotosReadonly = new DriveScope("https://www.googleapis.com/auth/drive.photos.readonly", "View the photos, videos and albums in your Google Photos");


        public static readonly DriveScope Readonly = new DriveScope("https://www.googleapis.com/auth/drive.readonly", "View the files in your Google Drive");


        public static readonly DriveScope Scripts = new DriveScope("https://www.googleapis.com/auth/drive.scripts", "Modify your Google Apps Script scripts' behavior");

    }

}