namespace MyITShopBackupManager
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.txtBackupLocation = new System.Windows.Forms.TextBox();
            this.lblBackupLocation = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.toolTipSaveLocation = new System.Windows.Forms.ToolTip(this.components);
            this.lblSharedLocation = new System.Windows.Forms.Label();
            this.txtSharedLocation = new System.Windows.Forms.TextBox();
            this.lstBoxApplications = new System.Windows.Forms.ListBox();
            this.btnAddApp = new System.Windows.Forms.Button();
            this.btnDelApp = new System.Windows.Forms.Button();
            this.btnEditApp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBackupLocation
            // 
            this.txtBackupLocation.Location = new System.Drawing.Point(154, 12);
            this.txtBackupLocation.Name = "txtBackupLocation";
            this.txtBackupLocation.Size = new System.Drawing.Size(311, 20);
            this.txtBackupLocation.TabIndex = 0;
            // 
            // lblBackupLocation
            // 
            this.lblBackupLocation.AutoSize = true;
            this.lblBackupLocation.Location = new System.Drawing.Point(15, 15);
            this.lblBackupLocation.Name = "lblBackupLocation";
            this.lblBackupLocation.Size = new System.Drawing.Size(119, 13);
            this.lblBackupLocation.TabIndex = 1;
            this.lblBackupLocation.Text = "Backup Save Location:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(390, 334);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(9, 334);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // toolTipSaveLocation
            // 
            this.toolTipSaveLocation.AutoPopDelay = 5000;
            this.toolTipSaveLocation.InitialDelay = 200;
            this.toolTipSaveLocation.ReshowDelay = 100;
            this.toolTipSaveLocation.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipSaveLocation.ToolTipTitle = "Save Location";
            // 
            // lblSharedLocation
            // 
            this.lblSharedLocation.AutoSize = true;
            this.lblSharedLocation.Location = new System.Drawing.Point(6, 41);
            this.lblSharedLocation.Name = "lblSharedLocation";
            this.lblSharedLocation.Size = new System.Drawing.Size(128, 13);
            this.lblSharedLocation.TabIndex = 4;
            this.lblSharedLocation.Text = "Backup Shared Location:";
            // 
            // txtSharedLocation
            // 
            this.txtSharedLocation.Location = new System.Drawing.Point(154, 38);
            this.txtSharedLocation.Name = "txtSharedLocation";
            this.txtSharedLocation.Size = new System.Drawing.Size(311, 20);
            this.txtSharedLocation.TabIndex = 5;
            // 
            // lstBoxApplications
            // 
            this.lstBoxApplications.FormattingEnabled = true;
            this.lstBoxApplications.Location = new System.Drawing.Point(9, 64);
            this.lstBoxApplications.Name = "lstBoxApplications";
            this.lstBoxApplications.Size = new System.Drawing.Size(456, 225);
            this.lstBoxApplications.TabIndex = 6;
            this.lstBoxApplications.SelectedIndexChanged += new System.EventHandler(this.lstBoxApplications_SelectedIndexChanged);
            // 
            // btnAddApp
            // 
            this.btnAddApp.Location = new System.Drawing.Point(9, 296);
            this.btnAddApp.Name = "btnAddApp";
            this.btnAddApp.Size = new System.Drawing.Size(125, 23);
            this.btnAddApp.TabIndex = 9;
            this.btnAddApp.Text = "Add New Application";
            this.btnAddApp.UseVisualStyleBackColor = true;
            this.btnAddApp.Click += new System.EventHandler(this.btnAddApp_Click);
            // 
            // btnDelApp
            // 
            this.btnDelApp.Enabled = false;
            this.btnDelApp.Location = new System.Drawing.Point(340, 296);
            this.btnDelApp.Name = "btnDelApp";
            this.btnDelApp.Size = new System.Drawing.Size(125, 23);
            this.btnDelApp.TabIndex = 10;
            this.btnDelApp.Text = "Delete Application";
            this.btnDelApp.UseVisualStyleBackColor = true;
            this.btnDelApp.Click += new System.EventHandler(this.btnDelApp_Click);
            // 
            // btnEditApp
            // 
            this.btnEditApp.Enabled = false;
            this.btnEditApp.Location = new System.Drawing.Point(182, 296);
            this.btnEditApp.Name = "btnEditApp";
            this.btnEditApp.Size = new System.Drawing.Size(125, 23);
            this.btnEditApp.TabIndex = 11;
            this.btnEditApp.Text = "Edit Application";
            this.btnEditApp.UseVisualStyleBackColor = true;
            this.btnEditApp.Click += new System.EventHandler(this.btnEditApp_Click);
            // 
            // Settings
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(481, 365);
            this.ControlBox = false;
            this.Controls.Add(this.btnEditApp);
            this.Controls.Add(this.btnDelApp);
            this.Controls.Add(this.btnAddApp);
            this.Controls.Add(this.lstBoxApplications);
            this.Controls.Add(this.txtSharedLocation);
            this.Controls.Add(this.lblSharedLocation);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblBackupLocation);
            this.Controls.Add(this.txtBackupLocation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBackupLocation;
        private System.Windows.Forms.Label lblBackupLocation;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolTip toolTipSaveLocation;
        private System.Windows.Forms.Label lblSharedLocation;
        private System.Windows.Forms.TextBox txtSharedLocation;
        private System.Windows.Forms.ListBox lstBoxApplications;
        private System.Windows.Forms.Button btnAddApp;
        private System.Windows.Forms.Button btnDelApp;
        private System.Windows.Forms.Button btnEditApp;
    }
}