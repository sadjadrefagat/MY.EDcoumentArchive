namespace MY.CodeGenerator
{
    partial class Step2Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SchemaName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnReload = new System.Windows.Forms.Label();
            this.btnSelectAll = new System.Windows.Forms.Label();
            this.btnSelectNone = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 585);
            this.panel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(128)))), ((int)(((byte)(188)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(128)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(128)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 60;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selected,
            this.SchemaName,
            this.TableName});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(194)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.Location = new System.Drawing.Point(0, 76);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(194)))), ((int)(((byte)(77)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.Height = 42;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(950, 509);
            this.dataGridView1.TabIndex = 2;
            // 
            // Selected
            // 
            this.Selected.Frozen = true;
            this.Selected.HeaderText = "";
            this.Selected.MinimumWidth = 6;
            this.Selected.Name = "Selected";
            this.Selected.Width = 30;
            // 
            // SchemaName
            // 
            this.SchemaName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SchemaName.DataPropertyName = "SchemaName";
            this.SchemaName.Frozen = true;
            this.SchemaName.HeaderText = "الگو";
            this.SchemaName.MinimumWidth = 120;
            this.SchemaName.Name = "SchemaName";
            this.SchemaName.ReadOnly = true;
            this.SchemaName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SchemaName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SchemaName.Width = 120;
            // 
            // TableName
            // 
            this.TableName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TableName.DataPropertyName = "TableName";
            this.TableName.HeaderText = "جدول";
            this.TableName.MinimumWidth = 6;
            this.TableName.Name = "TableName";
            this.TableName.ReadOnly = true;
            this.TableName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TableName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.panel5.Controls.Add(this.btnReload);
            this.panel5.Controls.Add(this.btnSelectAll);
            this.panel5.Controls.Add(this.btnSelectNone);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(950, 76);
            this.panel5.TabIndex = 9;
            // 
            // btnReload
            // 
            this.btnReload.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReload.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnReload.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnReload.Location = new System.Drawing.Point(632, 18);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(84, 41);
            this.btnReload.TabIndex = 5;
            this.btnReload.Text = "بازیابی";
            this.btnReload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSelectAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.btnSelectAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectAll.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSelectAll.ForeColor = System.Drawing.Color.Black;
            this.btnSelectAll.Location = new System.Drawing.Point(833, 18);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(105, 41);
            this.btnSelectAll.TabIndex = 5;
            this.btnSelectAll.Text = "انتخاب همه";
            this.btnSelectAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSelectNone
            // 
            this.btnSelectNone.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSelectNone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.btnSelectNone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectNone.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSelectNone.ForeColor = System.Drawing.Color.Black;
            this.btnSelectNone.Location = new System.Drawing.Point(722, 18);
            this.btnSelectNone.Name = "btnSelectNone";
            this.btnSelectNone.Size = new System.Drawing.Size(105, 41);
            this.btnSelectNone.TabIndex = 5;
            this.btnSelectNone.Text = "انتخاب هیچکدام";
            this.btnSelectNone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Step2Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(950, 585);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Step2Form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Step2Form";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selected;
        private System.Windows.Forms.DataGridViewTextBoxColumn SchemaName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableName;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label btnReload;
        private System.Windows.Forms.Label btnSelectAll;
        private System.Windows.Forms.Label btnSelectNone;
    }
}