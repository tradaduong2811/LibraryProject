namespace Library
{
    partial class Form1
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
            this.quảnLýSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýĐọcGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.backUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // quảnLýSáchToolStripMenuItem
            // 
            this.quảnLýSáchToolStripMenuItem.Name = "quảnLýSáchToolStripMenuItem";
            this.quảnLýSáchToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.quảnLýSáchToolStripMenuItem.Text = "Quản lý Sách";
            this.quảnLýSáchToolStripMenuItem.Click += new System.EventHandler(this.quảnLýSáchToolStripMenuItem_Click);
            // 
            // quảnLýĐọcGiảToolStripMenuItem
            // 
            this.quảnLýĐọcGiảToolStripMenuItem.Name = "quảnLýĐọcGiảToolStripMenuItem";
            this.quảnLýĐọcGiảToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.quảnLýĐọcGiảToolStripMenuItem.Text = "Quản lý Đọc giả";
            this.quảnLýĐọcGiảToolStripMenuItem.Click += new System.EventHandler(this.quảnLýĐọcGiảToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýSáchToolStripMenuItem,
            this.quảnLýĐọcGiảToolStripMenuItem,
            this.backUpToolStripMenuItem,
            this.restoreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(827, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(764, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "ĐỒ ÁN CUỐI KÌ HỆ QUẢN TRỊ CƠ SỞ DỮ LIỆU ";
            // 
            // backUpToolStripMenuItem
            // 
            this.backUpToolStripMenuItem.Name = "backUpToolStripMenuItem";
            this.backUpToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.backUpToolStripMenuItem.Text = "Back up";
            this.backUpToolStripMenuItem.Click += new System.EventHandler(this.backUpToolStripMenuItem_Click);
            // 
            // restoreToolStripMenuItem
            // 
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            this.restoreToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.restoreToolStripMenuItem.Text = "Restore";
            this.restoreToolStripMenuItem.Click += new System.EventHandler(this.restoreToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 529);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Phần mềm quản lý thư viện";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem quảnLýSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýĐọcGiảToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem backUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;


    }
}

