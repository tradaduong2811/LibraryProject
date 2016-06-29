using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Restore : Form
    {
        string sql;
        SqlCommand command;
        SqlConnection conn;
        string strConnectN = @"Data Source=.\SQLEXPRESS ; Initial Catalog=QUAN_LY_THU_VIEN;Integrated Security=True";
        public Restore()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Backup Files(*.bak)|*.bak|All Files(*.*)|*.*";
            dlg.FilterIndex = 0;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = dlg.FileName;
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(strConnectN);
                conn.Open();
                sql = "USE master;";
                sql += "Alter Database QUAN_LY_THU_VIEN Set SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                sql += "Restore Database QUAN_LY_THU_VIEN FROM Disk = '" + txtPath.Text + "' WITH REPLACE;";
                command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();

                string Alter2 = @"ALTER DATABASE [QUAN_LY_THU_VIEN] SET Multi_User";
                SqlCommand Alter2Cmd = new SqlCommand(Alter2, conn);
                Alter2Cmd.ExecuteNonQuery();
                conn.Close();
                conn.Dispose();
                this.Close();
                MessageBox.Show("Restore Database Successfully");
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
