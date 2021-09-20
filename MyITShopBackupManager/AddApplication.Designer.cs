namespace MyITShopBackupManager
{
    partial class AddApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddApplication));
            this.lblAppName = new System.Windows.Forms.Label();
            this.lblAppDirectory = new System.Windows.Forms.Label();
            this.txtAppName = new System.Windows.Forms.TextBox();
            this.txtAppDirectory = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddApp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Location = new System.Drawing.Point(52, 9);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(96, 13);
            this.lblAppName.TabIndex = 0;
            this.lblAppName.Text = "Application Name: ";
            // 
            // lblAppDirectory
            // 
            this.lblAppDirectory.AutoSize = true;
            this.lblAppDirectory.Location = new System.Drawing.Point(12, 53);
            this.lblAppDirectory.Name = "lblAppDirectory";
            this.lblAppDirectory.Size = new System.Drawing.Size(136, 13);
            this.lblAppDirectory.TabIndex = 1;
            this.lblAppDirectory.Text = "Application Data Directory: ";
            // 
            // txtAppName
            // 
            this.txtAppName.Location = new System.Drawing.Point(154, 6);
            this.txtAppName.Name = "txtAppName";
            this.txtAppName.Size = new System.Drawing.Size(230, 20);
            this.txtAppName.TabIndex = 2;
            // 
            // txtAppDirectory
            // 
            this.txtAppDirectory.Location = new System.Drawing.Point(154, 50);
            this.txtAppDirectory.Name = "txtAppDirectory";
            this.txtAppDirectory.Size = new System.Drawing.Size(230, 20);
            this.txtAppDirectory.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(15, 88);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddApp
            // 
            this.btnAddApp.Location = new System.Drawing.Point(308, 88);
            this.btnAddApp.Name = "btnAddApp";
            this.btnAddApp.Size = new System.Drawing.Size(75, 23);
            this.btnAddApp.TabIndex = 5;
            this.btnAddApp.Text = "Add";
            this.btnAddApp.UseVisualStyleBackColor = true;
            this.btnAddApp.Click += new System.EventHandler(this.btnAddApp_Click);
            // 
            // AddApplication
            // 
            this.AcceptButton = this.btnAddApp;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(395, 123);
            this.Controls.Add(this.btnAddApp);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtAppDirectory);
            this.Controls.Add(this.txtAppName);
            this.Controls.Add(this.lblAppDirectory);
            this.Controls.Add(this.lblAppName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Application Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblAppDirectory;
        private System.Windows.Forms.TextBox txtAppName;
        private System.Windows.Forms.TextBox txtAppDirectory;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddApp;
    }
}