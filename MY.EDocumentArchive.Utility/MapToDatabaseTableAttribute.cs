using System;

namespace MY
{
    [AttributeUsage(AttributeTargets.Class)]
    sealed public class MapToDatabaseTableAttribute : System.Attribute
    {
        public MapToDatabaseTableAttribute(string schemaName, string tableName)
        {
            _schemaName = schemaName;
            _tableName = tableName;
        }

        private string _schemaName;

        public string SchemaName
        {
            get { return _schemaName; }
            set { _schemaName = value; }
        }

        private string _tableName;

        public string TableName
        {
            get { return _tableName; }
            set { _tableName = value; }
        }

    }
}
