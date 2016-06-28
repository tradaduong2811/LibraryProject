namespace Library
{
    partial class TraSach
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.btnCheckISBN = new System.Windows.Forms.Button();
            this.btnCheckIdSach = new System.Windows.Forms.Button();
            this.btnCheckMaDocGia = new System.Windows.Forms.Button();
            this.txtMaDocGia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTraSach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISBN";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(96, 42);
            this.txtISBN.Margin = new System.Windows.Forms.Padding(4);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(132, 22);
            this.txtISBN.TabIndex = 1;
            this.txtISBN.TextChanged += new System.EventHandler(this.txtISBN_TextChanged);
            this.txtISBN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtISBN_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã sách";
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(96, 84);
            this.txtMaSach.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(132, 22);
            this.txtMaSach.TabIndex = 3;
            this.txtMaSach.TextChanged += new System.EventHandler(this.txtMaSach_TextChanged);
            this.txtMaSach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaSach_KeyPress);
            // 
            // btnCheckISBN
            // 
            this.btnCheckISBN.Location = new System.Drawing.Point(237, 39);
            this.btnCheckISBN.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckISBN.Name = "btnCheckISBN";
            this.btnCheckISBN.Size = new System.Drawing.Size(51, 28);
            this.btnCheckISBN.TabIndex = 4;
            this.btnCheckISBN.Text = "Kiểm";
            this.btnCheckISBN.UseVisualStyleBackColor = true;
            this.btnCheckISBN.Click += new System.EventHandler(this.btnCheckISBN_Click);
            // 
            // btnCheckIdSach
            // 
            this.btnCheckIdSach.Location = new System.Drawing.Point(237, 81);
            this.btnCheckIdSach.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckIdSach.Name = "btnCheckIdSach";
            this.btnCheckIdSach.Size = new System.Drawing.Size(51, 28);
            this.btnCheckIdSach.TabIndex = 5;
            this.btnCheckIdSach.Text = "Kiểm";
            this.btnCheckIdSach.UseVisualStyleBackColor = true;
            this.btnCheckIdSach.Click += new System.EventHandler(this.btnCheckIdSach_Click);
            // 
            // btnCheckMaDocGia
            // 
            this.btnCheckMaDocGia.Location = new System.Drawing.Point(237, 121);
            this.btnCheckMaDocGia.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckMaDocGia.Name = "btnCheckMaDocGia";
            this.btnCheckMaDocGia.Size = new System.Drawing.Size(51, 28);
            this.btnCheckMaDocGia.TabIndex = 8;
            this.btnCheckMaDocGia.Text = "Kiểm";
            this.btnCheckMaDocGia.UseVisualStyleBackColor = true;
            this.btnCheckMaDocGia.Click += new System.EventHandler(this.btnCheckMaDocGia_Click);
            // 
            // txtMaDocGia
            // 
            this.txtMaDocGia.Location = new System.Drawing.Point(96, 124);
            this.txtMaDocGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaDocGia.Name = "txtMaDocGia";
            this.txtMaDocGia.Size = new System.Drawing.Size(132, 22);
            this.txtMaDocGia.TabIndex = 7;
            this.txtMaDocGia.TextChanged += new System.EventHandler(this.txtMaDocGia_TextChanged);
            this.txtMaDocGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaDocGia_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mã đọc giả";
            // 
            // btnTraSach
            // 
            this.btnTraSach.Location = new System.Drawing.Point(129, 169);
            this.btnTraSach.Margin = new System.Windows.Forms.Padding(4);
            this.btnTraSach.Name = "btnTraSach";
            this.btnTraSach.Size = new System.Drawing.Size(159, 28);
            this.btnTraSach.TabIndex = 9;
            this.btnTraSach.Text = "Trả sách";
            this.btnTraSach.UseVisualStyleBackColor = true;
            this.btnTraSach.Click += new System.EventHandler(this.btnTraSach_Click);
            // 
            // TraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 244);
            this.Controls.Add(this.btnTraSach);
            this.Controls.Add(this.btnCheckMaDocGia);
            this.Controls.Add(this.txtMaDocGia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCheckIdSach);
            this.Controls.Add(this.btnCheckISBN);
            this.Controls.Add(this.txtMaSach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TraSach";
            this.Text = "Trả sách";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Button btnCheckISBN;
        private System.Windows.Forms.Button btnCheckIdSach;
        private System.Windows.Forms.Button btnCheckMaDocGia;
        private System.Windows.Forms.TextBox txtMaDocGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTraSach;
    }
}