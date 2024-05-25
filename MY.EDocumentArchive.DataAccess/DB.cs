using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace MY
{
    sealed public class DB
    {
        private ApplicationConfig applicationConfig;
        private SqlTransaction transaction = null;

        public DB(ApplicationConfig config, SqlTransaction transaction = null)
        {
            applicationConfig = config;
            this.transaction = transaction;
        }

        public List<T> GetList<T>(SqlCommand command) where T : class
        {
            var list = new List<T>();
            SqlConnection connection = new SqlConnection(applicationConfig.DatabaseConnection.ToString());
            if (transaction != null)
                connection = transaction.Connection;
            else
                connection.Open();
            //command.Transaction = transaction;
            list = connection.Query<T>(new CommandDefinition()).ToList();
            if (transaction == null)
                connection.Close();
            return list;
        }
    }
}