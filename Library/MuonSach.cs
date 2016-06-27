using Library.Controllers;
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

        // Controller
        private SachController SachControler = new SachController();


        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            // Kiểm tra thông tin đọc giả
            btnMuonSach.Enabled = true;
        }

        private void btnMuonSach_Click(object sender, EventArgs e)
        {
            if (SachControler.muonSach(int.Parse(tbDocGiaId.Text), QuanLyDauSach.isbnTransition, QuanLyDauSach.SachIdTransition) == true)
            {
                MessageBox.Show("Độc giả " + tbDocGiaId.Text + " đã mượn sách Thành công.", "Thống báo", MessageBoxButtons.OK);
            }
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
