using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.IO;
using MY.EDocumentArchive.Model;

namespace MY.CodeGenerator
{
    public partial class Step5Form : Form, IMessageSupport
    {
        private string connectionString, tableName, schemaName, nameSpace, rootPath;

        public Step5Form()
        {
            InitializeComponent();
        }

        private string GenerateClass()
        {
            var table = new DataTable();
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(@"
					SELECT
	                    CASE T.name
		                    WHEN N'bigint' THEN N'long'
		                    WHEN N'binary' THEN N'byte[]'
		                    WHEN N'bit' THEN N'bool'
		                    WHEN N'char' THEN N'char'
		                    WHEN N'date' THEN N'System.DateTime'
		                    WHEN N'datetime' THEN N'System.DateTime'
		                    WHEN N'decimal' THEN N'decimal'
		                    WHEN N'float' THEN N'double'
		                    WHEN N'image' THEN N'byte[]'
		                    WHEN N'int' THEN N'int'
		                    WHEN N'nchar' THEN N'string'
		                    WHEN N'ntext' THEN N'string'
		                    WHEN N'numeric' THEN N'decimal'
		                    WHEN N'nvarchar' THEN N'string'
		                    WHEN N'real' THEN N'float'
		                    WHEN N'smallint' THEN N'short'
		                    WHEN N'text' THEN N'string'
		                    WHEN N'time' THEN N'System.DateSpan'
		                    WHEN N'tinyint' THEN N'byte'
		                    WHEN N'uniqueidentifier' THEN N'System.Guid'
		                    WHEN N'varbinary' THEN N''
		                    WHEN N'varchar' THEN N'string'
	                    END ColumnDataType,
	                    COL.name ColumnName,
	                    COL.is_nullable IsNullable,
	                    COL.is_identity IsIdentity,
	                    COL.is_computed IsComputed,
	                    CASE WHEN TPrimaryKeys.name IS NULL THEN 'No' ELSE 'Yes' END IsPrimaryKey
                    FROM
	                    sys.columns COL
	                    JOIN sys.types T ON COL.system_type_id = T.system_type_id
	                    JOIN sys.tables TBL ON COL.object_id = TBL.object_id
	                    JOIN sys.schemas SCH ON TBL.schema_id = SCH.schema_id
	                    LEFT JOIN
	                    (
		                    SELECT
			                    COL.name
		                    FROM
			                    sys.key_constraints KC
			                    JOIN sys.tables TBL ON KC.parent_object_id = TBL.object_id
			                    JOIN sys.indexes IDX ON TBL.object_id = IDX.object_id
			                    JOIN sys.index_columns IDXCOL ON IDX.object_id = IDXCOL.object_id AND IDX.index_id = IDXCOL.index_id
			                    JOIN sys.schemas SCH ON TBL.schema_id = SCH.schema_id
			                    JOIN sys.columns COL ON IDXCOL.column_id = COL.column_id AND IDX.object_id = COL.object_id
		                    WHERE
			                    KC.type = 'PK'
			                    AND
			                    IDX.is_primary_key = 1
			                    AND
			                    SCH.name = @SchemaName
			                    AND
			                    TBL.name = @TableName
	                    ) TPrimaryKeys ON TPrimaryKeys.name = COL.name
                    WHERE
	                    SCH.name = @SchemaName
	                    AND
	                    TBL.name = @TableName
	                    AND
	                    T.name <> N'sysname'", connection))
                {
                    command.Parameters.AddWithValue("SchemaName", schemaName);
                    command.Parameters.AddWithValue("TableName", tableName);
                    table.Load(command.ExecuteReader());
                }
                connection.Close();
            }
            var ClassCode = string.Empty;
            ClassCode += $"namespace MY.{nameSpace}.Model\n";
            ClassCode += "{\n";

            ClassCode += $"\tpublic partial class {tableName} : BaseEntity\n";
            ClassCode += "\t{\n";

            ClassCode += $"\t\tpublic {tableName}()\n";
            ClassCode += $"\t\t\t: base(\"{schemaName}\", \"{tableName}\")\n";
            ClassCode += "\t\t{\n";
            ClassCode += "\t\t}\n";

            ClassCode += "\n";

            foreach (DataRow row in table.Rows)
            {
                if (bool.Parse($"{row["IsIdentity"]}") || bool.Parse($"{row["IsComputed"]}"))
                    ClassCode += "\t\t[NoInsert]\n";

                if (bool.Parse($"{row["IsPrimaryKey"]}"))
                    ClassCode += "\t\t[PrimaryKey]\n";

                if (bool.Parse($"{row["IsIdentity"]}"))
                    ClassCode += "\t\t[AutoIdentity]\n";

                ClassCode += $"\t\tpublic {row["ColumnDataType"]} {row["ColumnName"]} {{ get; set; }}\n";
            }
            ClassCode += "\t}\n";
            ClassCode += "}";
            return ClassCode;

            //var filePath = $"{rootPath}\\{nameSpace}.Model";
            //filePath = Path.Combine(filePath, $"{tableName}.cs");
            //File.WriteAllText(filePath, ClassCode);
        }

        public bool Message(string inputMessage, string extraData, out string outputMessage)
        {
            outputMessage = string.Empty;
            switch (inputMessage)
            {
                case "SetConnectionString":
                    connectionString = extraData;
                    break;
                case "SetNameSpace":
                    nameSpace = extraData;
                    break;
                case "SetRootPath":
                    rootPath = extraData;
                    break;
                case "GenerateClass":
                    var parts = extraData.Split('.');
                    schemaName = parts[0];
                    tableName = parts[1];
                    outputMessage = GenerateClass();
                    break;
            }
            return true;
        }
    }
}
