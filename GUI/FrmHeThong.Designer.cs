
namespace GUI
{
    partial class FrmHeThong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHeThong));
            this.panelMove = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.miHuyKetNoi = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.lưuTrữPhụcHồiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mặtHàngToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loạiHàngToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mTraCuu = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mặtHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loạiHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMove
            // 
            this.panelMove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.panelMove.Controls.Add(this.pictureBox2);
            this.panelMove.Controls.Add(this.pictureBox1);
            this.panelMove.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMove.Location = new System.Drawing.Point(0, 0);
            this.panelMove.Name = "panelMove";
            this.panelMove.Size = new System.Drawing.Size(800, 20);
            this.panelMove.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = global::GUI.Properties.Resources._2931142_16;
            this.pictureBox2.Location = new System.Drawing.Point(740, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::GUI.Properties.Resources._296812_16;
            this.pictureBox1.Location = new System.Drawing.Point(770, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 20);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(800, 40);
            this.label1.TabIndex = 7;
            this.label1.Text = "QUẢN LÝ NHÀ THUỐC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.mDanhMuc,
            this.mHoaDon,
            this.mTraCuu,
            this.mBaoCao,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miDangNhap,
            this.toolStripSeparator4,
            this.miHuyKetNoi,
            this.toolStripSeparator5,
            this.lưuTrữPhụcHồiToolStripMenuItem,
            this.toolStripSeparator6,
            this.thoátToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // miDangNhap
            // 
            this.miDangNhap.Name = "miDangNhap";
            this.miDangNhap.Size = new System.Drawing.Size(175, 22);
            this.miDangNhap.Text = "Đăng nhập";
            this.miDangNhap.Click += new System.EventHandler(this.miDangNhap_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(172, 6);
            // 
            // miHuyKetNoi
            // 
            this.miHuyKetNoi.Name = "miHuyKetNoi";
            this.miHuyKetNoi.Size = new System.Drawing.Size(175, 22);
            this.miHuyKetNoi.Text = "Hủy kết nối";
            this.miHuyKetNoi.Click += new System.EventHandler(this.miHuyKetNoi_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(172, 6);
            // 
            // lưuTrữPhụcHồiToolStripMenuItem
            // 
            this.lưuTrữPhụcHồiToolStripMenuItem.Name = "lưuTrữPhụcHồiToolStripMenuItem";
            this.lưuTrữPhụcHồiToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.lưuTrữPhụcHồiToolStripMenuItem.Text = "Lưu trữ && phục hồi";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(172, 6);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // mDanhMuc
            // 
            this.mDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mặtHàngToolStripMenuItem1,
            this.loạiHàngToolStripMenuItem1,
            this.nhânViênToolStripMenuItem1});
            this.mDanhMuc.Name = "mDanhMuc";
            this.mDanhMuc.Size = new System.Drawing.Size(74, 20);
            this.mDanhMuc.Text = "Danh Mục";
            // 
            // mặtHàngToolStripMenuItem1
            // 
            this.mặtHàngToolStripMenuItem1.Name = "mặtHàngToolStripMenuItem1";
            this.mặtHàngToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.mặtHàngToolStripMenuItem1.Text = "Mặt hàng";
            this.mặtHàngToolStripMenuItem1.Click += new System.EventHandler(this.mặtHàngToolStripMenuItem1_Click);
            // 
            // loạiHàngToolStripMenuItem1
            // 
            this.loạiHàngToolStripMenuItem1.Name = "loạiHàngToolStripMenuItem1";
            this.loạiHàngToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.loạiHàngToolStripMenuItem1.Text = "Loại hàng";
            this.loạiHàngToolStripMenuItem1.Click += new System.EventHandler(this.loạiHàngToolStripMenuItem1_Click);
            // 
            // nhânViênToolStripMenuItem1
            // 
            this.nhânViênToolStripMenuItem1.Name = "nhânViênToolStripMenuItem1";
            this.nhânViênToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.nhânViênToolStripMenuItem1.Text = "Nhân viên";
            this.nhânViênToolStripMenuItem1.Click += new System.EventHandler(this.nhânViênToolStripMenuItem1_Click);
            // 
            // mHoaDon
            // 
            this.mHoaDon.Name = "mHoaDon";
            this.mHoaDon.Size = new System.Drawing.Size(66, 20);
            this.mHoaDon.Text = "Hóa Đơn";
            // 
            // mTraCuu
            // 
            this.mTraCuu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhânViênToolStripMenuItem,
            this.mặtHàngToolStripMenuItem,
            this.loạiHàngToolStripMenuItem,
            this.hóaĐơnToolStripMenuItem1});
            this.mTraCuu.Name = "mTraCuu";
            this.mTraCuu.Size = new System.Drawing.Size(59, 20);
            this.mTraCuu.Text = "Tra Cứu";
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.nhânViênToolStripMenuItem.Text = "Nhân viên";
            // 
            // mặtHàngToolStripMenuItem
            // 
            this.mặtHàngToolStripMenuItem.Name = "mặtHàngToolStripMenuItem";
            this.mặtHàngToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.mặtHàngToolStripMenuItem.Text = "Mặt hàng";
            // 
            // loạiHàngToolStripMenuItem
            // 
            this.loạiHàngToolStripMenuItem.Name = "loạiHàngToolStripMenuItem";
            this.loạiHàngToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.loạiHàngToolStripMenuItem.Text = "Loại hàng";
            // 
            // hóaĐơnToolStripMenuItem1
            // 
            this.hóaĐơnToolStripMenuItem1.Name = "hóaĐơnToolStripMenuItem1";
            this.hóaĐơnToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.hóaĐơnToolStripMenuItem1.Text = "Hóa đơn";
            // 
            // mBaoCao
            // 
            this.mBaoCao.Name = "mBaoCao";
            this.mBaoCao.Size = new System.Drawing.Size(63, 20);
            this.mBaoCao.Text = "Báo Cáo";
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.trợGiúpToolStripMenuItem.Text = "Trợ Giúp";
            // 
            // FrmHeThong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelMove);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MinimizeBox = false;
            this.Name = "FrmHeThong";
            this.Text = "FrmHeThong";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmHeThong_Load);
            this.panelMove.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMove;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem miDangNhap;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        public System.Windows.Forms.ToolStripMenuItem miHuyKetNoi;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem lưuTrữPhụcHồiToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem mDanhMuc;
        public System.Windows.Forms.ToolStripMenuItem mHoaDon;
        public System.Windows.Forms.ToolStripMenuItem mTraCuu;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mặtHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loạiHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem mBaoCao;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mặtHàngToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loạiHàngToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem1;
    }
}