using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using DTO;
using BUS;
using System.Data.SqlClient;

namespace GUI
{
    public partial class FrmDMNhanVien : MaterialForm
    {
        BUS_GetData getData = new BUS_GetData();
        public FrmDMNhanVien()
        {
            InitializeComponent();
        }

        #region methods

        private void loadEmployeeId()
        {
            SqlDataReader sqlDataReader = getData.getDataStoredProcedure("pr_CreateEmployeeId");
            if (sqlDataReader.Read())
            {
                txtEmployeeId.Text = sqlDataReader.GetString(0).ToString();
                sqlDataReader.Close();
            }
        }

        private void loadEmployees()
        {
            dgvEmployee.DataSource = getData.getDataTable("SELECT Employee_Id, Employee_FullName, Employee_Birthday, " +
                "Employee_Gender, Employee_Address, Employee_Email, Employee_Tel, Role_Name, e.Role_Id FROM Employees e, " +
                "Roles r WHERE e.Role_Id = r.Role_Id");
        }

        private void loadCbbRole()
        {
            cbbRoles.DataSource = getData.getDataTable("SELECT * FROM ROLES");
            cbbRoles.DisplayMember = "Role_Name";
            cbbRoles.ValueMember = "Role_Id";
        }

        #endregion


        private void FrmDMNhanVien_Load(object sender, EventArgs e)
        {
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );

            //Đổ dữ liệu lên combobox roles

            loadEmployees();
            loadEmployeeId();
            loadCbbRole();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnGetID_Click(object sender, EventArgs e)
        {
           
        }
    }
}
