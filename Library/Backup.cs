using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library
{
    public partial class Backup : Form
    {
        private SqlCommand command;
        private SqlDataReader reader;
        SqlConnection conn;
        string strConnectN = @"Data Source=.\SQLEXPRESS ; Initial Catalog=QUAN_LY_THU_VIEN;Integrated Security=True";
        public Backup()
        {
            InitializeComponent();
        }

        string sql = "";
        private void Backup_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(strConnectN);
                conn.Open();
                sql = "EXEC sp_databases";
                command = new SqlCommand(sql, conn);

                reader = command.ExecuteReader();
                cbbDatabase.Items.Clear();
                while (reader.Read())
                {
                    cbbDatabase.Items.Add(reader[0].ToString());
                }
                conn.Close();
                conn.Dispose();
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
            //Backup bkp = new Backup();
            //conn = new ServerConnection();
            //srvr = new Server(conn);
            //try
            //{
            //    string databaseName = cbbDatabase.Text;
            //    bkp.Action = BackupActionType.Database;
            //    bkp.Database = databaseName;
            //    string path;
            //    if (!(txtPath.Text.EndsWith("\\")))
            //    {
            //        path = txtPath.Text + "\\";
            //    }
            //    else
            //    {
            //        path = txtPath.Text; 
            //   }
            //    BackupDeviceItem bkpDevice = new BackupDeviceItem(path + databaseName + ".bak", DeviceType.File);
            //    bkp.Devices.Add(bkpDevice);
            //    bkp.Incremental = false;
            //    bkp.SqlBackup(srvr);
            //    MessageBox.Show("Database Backup created successfully");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
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
                Provider.ConnectionData();
                sql = "BACKUP DATABASE " + cbbDatabase.Text + " TO DISK = '" + txtPath.Text + "\\" + cbbDatabase.Text + DateTime.Now.Ticks.ToString() +".bak'";
                command = new SqlCommand(sql, Provider.ConnectionData());
                command.ExecuteNonQuery();
                conn.Close();
                conn.Dispose();
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
