namespace MY.EDocumentArchive.Utility
{
    sealed public class ApplicationConfig
    {
        public SqlServerDatabaseConnection DatabaseConnection { get; set; }
        public ProductUserInfo ProductUser { get; set; }
    }
}