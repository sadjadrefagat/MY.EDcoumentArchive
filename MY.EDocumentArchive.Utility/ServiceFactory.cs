using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;

namespace MY
{
    sealed public class ServiceFactory<T> where T : BaseEntity
    {
        private SqlTransaction _transaction;

        public ServiceFactory()
        {
            _transaction = null;
        }

        public ServiceFactory(ServiceTransaction transaction)
            : this()
        {
            if (transaction != null)
                _transaction = transaction.GetTransaction();
        }

        public bool Insert(ref T obj, bool forceInsert = true, ServiceTransaction transaction = null)
        {
            if (obj != null)
                return Insert(ref obj, transaction);
            return false;
        }

        static public T FetchByPrimaryKeys(params NameAndValue[] primaryKeysAndValues)
        {
            var typeDescriptor = new EntityTypeDescriptor<T>();

            var obj = Activator.CreateInstance<T>();

            var fields = typeDescriptor.GetFields().ToArray();

            var selectList = "";
            foreach (var field in fields)
            {
                if (!string.IsNullOrEmpty(selectList))
                    selectList += ", ";
                selectList += $"[{field}]";
            }
            var primaryKeys = typeDescriptor.GetPrimaryKeys();
            var whereClause = "";
            foreach (var primaryKey in primaryKeys)
            {
                if (!string.IsNullOrEmpty(whereClause))
                    whereClause += " AND ";
                whereClause += $"([{primaryKey.Key}] = @{primaryKey.Key})";
            }

            var query = $"SELECT {selectList} FROM [{obj.__MappingInfo.SchemaName}].[{obj.__MappingInfo.TableName}] WHERE {whereClause}";

            using (var connection = new SqlConnection(AppConfig.ServiceFactoryConfig.ApplicationConfig.DatabaseConnection.ToString()))
            {
                connection.Open();
                using (var command = new SqlCommand(query, connection))
                {
                    foreach (var primaryKey in primaryKeys)
                    {
                        var value = primaryKeysAndValues.Where(pk => pk.Name == primaryKey.Key).FirstOrDefault();
                        if (value != null)
                            command.Parameters.AddWithValue($"@{primaryKey.Key}", value.Value);
                    }

                    var reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        foreach (var field in fields)
                            typeDescriptor.SetValue(obj, field, reader[field]);
                    }
                }
                connection.Close();
            }
            return obj;
        }

        static public IList<T> FetchAll()
        {
            return FetchByFilter(null);
        }

        static public IList<T> FetchByFilter(Expression<Func<T, bool>> expression)
        {
            string parameterName = "[T]";
            string whereClause;
            var values = new Dictionary<string, object>();
            if (expression == null)
            {
                whereClause = "1 = @Val1";
                values.Add("@Val1", 1);
            }
            else if (expression.NodeType == ExpressionType.Lambda)
            {
                parameterName = expression.Parameters.First().Name;
                var visitor = new LambdaExpressionVisitor(parameterName);
                visitor.Visit(expression.Body);
                whereClause = visitor.VisitString;
                values = visitor.Values;
            }
            else
                throw new Exception("Invalid Expression.");

            var typeDescriptor = new EntityTypeDescriptor<T>();
            var fields = typeDescriptor.GetFields().ToArray();
            var selectList = "";
            foreach (var field in fields)
            {
                if (!string.IsNullOrEmpty(selectList))
                    selectList += ", ";
                selectList += $"[{field}]";
            }

            var obj = Activator.CreateInstance<T>();
            var result = new List<T>();

            var query = $"SELECT {selectList} FROM [{obj.__MappingInfo.SchemaName}].[{obj.__MappingInfo.TableName}] AS [{parameterName}] WHERE ({whereClause})";

            using (var connection = new SqlConnection(AppConfig.ServiceFactoryConfig.ApplicationConfig.DatabaseConnection.ToString()))
            {
                connection.Open();
                using (var command = new SqlCommand(query, connection))
                {
                    foreach (var value in values)
                        command.Parameters.AddWithValue(value.Key, value.Value);

                    var reader = command.ExecuteReader();
                    while (reader.HasRows)
                    {
                        reader.Read();
                        var item = Activator.CreateInstance<T>();
                        foreach (var field in fields)
                            typeDescriptor.SetValue(item, field, reader[field]);
                        result.Add(item);
                    }
                }
                connection.Close();
            }
            return result;
        }

        static public bool Insert(ref T obj, ServiceTransaction transaction = null)
        {
            try
            {
                if (obj == null)
                    throw new Exception("خطای رفرنس به نال");
                var typeDescriptor = new EntityTypeDescriptor<T>();
                var primaryKeys = typeDescriptor.GetPrimaryKeys();

                if (primaryKeys.Count == 0)
                    throw new Exception($"کلید اصلی برای موجودیت «{typeDescriptor.Name}» تعریف نشده است.");

                Insert(ref obj, typeDescriptor, transaction);
            }
            catch (SqlException ex)
            {
                if (transaction != null)
                    transaction.AddErrorMessage(DatabaseErrorTranslator.GetErrorMessage(ex));
                else
                    AppConfig.ShowErrorMessage(DatabaseErrorTranslator.GetErrorMessage(ex));
            }
            catch (Exception ex)
            {
                if (transaction != null)
                    transaction.AddErrorMessage(ex.Message);
                else
                    AppConfig.ShowErrorMessage(ex.Message);
            }
            return true;
        }

