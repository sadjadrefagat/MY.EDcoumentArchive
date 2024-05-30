using System;
using System.Data.SqlClient;
using System.Linq;
using static MY.ConditionalExpressionClass;

namespace MY
{
    sealed public class ServiceFactory<T> where T : BaseEntity
    {
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

        //static public List<T> FetchByFilter(params NameAndValue[] primaryKeysAndValues)
        //{
        //    var typeDescriptor = new EntityTypeDescriptor<T>();

        //    var obj = Activator.CreateInstance<T>();

        //    var fields = typeDescriptor.GetFields().ToArray();

        //    var selectList = "";
        //    foreach (var field in fields)
        //    {
        //        if (!string.IsNullOrEmpty(selectList))
        //            selectList += ", ";
        //        selectList += $"[{field}]";
        //    }
        //    var primaryKeys = typeDescriptor.GetPrimaryKeys();
        //    var whereClause = "";
        //    foreach (var primaryKey in primaryKeys)
        //    {
        //        if (!string.IsNullOrEmpty(whereClause))
        //            whereClause += " AND ";
        //        whereClause += $"([{primaryKey.Key}] = @{primaryKey.Key})";
        //    }

        //    var query = $"SELECT {selectList} FROM [{obj.__MappingInfo.SchemaName}].[{obj.__MappingInfo.TableName}] WHERE {whereClause}";

        //    using (var connection = new SqlConnection(AppConfig.ServiceFactoryConfig.ApplicationConfig.DatabaseConnection.ToString()))
        //    {
        //        connection.Open();
        //        using (var command = new SqlCommand(query, connection))
        //        {
        //            foreach (var primaryKey in primaryKeys)
        //            {
        //                var value = primaryKeysAndValues.Where(pk => pk.Name == primaryKey.Key).FirstOrDefault();
        //                if (value != null)
        //                    command.Parameters.AddWithValue($"@{primaryKey.Key}", value.Value);
        //            }

        //            var reader = command.ExecuteReader();
        //            if (reader.HasRows)
        //            {
        //                reader.Read();
        //                foreach (var field in fields)
        //                    typeDescriptor.SetValue(obj, field, reader[field]);
        //            }
        //        }
        //        connection.Close();
        //    }
        //    return null;
        //}

        static public ConditionalExpression FetchByFilter()
        {
            var a = new[]
            {
                new
                {
                    ID = 1,
                    Name = "Ali",
                }
            };

            //predicate.

            //var whereClause = LambdaExpressionToQueryString(predicate);

            //var typeDescriptor = new EntityTypeDescriptor<T>();

            //var obj = Activator.CreateInstance<T>();

            //var fields = typeDescriptor.GetFields().ToArray();

            //var selectList = "";
            //foreach (var field in fields)
            //{
            //    if (!string.IsNullOrEmpty(selectList))
            //        selectList += ", ";
            //    selectList += $"[{field}]";
            //}

            //var query = $"SELECT {selectList} FROM [{obj.__MappingInfo.SchemaName}].[{obj.__MappingInfo.TableName}] WHERE {whereClause}";

            //using (var connection = new SqlConnection(AppConfig.ServiceFactoryConfig.ApplicationConfig.DatabaseConnection.ToString()))
            //{
            //    connection.Open();
            //    using (var command = new SqlCommand(query, connection))
            //    {

            //        var reader = command.ExecuteReader();
            //        if (reader.HasRows)
            //        {
            //            reader.Read();
            //            foreach (var field in fields)
            //                typeDescriptor.SetValue(obj, field, reader[field]);
            //        }
            //    }
            //    connection.Close();
            //}
            return null;
        }

        static public bool Insert(ref T obj)
        {
            try
            {
                if (obj == null)
                    throw new Exception("خطای رفرنس به نال");
                var typeDescriptor = new EntityTypeDescriptor<T>();
                var primaryKeys = typeDescriptor.GetPrimaryKeys();

                if (primaryKeys.Count == 0)
                    throw new Exception($"کلید اصلی برای موجودیت «{typeDescriptor.Name}» تعریف نشده است.");

                Insert(ref obj, typeDescriptor);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
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
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            return true;
        }

        static private void Insert(ref T obj, EntityTypeDescriptor<T> typeDescriptor)
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

            using (var connection = new SqlConnection(AppConfig.ServiceFactoryConfig.ApplicationConfig.DatabaseConnection.ToString()))
            {
                connection.Open();
                using (var command = new SqlCommand(query, connection))
                {
                    foreach (var param in fields)
                        command.Parameters.AddWithValue(param, typeDescriptor.GetValue(obj, param));
                    var identityObj = command.ExecuteScalar();
                    var identityProperty = typeDescriptor.GetIdentityProperty();
                    if (!string.IsNullOrEmpty(identityProperty))
                        typeDescriptor.SetValue(obj, identityProperty, identityObj);
                }
                connection.Close();
            }
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
