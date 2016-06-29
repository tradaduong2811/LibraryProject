namespace Library
{
    partial class QuanLyDauSach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.btnMuonSach = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTomTat = new System.Windows.Forms.RichTextBox();
            this.tbTacGia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTuaSach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTimKiem = new System.Windows.Forms.TextBox();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.tbSoSachCon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNgonNgu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbBiaSach = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.dgvMuon = new System.Windows.Forms.DataGridView();
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnLamMoi = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuon)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(527, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 27);
            this.button2.TabIndex = 21;
            this.button2.Text = "Tìm kiếm";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnMuonSach
            // 
            this.btnMuonSach.Enabled = false;
            this.btnMuonSach.Location = new System.Drawing.Point(807, 318);
            this.btnMuonSach.Name = "btnMuonSach";
            this.btnMuonSach.Size = new System.Drawing.Size(75, 32);
            this.btnMuonSach.TabIndex = 19;
            this.btnMuonSach.Text = "Mượn sách";
            this.btnMuonSach.UseVisualStyleBackColor = true;
            this.btnMuonSach.Click += new System.EventHandler(this.btnMuonSach_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tóm tắt";
            // 
            // tbTomTat
            // 
            this.tbTomTat.Location = new System.Drawing.Point(83, 160);
            this.tbTomTat.Name = "tbTomTat";
            this.tbTomTat.ReadOnly = true;
            this.tbTomTat.Size = new System.Drawing.Size(233, 70);
            this.tbTomTat.TabIndex = 4;
            this.tbTomTat.Text = "";
            // 
            // tbTacGia
            // 
            this.tbTacGia.Location = new System.Drawing.Point(83, 82);
            this.tbTacGia.Name = "tbTacGia";
            this.tbTacGia.ReadOnly = true;
            this.tbTacGia.Size = new System.Drawing.Size(233, 20);
            this.tbTacGia.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tác giả";
            // 
            // tbTuaSach
            // 
            this.tbTuaSach.Location = new System.Drawing.Point(83, 24);
            this.tbTuaSach.Multiline = true;
            this.tbTuaSach.Name = "tbTuaSach";
            this.tbTuaSach.ReadOnly = true;
            this.tbTuaSach.Size = new System.Drawing.Size(233, 52);
            this.tbTuaSach.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tựa sách";
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.Location = new System.Drawing.Point(12, 63);
            this.tbTimKiem.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.tbTimKiem.Multiline = true;
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(492, 27);
            this.tbTimKiem.TabIndex = 20;
            this.tbTimKiem.Tag = "";
            // 
            // dgvSach
            // 
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Location = new System.Drawing.Point(12, 96);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.ReadOnly = true;
            this.dgvSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSach.Size = new System.Drawing.Size(623, 214);
            this.dgvSach.TabIndex = 17;
            this.dgvSach.Click += new System.EventHandler(this.dgvSach_Click);
            // 
            // tbSoSachCon
            // 
            this.tbSoSachCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSoSachCon.ForeColor = System.Drawing.Color.Red;
            this.tbSoSachCon.Location = new System.Drawing.Point(724, 318);
            this.tbSoSachCon.Multiline = true;
            this.tbSoSachCon.Name = "tbSoSachCon";
            this.tbSoSachCon.ReadOnly = true;
            this.tbSoSachCon.Size = new System.Drawing.Size(77, 32);
            this.tbSoSachCon.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(647, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số sách còn";
            // 
            // tbNgonNgu
            // 
            this.tbNgonNgu.Location = new System.Drawing.Point(83, 108);
            this.tbNgonNgu.Name = "tbNgonNgu";
            this.tbNgonNgu.ReadOnly = true;
            this.tbNgonNgu.Size = new System.Drawing.Size(90, 20);
            this.tbNgonNgu.TabIndex = 1;
            this.tbNgonNgu.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngôn ngữ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbBiaSach);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbTomTat);
            this.groupBox1.Controls.Add(this.tbNgonNgu);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbTacGia);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbTuaSach);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(641, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 247);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Sách";
            // 
            // tbBiaSach
            // 
            this.tbBiaSach.Location = new System.Drawing.Point(83, 134);
            this.tbBiaSach.Name = "tbBiaSach";
            this.tbBiaSach.ReadOnly = true;
            this.tbBiaSach.Size = new System.Drawing.Size(123, 20);
            this.tbBiaSach.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Bìa sách";
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(888, 318);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(75, 32);
            this.btnDangKy.TabIndex = 22;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // dgvMuon
            // 
            this.dgvMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMuon.Location = new System.Drawing.Point(12, 349);
            this.dgvMuon.Name = "dgvMuon";
            this.dgvMuon.ReadOnly = true;
            this.dgvMuon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMuon.Size = new System.Drawing.Size(623, 155);
            this.dgvMuon.TabIndex = 23;
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.thêmToolStripMenuItem.Text = "Home";
            // 
            // cậpNhậtToolStripMenuItem
            // 
            this.cậpNhậtToolStripMenuItem.Name = "cậpNhậtToolStripMenuItem";
            this.cậpNhậtToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.cậpNhậtToolStripMenuItem.Text = "View";
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.xóaToolStripMenuItem.Text = "Help";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmToolStripMenuItem,
            this.cậpNhậtToolStripMenuItem,
            this.xóaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1013, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(35, 35);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLamMoi,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1013, 25);
            this.toolStrip1.TabIndex = 29;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(58, 22);
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(259, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 18);
            this.label7.TabIndex = 30;
            this.label7.Text = "Sách đang mượn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(301, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 18);
            this.label8.TabIndex = 31;
            this.label8.Text = "Sách";
            // 
            // QuanLyDauSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 527);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvMuon);
            this.Controls.Add(this.tbSoSachCon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnMuonSach);
            this.Controls.Add(this.tbTimKiem);
            this.Controls.Add(this.dgvSach);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "QuanLyDauSach";
            this.Text = "Quản lý sách";
            this.Load += new System.EventHandler(this.QuanLyDauSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuon)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnMuonSach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox tbTomTat;
        private System.Windows.Forms.TextBox tbTacGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTuaSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTimKiem;
        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNgonNgu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSoSachCon;
        private System.Windows.Forms.TextBox tbBiaSach;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.DataGridView dgvMuon;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnLamMoi;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}