        static public bool Update(T obj)
        {
            try
            {
                if (obj == null)
                    throw new Exception("خطای رفرنس به نال");
                var typeDescriptor = new EntityTypeDescriptor<T>();
                var primaryKeys = typeDescriptor.GetPrimaryKeys();

                if (primaryKeys.Count == 0)
                    throw new Exception($"کلید اصلی برای موجودیت «{typeDescriptor.Name}» تعریف نشده است.");

                Update(obj, typeDescriptor);
            }
            catch (Exception ex)
            {
                AppConfig.ShowErrorMessage(ex.Message);
            }
            return true;
        }

        static private void Insert(ref T obj, EntityTypeDescriptor<T> typeDescriptor, ServiceTransaction transaction = null)
        {
            var fields = typeDescriptor.GetInsertFields().ToArray();

            var fieldNames = "";
            var paramNames = "";
            foreach (var field in fields)
            {
                if (!string.IsNullOrEmpty(fieldNames))
                    fieldNames += ", ";
                fieldNames += $"[{field}]";
                if (!string.IsNullOrEmpty(paramNames))
                    paramNames += ", ";
                paramNames += $"@{field}";
            }

            var query = $"INSERT INTO [{obj.__MappingInfo.SchemaName}].[{obj.__MappingInfo.TableName}] ({fieldNames}) VALUES ({paramNames}); SELECT CAST(SCOPE_IDENTITY() AS BIGINT);";

            SqlConnection connection;
            if (transaction == null)
            {
                connection = new SqlConnection(AppConfig.ServiceFactoryConfig.ApplicationConfig.DatabaseConnection.ToString());
                connection.Open();
            }
            else
                connection = transaction.GetConnection();
            using (var command = new SqlCommand(query, connection))
            {
                if (transaction != null)
                    command.Transaction = transaction.GetTransaction();
                foreach (var param in fields)
                    command.Parameters.AddWithValue(param, typeDescriptor.GetValue(obj, param));
                var identityObj = command.ExecuteScalar();
                var identityProperty = typeDescriptor.GetIdentityProperty();
                if (!string.IsNullOrEmpty(identityProperty))
                    typeDescriptor.SetValue(obj, identityProperty, identityObj);
            }
            if (transaction == null)
                connection.Close();
        }

        static private void Update(T obj, EntityTypeDescriptor<T> typeDescriptor)
        {
            var fields = typeDescriptor.GetInsertFields().ToArray();

            var updateList = "";
            foreach (var field in fields)
            {
                if (!string.IsNullOrEmpty(updateList))
                    updateList += ", ";
                updateList += $"([{field}] = @{field})";
            }
            var primaryKeys = typeDescriptor.GetPrimaryKeys();
            var whereClause = "";
            foreach (var primaryKey in primaryKeys)
            {
                if (!string.IsNullOrEmpty(whereClause))
                    whereClause += " AND ";
                whereClause += $"[{primaryKey.Key}] = @{primaryKey.Key}";
            }

            var query = $"UPDATE [{obj.__MappingInfo.SchemaName}].[{obj.__MappingInfo.TableName}] SET {updateList} WHERE {whereClause}";

            using (var connection = new SqlConnection(AppConfig.ServiceFactoryConfig.ApplicationConfig.DatabaseConnection.ToString()))
            {
                connection.Open();
                using (var command = new SqlCommand(query, connection))
                {
                    foreach (var primaryKey in primaryKeys)
                        command.Parameters.AddWithValue($"@{primaryKey.Key}", typeDescriptor.GetValue(obj, primaryKey.Key));

                    foreach (var param in fields)
                        if (!command.Parameters.Contains($"@{param}"))
                            command.Parameters.AddWithValue(param, typeDescriptor.GetValue(obj, param));
                    var identityObj = command.ExecuteScalar();

                }
                connection.Close();
            }
        }

        static public void DeleteByPrimaryKeys(params NameAndValue[] primaryKeysAndValues)
        {
            var typeDescriptor = new EntityTypeDescriptor<T>();
            var primaryKeys = typeDescriptor.GetPrimaryKeys();
            var whereClause = "";
            var obj = Activator.CreateInstance<T>();
            foreach (var primaryKey in primaryKeys)
            {
                if (!string.IsNullOrEmpty(whereClause))
                    whereClause += " AND ";
                whereClause += $"([{primaryKey.Key}] = @{primaryKey.Key})";
            }

            var query = $"DELETE FROM [{obj.__MappingInfo.SchemaName}].[{obj.__MappingInfo.TableName}] WHERE {whereClause}";

            using (var connection = new SqlConnection(AppConfig.ServiceFactoryConfig.ApplicationConfig.DatabaseConnection.ToString()))
            {
                connection.Open();
                using (var command = new SqlCommand(query, connection))
                {
                    foreach (var primaryKey in primaryKeys)
                    {
                        var value = primaryKeysAndValues.Where(pk => pk.Name == primaryKey.Key).FirstOrDefault();
                        if (value != null)
                            command.Parameters.AddWithValue($"@{primaryKey.Key}", value.Value);
                    }
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
    }
}
