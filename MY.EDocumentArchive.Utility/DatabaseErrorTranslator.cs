using System.Data.SqlClient;

namespace MY
{
    sealed public class DatabaseErrorTranslator
    {
        static public string GetErrorMessage(SqlException exception)
        {
            switch (exception.Number)
            {
                case 2627://Violation of UNIQUE KEY constraint '***'. Cannot insert duplicate key in object '***'. The duplicate key value is (***).
                    return Convert2627ErrorMessage(exception.Message);
            }
            return exception.Message;
        }

        static private string Convert2627ErrorMessage(string originalErrorMessage)
        {
            var op = originalErrorMessage.IndexOf("(");
            var cp = originalErrorMessage.IndexOf(")");
            var duplicatedValue = originalErrorMessage.Substring(op + 1, cp - op - 1);
            return $"مقدار '{duplicatedValue}' تکراری می‌باشد.";
        }
    }
}
