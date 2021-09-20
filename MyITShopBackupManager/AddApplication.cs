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
    public partial class AddApplication : Form
    {
        Settings parent;
        string Gmode;
        string Gappname;
        public AddApplication(Settings set, string mode = "add", string appname = "none")
        {
            parent = set;
            Gmode = mode;
            Gappname = appname;
            InitializeComponent();
            if(Gmode == "edit")
            {
                txtAppName.Text = Gappname;
                SQLiteCommand cmd = new SQLiteCommand("SELECT localpath FROM applications WHERE name = '" + Gappname + "'", parent.parent.connection);
                SQLiteDataReader reader = cmd.ExecuteReader();
                reader.Read();
                txtAppDirectory.Text = (string)reader["localpath"];
                btnAddApp.Text = "Save";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddApp_Click(object sender, EventArgs e)
        {
            if (!parent.parent.IsValidFilename(txtAppName.Text))
            {
                MessageBox.Show("The application name you enterted cannot be saved as a folder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Directory.Exists(Environment.ExpandEnvironmentVariables(txtAppDirectory.Text)))
            {
                MessageBox.Show("The directory you entered is invalid or inaccessable. Please Enter a valid directory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Gmode == "add")
            {
                SQLiteCommand cmd = new SQLiteCommand("INSERT INTO applications (name, localpath) VALUES ('" + txtAppName.Text + "', '" + txtAppDirectory.Text + "')", parent.parent.connection);
                cmd.ExecuteNonQuery();
            }
            if (Gmode == "edit")
            {
                SQLiteCommand cmd = new SQLiteCommand("UPDATE applications SET name = '" + txtAppName.Text + "', localpath = '" + txtAppDirectory.Text + "'", parent.parent.connection);
                cmd.ExecuteNonQuery();
            }
            
            this.Close();
        }
    }
}
