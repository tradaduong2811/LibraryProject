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
        int isbn;
        DocGiaController docgiacontrl = new DocGiaController();
        SachController sachcontrl = new SachController();
        public DangKySach()
        {
            InitializeComponent();
            btnDangKy.Enabled = false;
            dtpNgayDangKy.Value = DateTime.Now;
            dtpNgayDangKy.Enabled = false;
           
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            if(docgiacontrl.kiemtraDocGia(int.Parse(txtMaDocGia.Text)) == true)
            {
                btnDangKy.Enabled = true;
                DialogResult result = MessageBox.Show("Mã hợp lệ", "Confirm", MessageBoxButtons.OK);
            }
            else
            {
                DialogResult result = MessageBox.Show("Mã không hợp lệ", "Confirm", MessageBoxButtons.OK);
                txtMaDocGia.Text = "";
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (!sachcontrl.dangkyMuonSach(isbn, int.Parse(txtMaDocGia.Text), dtpNgayDangKy.Value.Date))
            {
                DialogResult result = MessageBox.Show("Bạn không được phép mượn sách này", "Confirm", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn đã đăng ký mượn thành công", "Confirm", MessageBoxButtons.OK);
                this.Close();
            }
        }

        public void fillData(Sach sach)
        {
            isbn = sach.Isbn;
            txtTuaSach.Text = sach.TenTuaSach;
            txtTacGia.Text = sach.TacGia;
            txtNgonNgu.Text = sach.NgonNgu;
            txtBiaSach.Text = sach.Bia;     
        }

        private void txtMaDocGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
               && !char.IsDigit(e.KeyChar)
               && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
       
    }
}
