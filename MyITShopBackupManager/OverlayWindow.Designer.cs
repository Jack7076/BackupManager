namespace MyITShopBackupManager
{
    partial class OverlayWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OverlayWindow));
            this.lblActiveJob = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblActiveJob
            // 
            this.lblActiveJob.AutoSize = true;
            this.lblActiveJob.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblActiveJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveJob.Location = new System.Drawing.Point(0, 0);
            this.lblActiveJob.Name = "lblActiveJob";
            this.lblActiveJob.Size = new System.Drawing.Size(237, 42);
            this.lblActiveJob.TabIndex = 0;
            this.lblActiveJob.Text = "JOB-XXXXX";
            this.lblActiveJob.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OverlayWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 48);
            this.ControlBox = false;
            this.Controls.Add(this.lblActiveJob);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OverlayWindow";
            this.Opacity = 0.3D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "OverlayWindow";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.OverlayWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblActiveJob;
    }
}