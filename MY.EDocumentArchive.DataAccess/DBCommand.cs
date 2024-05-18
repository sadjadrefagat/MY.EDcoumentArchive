using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace MY.EDocumentArchive.DataAccess
{
    static public class DBCommand
    {
        static public List<T> GetList<T>() where T : class
        {
            using (var connection = new SqlConnection(""))
            {
                var cd = new CommandDefinition();
                cd.
                connection.Open();
                connection.Query<T>(cd).ToList();
                connection.Close();
            }

            return null;
        }
    }
}
