using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MY.CodeGenerator
{
    public partial class Step1Form : Form, IMessageSupport
    {
        public Step1Form()
        {
            InitializeComponent();
        }

        public string RootPath
        {
            get { return txtRootPath.Text; }
            set { txtRootPath.Text = value; }
        }

        public string NameSpace
        {
            get { return txtNamespace.Text; }
            set { txtNamespace.Text = value; }
        }
        public string ProjectName
        {
            get { return txtProjectName.Text; }
            set { txtProjectName.Text = value; }
        }
        public string ProjectDescription
        {
            get { return txtProjectDescription.Text; }
            set { txtProjectDescription.Text = value; }
        }
        public string ServerAddress
        {
            get { return txtServerAddress.Text; }
            set { txtServerAddress.Text = value; }
        }
        public string Username
        {
            get { return txtUserName.Text; }
            set { txtUserName.Text = value; }
        }
        public string Password
        {
            get { return txtPassword.Text; }
            set { txtPassword.Text = value; }
        }
        public string DatabaseName
        {
            get { return txtDatabaseName.Text; }
            set { txtDatabaseName.Text = value; }
        }

        private string getConnectionString()
        {
            var serverAddress = "";
            var portNumber = 1433;
            if (ServerAddress.Contains(","))
            {
                var parts = ServerAddress.Split(',');
                serverAddress = parts[0].Trim();
                portNumber = int.Parse(parts[1].Trim());
            }
            var appConfig = new ApplicationConfig()
            {
                DatabaseConnection = new SqlServerDatabaseConnection()
                {
                    ServerAddress = serverAddress,
                    Login = new ServerAuthenticate()
                    {
                        Username = Username.Trim(),
                        Password = Password,
                    },
                    DatabaseName = DatabaseName.Trim(),
                    Port = portNumber,
                },
            };
            return appConfig.DatabaseConnection.ToString();
        }

        public bool Message(string inputMessage, string extraData, out string outputMessage)
        {
            outputMessage = null;
            var result = true;
            switch (inputMessage)
            {
                case "TestConnection":
                    try
                    {

                        using (var connection = new SqlConnection(getConnectionString()))
                        {
                            connection.Open();
                            using (var command = new SqlCommand("SELECT 1", connection))
                                command.ExecuteNonQuery();
                            connection.Close();
                            outputMessage = "ارتباط با دیتابیس با موفقیت برقرار شد.";
                        }
                    }
                    catch (Exception ex)
                    {
                        outputMessage = ex.Message;
                        result = false;
                    }
                    break;
                case "SetConnectionString":
                    outputMessage = getConnectionString();
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
