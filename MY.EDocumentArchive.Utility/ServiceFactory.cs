using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;

namespace MY
{
    sealed public class ServiceFactory<T> where T : BaseEntity
    {
        public static T FetchByPrimaryKey(object primaryKeyValue)
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
            var primaryKey = typeDescriptor.GetPrimaryKeyProperty();
            var query = $"SELECT {selectList} FROM [{obj.__MappingInfo.SchemaName}].[{obj.__MappingInfo.TableName}] WHERE ([{primaryKey}] = @PrimaryKey)";

            using (var connection = new SqlConnection("server=192.168.1.54; initial catalog=MY.EDocumentArchive; user id=sa; password=Admin+1000"))
            {
                connection.Open();
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PrimaryKey", primaryKeyValue);
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

        static public bool Save(ref T obj)
        {
            try
            {
                if (obj == null)
                    throw new Exception("خطای رفرنس به نال");
                var typeDescriptor = new EntityTypeDescriptor<T>();
                var primaryKey = typeDescriptor.GetPrimaryKeyProperty();
                if (string.IsNullOrEmpty(primaryKey))
                    throw new Exception($"کلید اصلی برای موجودیت «{typeDescriptor.Name}» تعریف نشده است.");
                var primaryKeyValue = typeDescriptor.GetValue<long>(obj, primaryKey);

                if (primaryKeyValue == 0L)
                    Insert(ref obj, typeDescriptor);
                else
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

            using (var connection = new SqlConnection("server=192.168.1.54; initial catalog=MY.EDocumentArchive; user id=sa; password=Admin+1000"))
            {
                connection.Open();
                using (var command = new SqlCommand(query, connection))
                {
                    foreach (var param in fields)
                        command.Parameters.AddWithValue(param, typeDescriptor.GetValue(obj, param));
                    var identityObj = command.ExecuteScalar();
                    typeDescriptor.SetValue(obj, typeDescriptor.GetPrimaryKeyProperty(), identityObj);

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
                updateList += $"[{field}] = @{field}";
            }
            var primaryKey = typeDescriptor.GetPrimaryKeyProperty();
            var query = $"UPDATE [{obj.__MappingInfo.SchemaName}].[{obj.__MappingInfo.TableName}] SET {updateList} WHERE ([{primaryKey}] = @PrimaryKey)";

            using (var connection = new SqlConnection("server=192.168.1.54; initial catalog=MY.EDocumentArchive; user id=sa; password=Admin+1000"))
            {
                connection.Open();
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PrimaryKey", typeDescriptor.GetValue(obj, primaryKey));
                    foreach (var param in fields)
                        command.Parameters.AddWithValue(param, typeDescriptor.GetValue(obj, param));
                    var identityObj = command.ExecuteScalar();

                }
                connection.Close();
            }
        }


    }
}
