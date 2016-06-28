using Library.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Controllers;

namespace Library
{
    public partial class DangKySach : Form
    {
        DocGiaController docgiacontrl = new DocGiaController();
        public DangKySach()
        {
            InitializeComponent();
            btnDangKy.Enabled = false;
            dtpNgayDangKy.Value = DateTime.Now;
            dtpNgayDangKy.Enabled = false;
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            if(docgiacontrl.kiemtraDocGia(int.Parse(txtMaDocGia.Text)))
            {
                btnDangKy.Enabled = true;
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            // Tiến hành đăng ký
            // Insert data into history borrow book
            // Chèn vào cuối trong hàng đợi
        }

        public void fillData(Sach sach)
        {
            txtTuaSach.Text = sach.TenTuaSach;
            txtTacGia.Text = sach.TacGia;
            txtNgonNgu.Text = sach.NgonNgu;
            txtBiaSach.Text = sach.Bia;     
        }
    }
}
