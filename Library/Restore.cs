using Library.Controllers;
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
        RestoreController rescontrl = new RestoreController();
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
                if (txtPath.Text == "")
                {
                    MessageBox.Show("Chọn đường dẫn");
                }
                rescontrl.Restore(txtPath.Text);
                this.Close();
                MessageBox.Show("Restore Database Successfully");
                SqlConnection con = new SqlConnection();
                con = Provider.ConnectionData();
                con.Close();
                con.Dispose();
            }
            catch (Exception)
            {
            }
        }
    }
}
