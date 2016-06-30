using Library.Controllers;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library
{
    public partial class Backup : Form
    {
        BackupController backupcontrl = new BackupController();
        public Backup()
        {
            InitializeComponent();
        }
        private void Backup_Load(object sender, EventArgs e)
        {
            try
            {
                SqlDataReader reader = backupcontrl.LoadDatabase();
                cbbDatabase.Items.Clear();
                while (reader.Read())
                {
                    cbbDatabase.Items.Add(reader[0].ToString());
                }
                SqlConnection con = new SqlConnection();
                con = Provider.ConnectionData();
                con.Close();
                con.Dispose();
            }
            catch (Exception)
            {
                
                throw;
            }

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDlg = new FolderBrowserDialog();
            folderBrowserDlg.ShowNewFolderButton = false;
            DialogResult dlgResult = folderBrowserDlg.ShowDialog();
            if (dlgResult.Equals(DialogResult.OK))
            {
                txtPath.Text = folderBrowserDlg.SelectedPath;
                Environment.SpecialFolder rootFolder = folderBrowserDlg.RootFolder;
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbbDatabase.Text.CompareTo("") == 0)
                {
                    MessageBox.Show("Chọn database");
                }
                if (txtPath.Text == "")
                {
                    MessageBox.Show("Chọn đường dẫn");
                }
                backupcontrl.Backup(cbbDatabase.Text, txtPath.Text);
                MessageBox.Show("Database Backup Successfully");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
