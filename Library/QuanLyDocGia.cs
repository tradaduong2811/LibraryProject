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
            KhoiTao();
            loadDocGia();
            loadDocGiaDangKyMuon();
        }

        private void KhoiTao()
        {
            
        }

        // Biến toàn cục
        private int DocGiaId;
        private int NguoiLonId;
        
        /// <summary>
        /// Init Controller
        /// </summary>

        DocGiaController DocGiaController = new DocGiaController();
        DangKyController DangKyController = new DangKyController();

        public void loadDocGia()
        {
            if (DocGiaController.loadDocGia() == null)
            {
                MessageBox.Show("Xảy ra lỗi lấy dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dgvDocGia.DataSource = DocGiaController.loadDocGia();
                dgvDocGia.Columns[0].HeaderText = "Id";
                dgvDocGia.Columns[0].Width = 50;
                dgvDocGia.Columns[1].HeaderText = "Họ";
                dgvDocGia.Columns[1].Width = 50;
                dgvDocGia.Columns[2].HeaderText = "Tên lót";
                dgvDocGia.Columns[2].Width = 50;
                dgvDocGia.Columns[3].HeaderText = "Tên";
                dgvDocGia.Columns[3].Width = 50;
                dgvDocGia.Columns[4].HeaderText = "Số nhà";
                dgvDocGia.Columns[4].Width = 70;
                dgvDocGia.Columns[5].HeaderText = "Đường";
                dgvDocGia.Columns[5].Width = 150;
                dgvDocGia.Columns[6].HeaderText = "Quận";
                dgvDocGia.Columns[6].Width = 70;
                dgvDocGia.Columns[7].HeaderText = "Điện thoại";
                dgvDocGia.Columns[7].Width = 100;
                dgvDocGia.Columns[8].Visible = false; // Ẩn mã người lớn

                dgvDocGia.Columns[9].HeaderText = "Ngày sinh";

            }
            
        }

        public void loadDocGiaDangKyMuon()
        {
            if (DocGiaController.loadDocGia() == null)
            {
                MessageBox.Show("Xảy ra lỗi lấy dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dgvDangKy.DataSource = DangKyController.loadDocGiaDangKySach();
                dgvDangKy.Columns[0].HeaderText = "Isbn";
                dgvDangKy.Columns[0].Width = 50;
                dgvDangKy.Columns[1].HeaderText = "Mã đọc giả";
                dgvDangKy.Columns[1].Width = 80;
                dgvDangKy.Columns[2].HeaderText = "Tên";
                dgvDangKy.Columns[2].Width = 150;

            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            // Xác nhận cập nhật thông tin đọc giả khi users nhấn vào "Cập nhật" trên
            // thanh taskbar
            if (NguoiLonId != 0)
            {
                
                DocGiaController.chinhsuaTreEm(DocGiaId, tbHo.Text, tbTenLot.Text, tbTen.Text, tbNgaySinh.Value);
                MessageBox.Show("Chỉnh sửa thành công!");

                // demo repeatable read
                //loadDocGia();
            }
            else
            {
                DocGiaController.chinhsuaNguoiLon(DocGiaId, tbHo.Text, tbTenLot.Text, tbTen.Text, tbNgaySinh.Value,
                                                    tbSoNha.Text, tbDuong.Text, tbQuan.Text, tbDienThoai.Text);
                MessageBox.Show("Chỉnh sửa thành công!");


                // demo repeatable read
                //loadDocGia();
            }
                
            
                        

        }

        private void btnThemTreEm_Click(object sender, EventArgs e)
        {
            // Hiển thị màn hình thêm người đọc giả
            // Đồng thời disable 1 số fields không cần thiết
            // Giữ lại giá trị của người lớn quản lý
            ThemDocGia MH_ThemDocGia = new ThemDocGia();
            MH_ThemDocGia.adult = false;
            MH_ThemDocGia.ShowDialog();
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




        private void dgvDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dgvDocGia.SelectedRows.Count; i++)
            {
                // Lấy mã đọc giả
                DocGiaId = int.Parse(dgvDocGia.SelectedRows[i].Cells[0].Value.ToString());
                // Lấy mã đọc giả người lớn
                NguoiLonId = int.Parse(dgvDocGia.SelectedRows[i].Cells[8].Value.ToString());
                // gắn lên textbox
                tbHo.Text = dgvDocGia.SelectedRows[i].Cells[1].Value.ToString();
                tbTenLot.Text = dgvDocGia.SelectedRows[i].Cells[2].Value.ToString();
                if (dgvDocGia.SelectedRows[i].Cells[9].Value != null)
                {
                    //tbHo.Text = DateTime.Parse(dgvDocGia.SelectedRows[i].Cells[8].Value.ToString());
                    tbNgaySinh.Value = DateTime.Parse(dgvDocGia.SelectedRows[i].Cells[9].Value.ToString());
                }
                    
                tbTen.Text = dgvDocGia.SelectedRows[i].Cells[3].Value.ToString();
                tbSoNha.Text = dgvDocGia.SelectedRows[i].Cells[4].Value.ToString();
                tbDuong.Text = dgvDocGia.SelectedRows[i].Cells[5].Value.ToString();
                tbQuan.Text = dgvDocGia.SelectedRows[i].Cells[6].Value.ToString();
                tbDienThoai.Text = dgvDocGia.SelectedRows[i].Cells[7].Value.ToString();
                ReadOnlyStatus(true, true);
            }
        }


        /// <summary>
        /// Thay đổi trạng thái của các button khi có những chức năng tương ứng khác nhau        
        /// </summary>
        /// <param name="stat"> Trạng thái</param>
        private void ReadOnlyStatus(bool stat, bool adult)
        {
            tbNgaySinh.Enabled = !stat;
            btnXacNhan.Enabled = !stat;
            tbHo.ReadOnly = stat;
            tbTenLot.ReadOnly = stat;
            tbTen.ReadOnly = stat;
            if (adult == true)
            {
                tbSoNha.ReadOnly = stat;
                tbDuong.ReadOnly = stat;
                tbQuan.ReadOnly = stat;
                tbDienThoai.ReadOnly = stat;
            }
                
                
        }
        private void SBtnChinhSua_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Bạn có muốn chỉnh sửa " + " không?",
                                               "Chỉnh sửa?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                                               MessageBoxDefaultButton.Button2);
            if (dialogresult == DialogResult.OK)
            {
                //int result = VendorsController.removeVendor(VendorId);
                if (NguoiLonId != 0)
                {
                    ReadOnlyStatus(false, false);
                }
                else
                {
                    ReadOnlyStatus(false, true);
                }
                    

            }
        }

        private void tsbtnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Bạn muốn xóa đọc giả MS " + DocGiaId.ToString() + " ?",
                                               "Xóa?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning,
                                               MessageBoxDefaultButton.Button2);
            if (dialogresult == DialogResult.OK)
            {
                bool result = DocGiaController.xoaDocGia(DocGiaId);
                if (result == false)
                {
                    MessageBox.Show("Đọc giả Mã số " + DocGiaId + " không thể xóa.",
                    "Cảnh cáo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
                }
                if (result == true)
                {
                    MessageBox.Show("Đã xóa đọc giả Mã số " + DocGiaId + ".", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.None);
                    // cập nhật lại danh sách nhà cung cấp
                    loadDocGia();
                    dgvDocGia.Update();
                    dgvDocGia.Refresh();
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            loadDocGia();
        }
    }
}
