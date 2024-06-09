namespace MY.CodeGenerator
{
    partial class GeneratorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneratorForm));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.menuStep7 = new System.Windows.Forms.Label();
            this.menuStep6 = new System.Windows.Forms.Label();
            this.menuStep5 = new System.Windows.Forms.Label();
            this.menuStep4 = new System.Windows.Forms.Label();
            this.menuStep3 = new System.Windows.Forms.Label();
            this.menuStep2 = new System.Windows.Forms.Label();
            this.menuStep1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel15 = new System.Windows.Forms.Panel();
            this.pnlStepsArea = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnTestConnection = new System.Windows.Forms.Label();
            this.btnPrevStep = new System.Windows.Forms.Label();
            this.btnNextStep = new System.Windows.Forms.Label();
            this.btnFinish = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Label();
            this.openImage = new System.Windows.Forms.OpenFileDialog();
            this.pnlMenu.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel15.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.pnlMenu.Controls.Add(this.lblStatus);
            this.pnlMenu.Controls.Add(this.menuStep7);
            this.pnlMenu.Controls.Add(this.menuStep6);
            this.pnlMenu.Controls.Add(this.menuStep5);
            this.pnlMenu.Controls.Add(this.menuStep4);
            this.pnlMenu.Controls.Add(this.menuStep3);
            this.pnlMenu.Controls.Add(this.menuStep2);
            this.pnlMenu.Controls.Add(this.menuStep1);
            this.pnlMenu.Controls.Add(this.panel4);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlMenu.Location = new System.Drawing.Point(624, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(260, 590);
            this.pnlMenu.TabIndex = 0;
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblStatus.Location = new System.Drawing.Point(0, 514);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Padding = new System.Windows.Forms.Padding(5);
            this.lblStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblStatus.Size = new System.Drawing.Size(260, 76);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Design: Sadjad Refagat";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // menuStep7
            // 
            this.menuStep7.BackColor = System.Drawing.Color.Transparent;
            this.menuStep7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuStep7.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuStep7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.menuStep7.Location = new System.Drawing.Point(0, 360);
            this.menuStep7.Name = "menuStep7";
            this.menuStep7.Size = new System.Drawing.Size(260, 50);
            this.menuStep7.TabIndex = 9;
            this.menuStep7.Text = "انتشار";
            this.menuStep7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.menuStep7.Click += new System.EventHandler(this.gotoStep);
            // 
            // menuStep6
            // 
            this.menuStep6.BackColor = System.Drawing.Color.Transparent;
            this.menuStep6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuStep6.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuStep6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.menuStep6.Location = new System.Drawing.Point(0, 310);
            this.menuStep6.Name = "menuStep6";
            this.menuStep6.Size = new System.Drawing.Size(260, 50);
            this.menuStep6.TabIndex = 8;
            this.menuStep6.Text = "تولید پروژه";
            this.menuStep6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.menuStep6.Click += new System.EventHandler(this.gotoStep);
            // 
            // menuStep5
            // 
            this.menuStep5.BackColor = System.Drawing.Color.Transparent;
            this.menuStep5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuStep5.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuStep5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.menuStep5.Location = new System.Drawing.Point(0, 260);
            this.menuStep5.Name = "menuStep5";
            this.menuStep5.Size = new System.Drawing.Size(260, 50);
            this.menuStep5.TabIndex = 7;
            this.menuStep5.Text = "پیش‌نمایش تولید";
            this.menuStep5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.menuStep5.Click += new System.EventHandler(this.gotoStep);
            // 
            // menuStep4
            // 
            this.menuStep4.BackColor = System.Drawing.Color.Transparent;
            this.menuStep4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuStep4.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuStep4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.menuStep4.Location = new System.Drawing.Point(0, 210);
            this.menuStep4.Name = "menuStep4";
            this.menuStep4.Size = new System.Drawing.Size(260, 50);
            this.menuStep4.TabIndex = 6;
            this.menuStep4.Text = "انتخاب پلتفرم";
            this.menuStep4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.menuStep4.Click += new System.EventHandler(this.gotoStep);
            // 
            // menuStep3
            // 
            this.menuStep3.BackColor = System.Drawing.Color.Transparent;
            this.menuStep3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuStep3.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuStep3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.menuStep3.Location = new System.Drawing.Point(0, 160);
            this.menuStep3.Name = "menuStep3";
            this.menuStep3.Size = new System.Drawing.Size(260, 50);
            this.menuStep3.TabIndex = 5;
            this.menuStep3.Text = "تنظیمات نگاشت";
            this.menuStep3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.menuStep3.Click += new System.EventHandler(this.gotoStep);
            // 
            // menuStep2
            // 
            this.menuStep2.BackColor = System.Drawing.Color.Transparent;
            this.menuStep2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuStep2.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuStep2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.menuStep2.Location = new System.Drawing.Point(0, 110);
            this.menuStep2.Name = "menuStep2";
            this.menuStep2.Size = new System.Drawing.Size(260, 50);
            this.menuStep2.TabIndex = 4;
            this.menuStep2.Text = "موجودیت‌ها";
            this.menuStep2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.menuStep2.Click += new System.EventHandler(this.gotoStep);
            // 
            // menuStep1
            // 
            this.menuStep1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.menuStep1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuStep1.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuStep1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.menuStep1.Location = new System.Drawing.Point(0, 60);
            this.menuStep1.Name = "menuStep1";
            this.menuStep1.Size = new System.Drawing.Size(260, 50);
            this.menuStep1.TabIndex = 3;
            this.menuStep1.Text = "پیکربندی پروژه";
            this.menuStep1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.menuStep1.Click += new System.EventHandler(this.gotoStep);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(5);
            this.panel4.Size = new System.Drawing.Size(260, 60);
            this.panel4.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(98, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Version: 1.0.0.112";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(5, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 50);
            this.label4.TabIndex = 2;
            this.label4.Text = "ModiranYar\r\nCode Generator";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(191, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.LightGray;
            this.panel15.Controls.Add(this.pnlStepsArea);
            this.panel15.Controls.Add(this.panel5);
            this.panel15.Controls.Add(this.panel3);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel15.Location = new System.Drawing.Point(0, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(624, 590);
            this.panel15.TabIndex = 1;
            // 
            // pnlStepsArea
            // 
            this.pnlStepsArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStepsArea.Location = new System.Drawing.Point(0, 60);
            this.pnlStepsArea.Name = "pnlStepsArea";
            this.pnlStepsArea.Size = new System.Drawing.Size(624, 454);
            this.pnlStepsArea.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.panel5.Controls.Add(this.btnTestConnection);
            this.panel5.Controls.Add(this.btnPrevStep);
            this.panel5.Controls.Add(this.btnNextStep);
            this.panel5.Controls.Add(this.btnFinish);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 514);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(624, 76);
            this.panel5.TabIndex = 8;
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.btnTestConnection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTestConnection.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnTestConnection.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnTestConnection.Location = new System.Drawing.Point(344, 18);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(153, 41);
            this.btnTestConnection.TabIndex = 5;
            this.btnTestConnection.Text = "تست ارتباط با دیتابیس";
            this.btnTestConnection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // btnPrevStep
            // 
            this.btnPrevStep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.btnPrevStep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevStep.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnPrevStep.ForeColor = System.Drawing.Color.Black;
            this.btnPrevStep.Location = new System.Drawing.Point(238, 18);
            this.btnPrevStep.Name = "btnPrevStep";
            this.btnPrevStep.Size = new System.Drawing.Size(100, 41);
            this.btnPrevStep.TabIndex = 5;
            this.btnPrevStep.Text = "قبلی";
            this.btnPrevStep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPrevStep.Click += new System.EventHandler(this.btnPrevStep_Click);
            // 
            // btnNextStep
            // 
            this.btnNextStep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.btnNextStep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextStep.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnNextStep.ForeColor = System.Drawing.Color.Black;
            this.btnNextStep.Location = new System.Drawing.Point(132, 18);
            this.btnNextStep.Name = "btnNextStep";
            this.btnNextStep.Size = new System.Drawing.Size(100, 41);
            this.btnNextStep.TabIndex = 5;
            this.btnNextStep.Text = "بعدی";
            this.btnNextStep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNextStep.Click += new System.EventHandler(this.btnNextStep_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnFinish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinish.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnFinish.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnFinish.Location = new System.Drawing.Point(26, 18);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(100, 41);
            this.btnFinish.TabIndex = 5;
            this.btnFinish.Text = "پایان";
            this.btnFinish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblTitle);
            this.panel3.Controls.Add(this.btnMinimize);
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(624, 60);
            this.panel3.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTitle.Location = new System.Drawing.Point(109, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(510, 50);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "پیکربندی پروژه";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseDown);
            this.lblTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseMove);
            this.lblTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseUp);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnMinimize.Location = new System.Drawing.Point(57, 5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(52, 50);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.Text = "─";
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnClose.Font = new System.Drawing.Font("Wingdings", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnClose.Location = new System.Drawing.Point(5, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(52, 50);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "x";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // GeneratorForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(884, 590);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.pnlMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "GeneratorForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GeneratorForm";
            this.pnlMenu.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel15.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label btnClose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label btnMinimize;
        private System.Windows.Forms.Label menuStep6;
        private System.Windows.Forms.Label menuStep5;
        private System.Windows.Forms.Label menuStep4;
        private System.Windows.Forms.Label menuStep3;
        private System.Windows.Forms.Label menuStep2;
        private System.Windows.Forms.Label menuStep1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label menuStep7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openImage;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label btnPrevStep;
        private System.Windows.Forms.Label btnNextStep;
        private System.Windows.Forms.Label btnFinish;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label btnTestConnection;
        private System.Windows.Forms.Panel pnlStepsArea;
    }
}