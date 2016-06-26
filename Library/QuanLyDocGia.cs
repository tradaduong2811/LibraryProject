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
    public partial class QuanLyDocGia : Form
    {
        public QuanLyDocGia()
        {
            InitializeComponent();
            loadDocGia();
        }


        /// <summary>
        /// Init Controller
        /// </summary>

        DocGiaController DocGiaController = new DocGiaController();

        private void loadDocGia()
        {
            dgvDocGia.DataSource = DocGiaController.loadDocGia();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            // Xác nhận cập nhật thông tin đọc giả khi users nhấn vào "Cập nhật" trên
            // thanh taskbar
        }

        private void btnThemTreEm_Click(object sender, EventArgs e)
        {
            // Hiển thị màn hình thêm người đọc giả
            // Đồng thời disable 1 số fields không cần thiết
            // Giữ lại giá trị của người lớn quản lý
        }

        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            // Hiển thị màn hình Thêm mới đọc giả
            ThemDocGia MH_ThemDocGia = new ThemDocGia();
            MH_ThemDocGia.ShowDialog();
        }

        private void QuanLyDocGia_Load(object sender, EventArgs e)
        {

        }
    }
}
