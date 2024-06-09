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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.txtNationalID = new MY.ControlLibrary.MTextBox();
            this.txtFullName = new MY.ControlLibrary.MTextBox();
            this.txtName = new MY.ControlLibrary.MTextBox();
            this.txtLastName = new MY.ControlLibrary.MTextBox();
            this.txtFirstName = new MY.ControlLibrary.MTextBox();
            this.mTextBox1 = new MY.ControlLibrary.MTextBox();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.calendarControl1 = new DevExpress.XtraEditors.Controls.CalendarControl();
            this.propertyGridControl1 = new DevExpress.XtraVerticalGrid.PropertyGridControl();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarControl1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGridControl1)).BeginInit();
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
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(81, 46);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.AdvancedModeOptions.AllowCaretAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.textEdit1.Properties.AdvancedModeOptions.AllowSelectionAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.textEdit1.Properties.AdvancedModeOptions.Label = "برچسب";
            this.textEdit1.Properties.AdvancedModeOptions.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(203)))), ((int)(((byte)(231)))));
            this.textEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(254)))));
            this.textEdit1.Properties.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("B Mitra", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit1.Properties.Appearance.Options.UseBorderColor = true;
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit1.Properties.Appearance.Options.UseTextOptions = true;
            this.textEdit1.Properties.Padding = new System.Windows.Forms.Padding(10);
            this.textEdit1.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.textEdit1.Size = new System.Drawing.Size(237, 82);
            this.textEdit1.TabIndex = 13;
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
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(159, 143);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Size = new System.Drawing.Size(125, 22);
            this.comboBoxEdit1.TabIndex = 14;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barCheckItem1,
            this.barSubItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 7;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(800, 183);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barCheckItem1);
            this.ribbonPageGroup3.ItemLinks.Add(this.barSubItem1);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barCheckItem1
            // 
            this.barCheckItem1.Caption = "barCheckItem1";
            this.barCheckItem1.Id = 5;
            this.barCheckItem1.Name = "barCheckItem1";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "barSubItem1";
            this.barSubItem1.Id = 6;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // calendarControl1
            // 
            this.calendarControl1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calendarControl1.Location = new System.Drawing.Point(503, 366);
            this.calendarControl1.Name = "calendarControl1";
            this.calendarControl1.Size = new System.Drawing.Size(285, 282);
            this.calendarControl1.TabIndex = 20;
            this.calendarControl1.CustomDrawDayNumberCell += new DevExpress.XtraEditors.Calendar.CustomDrawDayNumberCellEventHandler(this.calendarControl1_CustomDrawDayNumberCell);
            // 
            // propertyGridControl1
            // 
            this.propertyGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.propertyGridControl1.Location = new System.Drawing.Point(25, 330);
            this.propertyGridControl1.MenuManager = this.ribbonControl1;
            this.propertyGridControl1.Name = "propertyGridControl1";
            this.propertyGridControl1.OptionsView.AllowReadOnlyRowAppearance = DevExpress.Utils.DefaultBoolean.True;
            this.propertyGridControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.propertyGridControl1.SelectedObject = this.calendarControl1;
            this.propertyGridControl1.Size = new System.Drawing.Size(400, 318);
            this.propertyGridControl1.TabIndex = 21;
            // 
            // PersonEditForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 666);
            this.Controls.Add(this.propertyGridControl1);
            this.Controls.Add(this.calendarControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.comboBoxEdit1);
            this.Controls.Add(this.textEdit1);
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
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarControl1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGridControl1)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarCheckItem barCheckItem1;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraEditors.Controls.CalendarControl calendarControl1;
        private DevExpress.XtraVerticalGrid.PropertyGridControl propertyGridControl1;
    }
}