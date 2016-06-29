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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Hiển thị màn hình quản lý đầu sách
        /// 16-06-2016
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyDauSach MH_QuanLyDauSach = new QuanLyDauSach();
            MH_QuanLyDauSach.Show();
        }

        /// <summary>
        /// Hiển thị màn hình quản lý Đọc giả
        /// 16-06-2016
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quảnLýĐọcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyDocGia MH_QuanLyDocGia = new QuanLyDocGia();
            MH_QuanLyDocGia.Show();
        }

        private void backUpToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Backup back = new Backup();
            back.Show();
        }

        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Restore re = new Restore();
            re.Show();
        }
    }
}
