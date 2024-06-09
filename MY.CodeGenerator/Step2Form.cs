using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MY.CodeGenerator
{
    public partial class Step2Form : Form, IMessageSupport
    {
        private string connectionString;

        public Step2Form()
        {
            InitializeComponent();

            var data = new DataTable();
            data.Columns.Add("SchemaName", typeof(string));
            data.Columns.Add("TableName", typeof(string));

            data.Rows.Add(new object[] { "USR3", "AgriculturePeriod" });
            data.Rows.Add(new object[] { "USR3", "ContractRequest" });
            data.Rows.Add(new object[] { "SYS3", "Lookup" });
            data.Rows.Add(new object[] { "FIN3", "Voucher" });
            data.Rows.Add(new object[] { "FIN3", "Voucher" });
            data.Rows.Add(new object[] { "FIN3", "Voucher" });
            data.Rows.Add(new object[] { "FIN3", "Voucher" });
            data.Rows.Add(new object[] { "FIN3", "Voucher" });
            data.Rows.Add(new object[] { "FIN3", "Voucher" });
            data.Rows.Add(new object[] { "FIN3", "Voucher" });
            data.Rows.Add(new object[] { "FIN3", "Voucher" });
            data.Rows.Add(new object[] { "FIN3", "Voucher" });
            data.Rows.Add(new object[] { "FIN3", "Voucher" });
            data.Rows.Add(new object[] { "FIN3", "Voucher" });
            data.Rows.Add(new object[] { "FIN3", "Voucher" });
            data.Rows.Add(new object[] { "FIN3", "Voucher" });
            data.Rows.Add(new object[] { "FIN3", "Voucher" });
            data.Rows.Add(new object[] { "FIN3", "Voucher" });
            data.Rows.Add(new object[] { "FIN3", "Voucher" });
            data.Rows.Add(new object[] { "FIN3", "Voucher" });
            data.Rows.Add(new object[] { "FIN3", "Voucher" });
            data.Rows.Add(new object[] { "FIN3", "Voucher" });
            data.Rows.Add(new object[] { "FIN3", "Voucher" });
            data.Rows.Add(new object[] { "FIN3", "Voucher" });
            data.Rows.Add(new object[] { "FIN3", "Voucher" });
            data.Rows.Add(new object[] { "FIN3", "Voucher" });
            data.Rows.Add(new object[] { "FIN3", "Voucher" });

            dataGridView1.DataSource = data;

        }

        private void LoadTables()
        {
            var table = new DataTable();
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(@"
                    SELECT
	                    [SCH].[name] [SchemaName],
	                    [TBL].[name] [TableName]
                    FROM
	                    [sys].[tables] [TBL]
	                    JOIN [sys].[schemas] [SCH] ON [TBL].[schema_id] = [SCH].[schema_id]
                    WHERE
	                    [TBL].[name] NOT IN ('sysdiagrams')
                    ORDER BY
	                    [TBL].[name]", connection))
                    table.Load(command.ExecuteReader());
                connection.Close();
            }
            dataGridView1.DataSource = table;
        }

        private void btnReload_Click(object sender, System.EventArgs e)
        {
            LoadTables();
        }

        public bool Message(string inputMessage, string extraData, out string outputMessage)
        {
            outputMessage = string.Empty;
            switch (inputMessage)
            {
                case "SetConnectionString":
                    connectionString = extraData;
                    break;
                default:
                    break;
            }
            return true;
        }
    }
}
