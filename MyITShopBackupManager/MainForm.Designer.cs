namespace MyITShopBackupManager
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.pnlSubDetails = new System.Windows.Forms.Panel();
            this.btnResetApplication = new System.Windows.Forms.Button();
            this.btnResetToShared = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.listboxApplications = new System.Windows.Forms.ListBox();
            this.txtJobID = new System.Windows.Forms.TextBox();
            this.lblJobNo = new System.Windows.Forms.Label();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.rtxtInstructions = new System.Windows.Forms.RichTextBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlTop.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlSubDetails.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnSettings);
            this.pnlTop.Controls.Add(this.picLogo);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(800, 84);
            this.pnlTop.TabIndex = 1;
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSettings.Location = new System.Drawing.Point(647, 0);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(153, 84);
            this.btnSettings.TabIndex = 1;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.lblCopyright);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 444);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(800, 30);
            this.pnlBottom.TabIndex = 2;
            // 
            // lblCopyright
            // 
            this.lblCopyright.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Location = new System.Drawing.Point(294, 13);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(494, 13);
            this.lblCopyright.TabIndex = 0;
            this.lblCopyright.Text = "This program is developed for use within My IT Shop and will not work outside of " +
    "My IT Shop Networks.";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.txtLog);
            this.pnlMain.Controls.Add(this.pnlSubDetails);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlMain.Location = new System.Drawing.Point(212, 84);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(588, 360);
            this.pnlMain.TabIndex = 3;
            // 
            // txtLog
            // 
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Location = new System.Drawing.Point(203, 0);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(385, 360);
            this.txtLog.TabIndex = 3;
            // 
            // pnlSubDetails
            // 
            this.pnlSubDetails.Controls.Add(this.btnResetApplication);
            this.pnlSubDetails.Controls.Add(this.btnResetToShared);
            this.pnlSubDetails.Controls.Add(this.btnGenerate);
            this.pnlSubDetails.Controls.Add(this.listboxApplications);
            this.pnlSubDetails.Controls.Add(this.txtJobID);
            this.pnlSubDetails.Controls.Add(this.lblJobNo);
            this.pnlSubDetails.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSubDetails.Location = new System.Drawing.Point(0, 0);
            this.pnlSubDetails.Name = "pnlSubDetails";
            this.pnlSubDetails.Size = new System.Drawing.Size(203, 360);
            this.pnlSubDetails.TabIndex = 2;
            // 
            // btnResetApplication
            // 
            this.btnResetApplication.Location = new System.Drawing.Point(10, 204);
            this.btnResetApplication.Name = "btnResetApplication";
            this.btnResetApplication.Size = new System.Drawing.Size(187, 23);
            this.btnResetApplication.TabIndex = 5;
            this.btnResetApplication.Text = "Reset to Application Default";
            this.btnResetApplication.UseVisualStyleBackColor = true;
            this.btnResetApplication.Click += new System.EventHandler(this.btnResetApplication_Click);
            // 
            // btnResetToShared
            // 
            this.btnResetToShared.Location = new System.Drawing.Point(10, 175);
            this.btnResetToShared.Name = "btnResetToShared";
            this.btnResetToShared.Size = new System.Drawing.Size(187, 23);
            this.btnResetToShared.TabIndex = 4;
            this.btnResetToShared.Text = "Reset to Shared";
            this.btnResetToShared.UseVisualStyleBackColor = true;
            this.btnResetToShared.Click += new System.EventHandler(this.btnResetToShared_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGenerate.Location = new System.Drawing.Point(10, 146);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(187, 23);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Create / Link Job Folder";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // listboxApplications
            // 
            this.listboxApplications.FormattingEnabled = true;
            this.listboxApplications.Items.AddRange(new object[] {
            "iTunes",
            "iMazing",
            "Dr. Fone",
            "3U",
            "Samsung Smart Switch"});
            this.listboxApplications.Location = new System.Drawing.Point(10, 44);
            this.listboxApplications.Name = "listboxApplications";
            this.listboxApplications.Size = new System.Drawing.Size(187, 95);
            this.listboxApplications.TabIndex = 2;
            this.listboxApplications.SelectedIndexChanged += new System.EventHandler(this.listboxApplications_SelectedIndexChanged);
            // 
            // txtJobID
            // 
            this.txtJobID.Location = new System.Drawing.Point(85, 18);
            this.txtJobID.Name = "txtJobID";
            this.txtJobID.Size = new System.Drawing.Size(112, 20);
            this.txtJobID.TabIndex = 0;
            this.txtJobID.TextChanged += new System.EventHandler(this.txtJobID_TextChanged);
            // 
            // lblJobNo
            // 
            this.lblJobNo.AutoSize = true;
            this.lblJobNo.Location = new System.Drawing.Point(7, 21);
            this.lblJobNo.Name = "lblJobNo";
            this.lblJobNo.Size = new System.Drawing.Size(67, 13);
            this.lblJobNo.TabIndex = 1;
            this.lblJobNo.Text = "Job Number:";
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.Controls.Add(this.rtxtInstructions);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 84);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(213, 360);
            this.pnlSidebar.TabIndex = 4;
            // 
            // rtxtInstructions
            // 
            this.rtxtInstructions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtInstructions.Location = new System.Drawing.Point(0, 0);
            this.rtxtInstructions.Name = "rtxtInstructions";
            this.rtxtInstructions.ReadOnly = true;
            this.rtxtInstructions.Size = new System.Drawing.Size(213, 360);
            this.rtxtInstructions.TabIndex = 0;
            this.rtxtInstructions.Text = resources.GetString("rtxtInstructions.Text");
            // 
            // picLogo
            // 
            this.picLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picLogo.BackgroundImage")));
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(213, 84);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            this.picLogo.DoubleClick += new System.EventHandler(this.picLogo_DoubleClick);
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnGenerate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Backup Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlSubDetails.ResumeLayout(false);
            this.pnlSubDetails.PerformLayout();
            this.pnlSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Panel pnlSubDetails;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ListBox listboxApplications;
        private System.Windows.Forms.TextBox txtJobID;
        private System.Windows.Forms.Label lblJobNo;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.RichTextBox rtxtInstructions;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnResetApplication;
        private System.Windows.Forms.Button btnResetToShared;
    }
}

