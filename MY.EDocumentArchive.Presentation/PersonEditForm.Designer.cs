namespace MY.EDocumentArchive.Presentation
{
    partial class PersonEditForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtNationalID = new MY.ControlLibrary.MTextBox();
            this.txtFullName = new MY.ControlLibrary.MTextBox();
            this.txtName = new MY.ControlLibrary.MTextBox();
            this.txtLastName = new MY.ControlLibrary.MTextBox();
            this.txtFirstName = new MY.ControlLibrary.MTextBox();
            this.mTextBox1 = new MY.ControlLibrary.MTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(666, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "نام";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(666, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "نام خانوادگی";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(666, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "نام شرکت";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(666, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "نام کامل";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(666, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 30);
            this.label5.TabIndex = 10;
            this.label5.Text = "شماره ملی";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(666, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 30);
            this.label6.TabIndex = 0;
            this.label6.Text = "نوع";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbType
            // 
            this.cmbType.BackColor = System.Drawing.Color.White;
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "شخص (حقیقی)",
            "شرکت (حقوقی)"});
            this.cmbType.Location = new System.Drawing.Point(324, 41);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(336, 31);
            this.cmbType.TabIndex = 1;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(550, 330);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 30);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "ثبت   F5";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtNationalID
            // 
            this.txtNationalID.BackColor = System.Drawing.Color.White;
            this.txtNationalID.Location = new System.Drawing.Point(324, 272);
            this.txtNationalID.MaxLength = 50;
            this.txtNationalID.Name = "txtNationalID";
            this.txtNationalID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNationalID.Size = new System.Drawing.Size(336, 30);
            this.txtNationalID.TabIndex = 11;
            this.txtNationalID.CustomValidation += new MY.CustomValidationEventHandler(this.txtNationalID_CustomValidation);
            // 
            // txtFullName
            // 
            this.txtFullName.BackColor = System.Drawing.Color.White;
            this.txtFullName.Location = new System.Drawing.Point(324, 226);
            this.txtFullName.MaxLength = 50;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.ReadOnly = true;
            this.txtFullName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFullName.Size = new System.Drawing.Size(336, 30);
            this.txtFullName.TabIndex = 9;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(324, 180);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtName.Size = new System.Drawing.Size(336, 30);
            this.txtName.TabIndex = 7;
            this.txtName.TextChanged += new System.EventHandler(this.CreateFullName);
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.White;
            this.txtLastName.Location = new System.Drawing.Point(324, 135);
            this.txtLastName.MaxLength = 50;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtLastName.Size = new System.Drawing.Size(336, 30);
            this.txtLastName.TabIndex = 5;
            this.txtLastName.TextChanged += new System.EventHandler(this.CreateFullName);
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.White;
            this.txtFirstName.Location = new System.Drawing.Point(324, 89);
            this.txtFirstName.MaxLength = 50;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFirstName.Size = new System.Drawing.Size(336, 30);
            this.txtFirstName.TabIndex = 3;
            this.txtFirstName.CustomValidation += new MY.CustomValidationEventHandler(this.txtFirstName_CustomValidation);
            this.txtFirstName.TextChanged += new System.EventHandler(this.CreateFullName);
            // 
            // mTextBox1
            // 
            this.mTextBox1.Location = new System.Drawing.Point(0, 0);
            this.mTextBox1.Name = "mTextBox1";
            this.mTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mTextBox1.Size = new System.Drawing.Size(100, 22);
            this.mTextBox1.TabIndex = 0;
            // 
            // PersonEditForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 401);
            this.Controls.Add(this.txtNationalID);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("B Mitra", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "PersonEditForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "PersonEditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Button btnSave;
        private ControlLibrary.MTextBox mTextBox1;
        private ControlLibrary.MTextBox txtFirstName;
        private ControlLibrary.MTextBox txtLastName;
        private ControlLibrary.MTextBox txtName;
        private ControlLibrary.MTextBox txtFullName;
        private ControlLibrary.MTextBox txtNationalID;
    }
}