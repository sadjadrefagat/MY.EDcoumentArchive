namespace MY.EDocumentArchive.Utility
{
    sealed public class SqlServerDatabaseConnection
    {
        public string ServerAddress { get; set; }
        public int Port { get; set; } = 1433;
        public string DatabaseName { get; set; }
        public ServerAuthenticate Login { get; set; }
    }
}