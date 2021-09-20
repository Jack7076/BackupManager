using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MyITShopBackupManager
{
    public partial class MainForm : Form
    {
        private OverlayWindow olay = new OverlayWindow();
        public SQLiteConnection connection;
        public bool IsSymbolic(string path)
        {
            FileInfo pathInfo = new FileInfo(path);
            return pathInfo.Attributes.HasFlag(FileAttributes.ReparsePoint);
        }
        public void updateApplications()
        {
            SQLiteCommand cmd = new SQLiteCommand("SELECT name FROM applications", connection);
            SQLiteDataReader reader = cmd.ExecuteReader();
            List<string> applications = new List<string>();
            while (reader.Read())
            {
                applications.Add((string)reader["name"]);
            }
            listboxApplications.DataSource = null;
            listboxApplications.DataSource = applications;
            listboxApplications.DisplayMember = "Name";
        }
        public string getSharedLocation()
        {
            SQLiteCommand cmd = new SQLiteCommand("SELECT data FROM settings WHERE name = 'sharedLocation'", connection);
            SQLiteDataReader reader = cmd.ExecuteReader();
            reader.Read();
            return (string)reader["data"];
        }

        public string getBackupLocation()
        {
            SQLiteCommand cmd = new SQLiteCommand("SELECT data FROM settings WHERE name = 'BackupLocation'", connection);
            SQLiteDataReader reader = cmd.ExecuteReader();
            reader.Read();
            return (string)reader["data"];
        }
        public void logInfo(string text)
        {
            string currentTime = DateTime.Now.ToString("hh:mm");
            if (DateTime.Now.Hour >= 12)
            {
                currentTime += " pm";
            }
            else
            {
                currentTime += " am";
            }
            txtLog.AppendText(currentTime + ": " + text + Environment.NewLine);
        }
        public MainForm()
        {
            InitializeComponent();
            if (!File.Exists(Path.Combine(Path.Combine(Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]), "configuration.myitshop"))))
            {
                SQLiteConnection.CreateFile("configuration.myitshop");
                connection = new SQLiteConnection("Data Source=configuration.myitshop;Version=3;");
                connection.Open();
                SQLiteCommand cmd = new SQLiteCommand("CREATE TABLE applications (name VARCHAR(255), localpath TEXT)", connection);
                cmd.ExecuteNonQuery();
                cmd = new SQLiteCommand("CREATE TABLE settings (name VARCHAR(255), data TEXT)", connection);
                cmd.ExecuteNonQuery();
                cmd = new SQLiteCommand("INSERT INTO settings (name, data) VALUES ('BackupLocation', 'C:\\LocalBackup\\')", connection);
                cmd.ExecuteNonQuery();
                cmd = new SQLiteCommand("INSERT INTO settings (name, data) VALUES ('sharedLocation', 'C:\\DefaultSharedLocation\\')", connection);
                cmd.ExecuteNonQuery();
            }
            connection = new SQLiteConnection("Data Source=configuration.myitshop;Version=3;");
            connection.Open();
            updateApplications();
            olay.setActiveJob(Properties.Settings.Default.activeJob);
            olay.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            logInfo("Application Log:");
            logInfo("Program Loaded.");
            logInfo("Got Save Location: " + getBackupLocation());
            if (Properties.Settings.Default.activeJob != "No Job" && Properties.Settings.Default.activeJob != "Shared" && Properties.Settings.Default.activeJob != "App Default")
            {
                logInfo("Previous Job Settings loaded: " + Properties.Settings.Default.activeJob);
                txtJobID.Text = Properties.Settings.Default.activeJob;
            }
        }

        private void txtJobID_TextChanged(object sender, EventArgs e)
        {
            string verifiedString = "";
            char[] allowedChars = { 'J', 'O', 'B', '-', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'j', 'o', 'b' };
            if (txtJobID.Text.Length == 1)
            {
                int x;
                if (int.TryParse(txtJobID.Text, out x))
                {
                    string tmpText = txtJobID.Text;
                    txtJobID.Text = "JOB-" + tmpText;
                    txtJobID.SelectionStart = txtJobID.Text.Length;
                    txtJobID.SelectionLength = 0;
                }
            }
            foreach (char ch in txtJobID.Text)
            {
                if (!allowedChars.Contains(ch))
                {
                    System.Media.SystemSounds.Hand.Play();
                    logInfo("The character you attempted to type is not allowed in this text box.");
                    continue;
                }
                verifiedString += char.ToUpper(ch);
            }
            txtJobID.Text = verifiedString;
            txtJobID.SelectionStart = txtJobID.Text.Length;
            txtJobID.SelectionLength = 0;
        }

        private void listboxApplications_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                logInfo("Application \"" + listboxApplications.SelectedItem.ToString() + "\" Selected.");
            } catch (NullReferenceException){}
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Form setForm = new Settings(this);
            setForm.Show();
            setForm.FormClosing += settingsSaved;
        }

        private void settingsSaved(object sender, FormClosingEventArgs e)
        {
            logInfo("Save Location Updated: " + getBackupLocation());
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(getBackupLocation() + txtJobID.Text))
            {
                logInfo("Found Directory: " + getBackupLocation() + txtJobID.Text);

            }
            else
            {
                try
                {
                    Directory.CreateDirectory(getBackupLocation() + txtJobID.Text);
                    logInfo("Created Directory: " + getBackupLocation() + txtJobID.Text);
                }
                catch (DirectoryNotFoundException)
                {
                    logInfo("Unable to create directory: " + getBackupLocation() + txtJobID.Text + " Check to see if the directory is writable/mounted.");
                    MessageBox.Show("Unable to write in specified backup location. Check to make sure the backup location is mounted and accessible.", "Write Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }


            Process proc = new Process();
            ProcessStartInfo pcst = new ProcessStartInfo();
            pcst.WindowStyle = ProcessWindowStyle.Hidden;
            pcst.FileName = "cmd.exe";
            string year = DateTime.Now.Year.ToString();
            string month = DateTime.Now.Month.ToString();
            string day = DateTime.Now.Day.ToString();
            string hour = DateTime.Now.Hour.ToString();
            string minute = DateTime.Now.Minute.ToString();
            string second = DateTime.Now.Second.ToString();

            if(!Directory.Exists(getBackupLocation() + txtJobID.Text + "\\" + listboxApplications.SelectedItem.ToString()))
            {
                Directory.CreateDirectory(getBackupLocation() + txtJobID.Text + "\\" + listboxApplications.SelectedItem.ToString());
            }
            logInfo("Linking: " + listboxApplications.SelectedItem.ToString());
            SQLiteCommand cmd = new SQLiteCommand("SELECT localpath FROM applications WHERE name = '" + listboxApplications.SelectedItem.ToString() + "'", connection);
            SQLiteDataReader reader = cmd.ExecuteReader();
            reader.Read();
            if (IsSymbolic(Environment.ExpandEnvironmentVariables((string)reader["localpath"])))
            {
                try
                {
                    Directory.Delete(Environment.ExpandEnvironmentVariables((string)reader["localpath"]));
                }
                catch (DirectoryNotFoundException) { }
            }
            else
            {
                Directory.Move(Environment.ExpandEnvironmentVariables((string)reader["localpath"]), Environment.ExpandEnvironmentVariables((string)reader["localpath"]) + "-" + year + "-" + month + "-" + day + "-" + hour + "-" + minute + "-" + second);
                logInfo("Application Backup Directory has been linked, However a directory existed before, it has been renamed. (" + Environment.ExpandEnvironmentVariables((string)reader["localpath"]) + "-" + year + "-" + month + "-" + day + "-" + hour + "-" + minute + "-" + second + ") ");
            }
            pcst.Arguments = "/C mklink /D \"" + Environment.ExpandEnvironmentVariables((string)reader["localpath"]) + "\" \"" + getBackupLocation() + txtJobID.Text + "\\" + listboxApplications.SelectedItem.ToString() + "\"";
            proc.StartInfo = pcst;
            proc.Start();
            logInfo("Directory Linked. Ready to Backup.");
            Properties.Settings.Default.activeJob = txtJobID.Text;
            Properties.Settings.Default.Save();
            olay.setActiveJob(txtJobID.Text);
        }

        private void btnResetToShared_Click(object sender, EventArgs e)
        {
            string year = DateTime.Now.Year.ToString();
            string month = DateTime.Now.Month.ToString();
            string day = DateTime.Now.Day.ToString();
            string hour = DateTime.Now.Hour.ToString();
            string minute = DateTime.Now.Minute.ToString();
            string second = DateTime.Now.Second.ToString();
            Process proc = new Process();
            ProcessStartInfo pcst = new ProcessStartInfo();
            pcst.WindowStyle = ProcessWindowStyle.Hidden;
            pcst.FileName = "cmd.exe";

            logInfo("Linking to shared: " + listboxApplications.SelectedItem.ToString());
            SQLiteCommand cmd = new SQLiteCommand("SELECT localpath FROM applications WHERE name = '" + listboxApplications.SelectedItem.ToString() + "'", connection);
            SQLiteDataReader reader = cmd.ExecuteReader();
            reader.Read();
            if (IsSymbolic(Environment.ExpandEnvironmentVariables((string)reader["localpath"])))
            {
                try
                {
                    Directory.Delete(Environment.ExpandEnvironmentVariables((string)reader["localpath"]));
                }
                catch (DirectoryNotFoundException) { }
            }
            else
            {
                Directory.Move(Environment.ExpandEnvironmentVariables((string)reader["localpath"]), Environment.ExpandEnvironmentVariables((string)reader["localpath"]) + "-" + year + "-" + month + "-" + day + "-" + hour + "-" + minute + "-" + second);
                logInfo("Application Backup Directory has been linked, However a directory existed before, it has been renamed. (" + Environment.ExpandEnvironmentVariables((string)reader["localpath"]) + "-" + year + "-" + month + "-" + day + "-" + hour + "-" + minute + "-" + second + ") ");
            }
            pcst.Arguments = "/C mklink /D \"" + Environment.ExpandEnvironmentVariables((string)reader["localpath"]) + "\" \"" + getSharedLocation() + "\"";
            proc.StartInfo = pcst;
            proc.Start();
            logInfo("Directory Link Reset to shared.");
            Properties.Settings.Default.activeJob = "Shared";
            Properties.Settings.Default.Save();
            olay.setActiveJob("Shared");
        }

        private void picLogo_DoubleClick(object sender, EventArgs e)
        {
            EasterEgg eg = new EasterEgg();
            eg.Show();
        }

        private void btnResetApplication_Click(object sender, EventArgs e)
        {
            logInfo("Setting to app default: " + listboxApplications.SelectedItem.ToString());
            SQLiteCommand cmd = new SQLiteCommand("SELECT localpath FROM applications WHERE name = '" + listboxApplications.SelectedItem.ToString() + "'", connection);
            SQLiteDataReader reader = cmd.ExecuteReader();
            reader.Read();

            if (IsSymbolic(Environment.ExpandEnvironmentVariables((string)reader["localpath"])))
            {
                try
                {
                    Directory.Delete(Environment.ExpandEnvironmentVariables((string)reader["localpath"]));
                }
                catch (DirectoryNotFoundException) { }
                Directory.CreateDirectory(Environment.ExpandEnvironmentVariables((string)reader["localpath"]));
            }
            else
            {
                logInfo("Application datastore was already set to local.");
            }
            logInfo("Directory Link Reset to local.");
            Properties.Settings.Default.activeJob = "App Default";
            Properties.Settings.Default.Save();
            olay.setActiveJob("App Default");
        }
        public bool IsValidFilename(string testName)
        {
            string regexString = "[" + Regex.Escape(Path.GetInvalidPathChars().ToString()) + "]";
            Regex containsABadCharacter = new Regex(regexString);

            if (containsABadCharacter.IsMatch(testName))
            {
                return false;
            }
            return true;
        }
    }
}
