namespace MY
{
    sealed public class TableMappingInfo
    {
        public TableMappingInfo(string schemaName, string tableName)
        {
            SchemaName = schemaName;
            TableName = tableName;
        }

        public string SchemaName { get; }
        public string TableName { get; }
    }
}
