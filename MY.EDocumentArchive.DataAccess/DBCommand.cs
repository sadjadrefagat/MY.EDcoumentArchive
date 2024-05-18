using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace MY.EDocumentArchive.DataAccess
{
    sealed public class DBCommand
    {
        private Utility.ApplicationConfig applicationConfig;
        private SqlTransaction transaction = null;

        public DBCommand(Utility.ApplicationConfig config, SqlTransaction transaction = null)
        {
            applicationConfig = config;
            this.transaction = transaction;
        }

        public List<T> GetList<T>(CommandDefinition command) where T : class
        {
            var list = new List<T>();
            SqlConnection connection = new SqlConnection(applicationConfig.DatabaseConnection.ToString());
            if (transaction != null)
                connection = transaction.Connection;
            else
                connection.Open();
            //command.Transaction = transaction;
            list = connection.Query<T>(command).ToList();
            if (transaction == null)
                connection.Close();
            return list;
        }
    }
}