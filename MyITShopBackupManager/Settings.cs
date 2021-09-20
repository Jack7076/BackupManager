using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;

namespace MyITShopBackupManager
{
    public partial class Settings : Form
    {
        public MainForm parent;
        public Settings(MainForm p)
        {
            parent = p;
            InitializeComponent();
        }

        public void updateList()
        {
            SQLiteCommand cmd = new SQLiteCommand("SELECT name FROM applications", parent.connection);
            SQLiteDataReader reader = cmd.ExecuteReader();
            List<string> applications = new List<string>();
            while (reader.Read())
            {
                applications.Add((string)reader["name"]);
            }
            lstBoxApplications.DataSource = null;
            lstBoxApplications.DataSource = applications;
            lstBoxApplications.DisplayMember = "Name";
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            toolTipSaveLocation.SetToolTip(txtBackupLocation, "Please Enter the directory location with a trailing \\");
            txtBackupLocation.Text = parent.getBackupLocation();
            txtSharedLocation.Text = parent.getSharedLocation();
            updateList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtBackupLocation.Text[txtBackupLocation.Text.Length - 1] != '\\')
            {
                if (Directory.Exists(txtBackupLocation.Text))
                {
                    txtBackupLocation.Text += "\\";
                } else
                {
                    MessageBox.Show("The directory you entered is invalid or inaccessable. Please Enter a valid directory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            } else
            {
                if (!Directory.Exists(txtBackupLocation.Text.Remove(txtBackupLocation.Text.Length - 1)))
                {
                    MessageBox.Show("The directory you entered is invalid or inaccessable. Please Enter a valid directory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (txtSharedLocation.Text[txtSharedLocation.Text.Length - 1] != '\\')
            {
                if (Directory.Exists(txtSharedLocation.Text))
                {
                    txtSharedLocation.Text += "\\";
                }
                else
                {
                    MessageBox.Show("The directory you entered is invalid or inaccessable. Please Enter a valid directory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                if (!Directory.Exists(txtSharedLocation.Text.Remove(txtSharedLocation.Text.Length - 1)))
                {
                    MessageBox.Show("The directory you entered is invalid or inaccessable. Please Enter a valid directory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            SQLiteCommand cmd = new SQLiteCommand("UPDATE settings SET data = '" + txtBackupLocation.Text + "' WHERE name = 'BackupLocation'", parent.connection);
            cmd.ExecuteNonQuery();
            cmd = new SQLiteCommand("UPDATE settings SET data = '" + txtSharedLocation.Text + "' WHERE name = 'sharedLocation'", parent.connection);
            cmd.ExecuteNonQuery();
            parent.updateApplications();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            parent.logInfo("Backup Locations has not been saved.");
            this.Close();
        }

        private void lstBoxApplications_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDelApp.Enabled = true;
            btnEditApp.Enabled = true;
        }

        private void btnAddApp_Click(object sender, EventArgs e)
        {
            AddApplication app = new AddApplication(this);
            app.Show();
            app.FormClosing += updateListClosing;
        }
        void updateListClosing(object sender, FormClosingEventArgs e)
        {
            updateList();
        }

        private void btnEditApp_Click(object sender, EventArgs e)
        {
            AddApplication app = new AddApplication(this, "edit", lstBoxApplications.SelectedItem.ToString());
            app.Show();
            app.FormClosing += updateListClosing;
        }

        private void btnDelApp_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show("Confirm Deletion of " + lstBoxApplications.SelectedItem.ToString(), "Confirm Action", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(response == DialogResult.Yes)
            {
                parent.logInfo("Deleted " + lstBoxApplications.SelectedItem.ToString());
                SQLiteCommand cmd = new SQLiteCommand("DELETE FROM applications WHERE name = '" + lstBoxApplications.SelectedItem.ToString() + "'", parent.connection);
                cmd.ExecuteNonQuery();
                parent.updateApplications();
                updateList();
            }
        }
    }
}
