using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using DTO;
using BUS;
using GUI.Class;

namespace GUI
{
    public partial class FrmLogin : MaterialForm
    {
        BUS_DBConnect dbConnect = new BUS_DBConnect();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );

            txtSeverName.Text = "DESKTOP-K8R02R2\\SQLEXPRESS";
            txtDatabase.Text = "DRUGSTOREMANAGEMENT_WF";
            txtUserId.Text = "sa";
            txtPasswordDB.Text = "10012000";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String severName = txtSeverName.Text.Trim();
            String database = txtDatabase.Text.Trim();
            String userId = txtUserId.Text.Trim();
            String passwordDB = txtPasswordDB.Text.Trim();

            DTO_DBConnect dtoDBConenct = new DTO_DBConnect(severName, database, userId, passwordDB);

           if (dbConnect.DBConnect(dtoDBConenct))
            {
                MessageBox.Show("Login thành công", "Thông báo");
                LoadMenu loadMenu = new LoadMenu();
                loadMenu.Load(true);
                this.Close();
            }

        }
    }
}
