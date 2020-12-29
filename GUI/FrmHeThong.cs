using GUI.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    public partial class FrmHeThong : Form
    {

        LoadMenu loadMenu = new LoadMenu();

        BUS_DBConnect dbConnect = new BUS_DBConnect();

        public FrmHeThong()
        {
            new FormSplashScreen().ShowDialog();
            InitializeComponent();
        }

        private void FrmHeThong_Load(object sender, EventArgs e)
        {
            loadMenu.Load(false);
            openForm(new FrmLogin());
        }

        #region method

        private void clearForm()
        {
            foreach (Form frm in Application.OpenForms.Cast<Form>().Where(f => f.IsMdiChild).ToArray())
            {
                frm.Close();
            }
        }

        private void openForm(Form form)
        {
            clearForm();

            form.MdiParent = this;
            form.Show();
        }

        #endregion

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc muốn đóng ứng dụng không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }

        private void miHuyKetNoi_Click(object sender, EventArgs e)
        {
            if (dbConnect.DBDisconnect())
            {
                clearForm();
                MessageBox.Show("Đã hủy kết nối", "Thông báo");
                loadMenu.Load(false);
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openForm(new FrmDMNhanVien());
        }

        private void miDangNhap_Click(object sender, EventArgs e)
        {
            openForm(new FrmLogin());
        }
    }
}
