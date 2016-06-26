using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class QuanLyDauSach : Form
    {
        public QuanLyDauSach()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMuonSach_Click(object sender, EventArgs e)
        {
            MuonSach MH_MuonSach = new MuonSach();
            MH_MuonSach.ShowDialog();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            DangKySach MH_DangKySach = new DangKySach();
            MH_DangKySach.ShowDialog();
        }
    }
}
