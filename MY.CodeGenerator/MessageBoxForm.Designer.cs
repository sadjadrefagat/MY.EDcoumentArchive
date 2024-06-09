namespace MY.CodeGenerator
{
    partial class MessageBoxForm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblIcon = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnFinish = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblTitle);
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(540, 39);
            this.panel3.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTitle.Location = new System.Drawing.Point(57, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(478, 29);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "توجه!";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnClose.Font = new System.Drawing.Font("Wingdings", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnClose.Location = new System.Drawing.Point(5, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(52, 29);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "x";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMessage.Location = new System.Drawing.Point(12, 72);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(444, 81);
            this.lblMessage.TabIndex = 3;
            this.lblMessage.Text = "---";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIcon
            // 
            this.lblIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIcon.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblIcon.Location = new System.Drawing.Point(462, 72);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(66, 81);
            this.lblIcon.TabIndex = 3;
            this.lblIcon.Text = "i";
            this.lblIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.panel5.Controls.Add(this.btnFinish);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 175);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(540, 76);
            this.panel5.TabIndex = 9;
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnFinish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinish.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnFinish.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnFinish.Location = new System.Drawing.Point(220, 18);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(100, 41);
            this.btnFinish.TabIndex = 5;
            this.btnFinish.Text = "تائید";
            this.btnFinish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // MessageBoxForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(540, 251);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.lblIcon);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MessageBoxForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MessageBoxForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MessageBoxForm_KeyDown);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label btnClose;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label btnFinish;
    }
}