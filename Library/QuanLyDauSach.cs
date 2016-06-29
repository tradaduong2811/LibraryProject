using Library.Controllers;
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

namespace Library
{
    public partial class QuanLyDauSach : Form
    {
        public QuanLyDauSach()
        {
            InitializeComponent();
            loadSach();
            loadDocGiaMuonSach();
        }
        public delegate void delPassData(Sach sach);
       ///Biến cho việc luân chuyển giữa 2 giao diện
       ///
        public static int isbnTransition;
        public static int SachIdTransition;
        public static string TuaSachTransition = string.Empty;
        public static string TacGiaTransition = string.Empty;
        public static string NgonNguTransition = string.Empty;
        public static string BiaTransition = string.Empty;


        /// <summary>
        /// Controller
        /// </summary>
        private SachController SachController = new SachController();
        private MuonController MuonController = new MuonController();

        private void loadSach()
        {
            if (SachController.loadSach() == null)
            {
                MessageBox.Show("Xảy ra lỗi lấy dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dgvSach.DataSource = SachController.loadSach();
                dgvSach.Columns[0].HeaderText = "Isbn";
                dgvSach.Columns[0].Width = 50;
                dgvSach.Columns[1].HeaderText = "Mã ts";
                dgvSach.Columns[1].Width = 70;
            }
        }

        private void loadDocGiaMuonSach()
        {
            if (MuonController.loadDocGiaMuonSach() == null)
            {
                MessageBox.Show("Xảy ra lỗi lấy dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dgvMuon.DataSource = MuonController.loadDocGiaMuonSach();
                dgvMuon.Columns[0].HeaderText = "Isbn";
                dgvMuon.Columns[0].Width = 50;
                dgvMuon.Columns[1].HeaderText = "Mã đọc giả";
                dgvMuon.Columns[1].Width = 70;
                dgvMuon.Columns[2].HeaderText = "Tựa sách";
                dgvMuon.Columns[2].Width = 100;
            }
        }




        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMuonSach_Click(object sender, EventArgs e)
        {
            MuonSach MH_MuonSach = new MuonSach();
            int isbn = 0;
            int TuaSachId = 0;
            string TuaSach = string.Empty;
            string TacGia = string.Empty;
            string NgonNgu = string.Empty;

            for (int i = 0; i < dgvSach.SelectedRows.Count; i++)
            {
                isbn = int.Parse(dgvSach.SelectedRows[i].Cells[0].Value.ToString());
                TuaSachId = int.Parse(dgvSach.SelectedRows[i].Cells[1].Value.ToString());
                TuaSach = dgvSach.SelectedRows[i].Cells[2].Value.ToString();
                TacGia = dgvSach.SelectedRows[i].Cells[4].Value.ToString();
                NgonNgu = dgvSach.SelectedRows[i].Cells[7].Value.ToString();
            }


            // Gán giá trị chuyển qua màn hình Mượn sách
            isbnTransition = isbn;
            SachIdTransition = TuaSachId;
            TacGiaTransition = TacGia;
            TuaSachTransition = TuaSach;
            NgonNguTransition = NgonNgu;

            MH_MuonSach.ShowDialog();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            DangKySach MH_DangKySach = new DangKySach();

            for (int i = 0; i < dgvSach.SelectedRows.Count; i++)
            {
                isbnTransition = int.Parse(dgvSach.SelectedRows[i].Cells[0].Value.ToString());
            }

            Sach sach = new Sach();
            sach.Isbn = isbnTransition;
            sach.TenTuaSach = tbTuaSach.Text;
            sach.TacGia = tbTacGia.Text;
            sach.NgonNgu = tbNgonNgu.Text;
            sach.Bia = tbBiaSach.Text;
            delPassData del = new delPassData(MH_DangKySach.fillData);
            del(sach);

            MH_DangKySach.ShowDialog();
        }

        private void QuanLyDauSach_Load(object sender, EventArgs e)
        {

        }

        private void dgvSach_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvSach.SelectedRows.Count; i++)
            {
                tbNgonNgu.Text = dgvSach.SelectedRows[i].Cells[7].Value.ToString();
                tbBiaSach.Text = dgvSach.SelectedRows[i].Cells[2].Value.ToString();
                tbSoSachCon.Text = dgvSach.SelectedRows[i].Cells[5].Value.ToString();
                tbTomTat.Text = dgvSach.SelectedRows[i].Cells[3].Value.ToString();
                tbTuaSach.Text = dgvSach.SelectedRows[i].Cells[2].Value.ToString();
                tbTacGia.Text = dgvSach.SelectedRows[i].Cells[4].Value.ToString();
                
                // nếu sách còn mới bật nút mượn
                if (int.Parse(tbSoSachCon.Text) != 0)
                {
                    changeStatus(true);
                }
                else
                    changeStatus(false);
                 
            }
        }

        private void changeStatus(bool stat)
        {
            btnMuonSach.Enabled = stat;
            btnDangKy.Enabled = !stat;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            // load lại sách
            loadSach();
            loadDocGiaMuonSach();
            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvSach.DataSource = null;
            dgvSach.Rows.Clear();
            try
            {
                dgvSach.DataSource = SachController.timkiemSach(txtTimKiem.Text);
                dgvSach.Columns[0].HeaderText = "Isbn";
                dgvSach.Columns[0].Width = 50;
                dgvSach.Columns[1].HeaderText = "Mã ts";
                dgvSach.Columns[1].Width = 70;
                txtTimKiem.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi xảy ra");
            }

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            btnTimKiem.Enabled = !string.IsNullOrWhiteSpace(txtTimKiem.Text);
        }
    }
}
