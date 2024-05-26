namespace MY
{
    sealed public class SqlServerDatabaseConnection
    {
        public string ServerAddress { get; set; }
        public int Port { get; set; } = 1433;
        public string DatabaseName { get; set; }
        public ServerAuthenticate Login { get; set; }

        public override string ToString()
        {
            return $"server={ServerAddress},{Port}; initial catalog={DatabaseName}; user id={Login.Username}; password={Login.Password}";
        }
    }
}