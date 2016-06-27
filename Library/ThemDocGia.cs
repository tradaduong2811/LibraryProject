﻿using Library.Controllers;
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
    public partial class ThemDocGia : Form
    {
        public ThemDocGia()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Controller
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private DocGiaController DocGiaController = new DocGiaController();

        // biến đánh dấu "adult" Người lớn = true hay trẻ em = false, mặc định là 1
        private bool adult = true;

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            // Thêm mới đọc giả
            // Automatical gán Mã cho đọc giả (nhờ Database)
            if (adult == true)
            {
                DocGiaController.themNguoiLon(tbHo.Text, tbTenLot.Text, tbTen.Text, tbNgaySinh.Value,
                                                tbSoNha.Text, tbDuong.Text, tbQuan.Text, tbDienThoai.Text);
                MessageBox.Show("Thêm đọc giả người lớn thành công.");
            }
            else
            {
                DocGiaController.themTreEm(tbHo.Text, tbTenLot.Text, tbTen.Text, tbNgaySinh.Value, int.Parse(tbMaNguoiLon.Text));
                MessageBox.Show("Thêm đọc giả trẻ em thành công.");
            }
        }


        /// <summary>
        /// Hàm thay đổi các textbox tránh lỗi cho việc insert dữ liệu
        /// </summary>
        /// <param name="stat"></param>
        private void changeStatus(bool stat)
        {
            btnNguoiLon.Enabled = stat;
            btnTreEm.Enabled = !stat;
            tbMaNguoiLon.Enabled = stat;
            tbDuong.Enabled = !stat;
            tbQuan.Enabled = !stat;
            tbSoNha.Enabled = !stat;
            tbDienThoai.Enabled = !stat;
            adult = !stat; // biến set Người lớn hay trẻ em
        }

        private void btnTreEm_Click(object sender, EventArgs e)
        {
            changeStatus(true);   
        }

        private void btnNguoiLon_Click(object sender, EventArgs e)
        {
            changeStatus(false);
        }
    }
}
