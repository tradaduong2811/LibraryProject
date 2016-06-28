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
    public partial class TraSach : Form
    {
        SachController sachcontrl = new SachController();
        private bool btnCheckISBNClick = false;
        private bool btnCheckIdSachClick = false;
        private bool btnCheckMaDocGiaClick = false;

        public TraSach()
        {
            InitializeComponent();
            btnTraSach.Enabled = false;
            btnCheckISBN.Enabled = false;
            btnCheckMaDocGia.Enabled = false;
            btnCheckIdSach.Enabled = false;
        }

        private void btnCheckISBN_Click(object sender, EventArgs e)
        {
            // Kiểm tra nhập text chưa
            // Kiểm tra mã ISBN có tồn tại không?
            // Không thì thông báo
            // Có thì thôi 
            if (sachcontrl.kiemtraISBN(int.Parse(txtISBN.Text)))
            {
                MessageBox.Show("Hợp lệ");
                btnCheckISBNClick = true;
                UpdateView();
            }
            else
            {
                MessageBox.Show("Không hợp lệ");
                txtISBN.Text = "";
            }
     
        }

        private void btnCheckIdSach_Click(object sender, EventArgs e)
        {
            if (sachcontrl.kiemtraMaCuonSach((int.Parse(txtMaSach.Text)), int.Parse(txtISBN.Text)))
            {
                MessageBox.Show("Hợp lệ");
                btnCheckIdSachClick = true;
                UpdateView();
            }
            else
            {
                MessageBox.Show("Không hợp lệ");
                txtMaSach.Text = "";
            }
        }

        private void btnCheckMaDocGia_Click(object sender, EventArgs e)
        {
            DocGiaController docgiactrl = new DocGiaController();
            if (docgiactrl.kiemtraDocGia(int.Parse(txtMaDocGia.Text)))
            {
                MessageBox.Show("Hợp lệ");
                btnCheckMaDocGiaClick = true;
                UpdateView();
            }
            else
            {

                MessageBox.Show("Không hợp lệ");
                txtMaDocGia.Text = "";
            }
        }

        public void UpdateView()
        {
            if (btnCheckMaDocGiaClick == true & btnCheckISBNClick == true & btnCheckIdSachClick == true)
            {
                btnTraSach.Enabled = true;
            }
        }


        private void btnTraSach_Click(object sender, EventArgs e)
        {
            //Gọi Store trả sách
            try
            {
                 if (sachcontrl.traSach(int.Parse(txtISBN.Text), int.Parse(txtMaDocGia.Text), int.Parse(txtMaSach.Text)))
                {
                    MessageBox.Show("Trả sách thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra");
            }
           
                
        }

        private void txtISBN_TextChanged(object sender, EventArgs e)
        {
            btnCheckISBN.Enabled = !string.IsNullOrWhiteSpace(txtISBN.Text);
        }

        private void txtMaSach_TextChanged(object sender, EventArgs e)
        {
            btnCheckIdSach.Enabled = !string.IsNullOrWhiteSpace(txtMaSach.Text);
        }

        private void txtMaDocGia_TextChanged(object sender, EventArgs e)
        {
            btnCheckMaDocGia.Enabled = !string.IsNullOrWhiteSpace(txtMaDocGia.Text);
        }


        private void txtISBN_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtMaSach_KeyPress(object sender, KeyPressEventArgs e)
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
