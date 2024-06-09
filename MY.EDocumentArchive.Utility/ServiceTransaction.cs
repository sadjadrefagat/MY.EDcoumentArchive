using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MY
{
    sealed public class ServiceTransaction
    {
        private SqlConnection connection;
        private SqlTransaction transaction;

        private ServiceTransaction()
        {
            connection = new SqlConnection(AppConfig.ServiceFactoryConfig.ApplicationConfig.DatabaseConnection.ToString());
            connection.Open();
            transaction = connection.BeginTransaction();
            hasError = false;
            errorMessages = new List<string>();
        }

        static public ServiceTransaction CreateTransaction()
        {
            return new ServiceTransaction();
        }

        private bool hasError;

        public bool HasError
        {
            get { return hasError; }
        }

        private List<string> errorMessages;

        public List<string> GetErrorMessages()
        {
            return errorMessages;
        }

        public void AddErrorMessage(string message)
        {
            hasError = true;
            errorMessages.Add(message);
        }

        internal SqlTransaction GetTransaction()
        {
            return transaction;
        }

        public void Finish()
        {
            if (hasError)
                Rollback();
            else
                Commit();
        }

        public void Commit()
        {
            transaction.Commit();
        }

        public void Rollback()
        {
            transaction.Rollback();
        }

        internal SqlConnection GetConnection()
        {
            return connection;
        }
    }
}
