namespace MY
{
    abstract public class BaseEntity
    {
        protected BaseEntity(string schemaName, string tableName)
        {
            __MappingInfo = new TableMappingInfo(schemaName, tableName);
        }

        [NoInsert]
        [NoSelect]
        public TableMappingInfo __MappingInfo { get; }
    }
}