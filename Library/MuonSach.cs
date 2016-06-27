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
    public partial class MuonSach : Form
    {
        public MuonSach()
        {
            InitializeComponent();
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            // Kiểm tra thông tin đọc giả
        }

        private void btnMuonSach_Click(object sender, EventArgs e)
        {
            // Xác nhận mượn sách
        }

        private void loadChiTietSach()
        {
            tbTuaSach.Text = QuanLyDauSach.TuaSachTransition;
            tbTacGia.Text = QuanLyDauSach.TacGiaTransition;
            tbNgonNgu.Text = QuanLyDauSach.NgonNguTransition;
        }


        private void MuonSach_Load(object sender, EventArgs e)
        {
            loadChiTietSach();
        }
    }
}
