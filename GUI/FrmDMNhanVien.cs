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
using System.Data.SqlClient;
using GUI.Class;

namespace GUI
{
    public partial class FrmDMNhanVien : MaterialForm
    {
        BUS_GetData getData = new BUS_GetData();
        BUS_Employee busEmployee = new BUS_Employee();
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

        private void insertAction()
        {
            string idnext = "";
            SqlDataReader sqlDataReader = getData.getDataStoredProcedure("pr_createemployeeid");
            if (sqlDataReader.Read())
            {
                idnext = sqlDataReader.GetString(0).ToString();
                sqlDataReader.Close();
            }

            bool valid = true;
            valid = Validate(txtEmployeeId, lblId) == false ? false : valid;
            valid = Validate(idnext, txtEmployeeId, lblId) == false ? false : valid;
            valid = Validate(txtEmployeeFullName, lblName) == false ? false : valid;
            valid = Validate(txtEmployeeAddress, lblAddress) == false ? false : valid;
            valid = Validate(txtEmployeeEmail, lblEmail) == false ? false : valid;
            valid = Validate(txtEmployeeTel, lblTel) == false ? false : valid;

            if (valid)
            {
                string id = txtEmployeeId.Text.Trim();
                string name = txtEmployeeFullName.Text.Trim();
                DateTime birthday = DateTime.Parse(dpBirthday.Text);
                bool gender = rdGenderMale.Checked;
                string address = txtEmployeeAddress.Text.Trim();
                string email = txtEmployeeEmail.Text.Trim();
                string tel = txtEmployeeTel.Text.Trim();
                int role = int.Parse(cbbRoles.SelectedValue.ToString());

                DTO_Employee dtoEmployee = new DTO_Employee(id, name, birthday, gender, address, email, tel, role);
                busEmployee.InsertEmployee(dtoEmployee);
                loadEmployees();
            }
            else MessageBox.Show("vui lòng kiểm tra lại các ô dữ liệu tô màu đỏ");
        }

        private void updateAction()
        {
            bool valid = true;
            valid = Validate(txtEmployeeId, lblId) == false ? false : valid;
            valid = Validate(txtEmployeeId, lblId) == false ? false : valid;
            valid = Validate(txtEmployeeFullName, lblName) == false ? false : valid;
            valid = Validate(txtEmployeeAddress, lblAddress) == false ? false : valid;
            valid = Validate(txtEmployeeEmail, lblEmail) == false ? false : valid;
            valid = Validate(txtEmployeeTel, lblTel) == false ? false : valid;

            if (valid)
            {
                string id = txtEmployeeId.Text.Trim();
                string name = txtEmployeeFullName.Text.Trim();
                DateTime birthday = DateTime.Parse(dpBirthday.Text);
                bool gender = rdGenderMale.Checked;
                string address = txtEmployeeAddress.Text.Trim();
                string email = txtEmployeeEmail.Text.Trim();
                string tel = txtEmployeeTel.Text.Trim();
                int role = int.Parse(cbbRoles.SelectedValue.ToString());

                DTO_Employee dtoEmployee = new DTO_Employee(id, name, birthday, gender, address, email, tel, role);
                busEmployee.UpdateEmployee(dtoEmployee);
                loadEmployees();
            }
            else MessageBox.Show("vui lòng kiểm tra lại các ô dữ liệu tô màu đỏ");
        }


        private bool Validate(TextBox txt, Label lbl)
        {
            if (txt.Text.Trim() == "")
            {
                lbl.ForeColor = Color.Red;
                return false;
            }
            else lbl.ForeColor = Color.Black;
            return true;
        }

        private bool Validate(MaskedTextBox txt, Label lbl)
        {
            DateTime result;
            try
            {
                result = DateTime.Parse(txt.Text);
                lbl.ForeColor = Color.Black;
                return true;
            }
            catch (Exception e)
            {
                lbl.ForeColor = Color.Red;
                return false;
            }
        }

        private bool Validate(String value, TextBox txt, Label lbl)
        {
            if (txt.Text.Trim() != value)
            {
                MessageBox.Show("Mã nhân viên phải là: " + value + " mới có thể thêm mới!");
                txt.Text = value;
                lbl.ForeColor = Color.Red;
                return false;
            }
            else lbl.ForeColor = Color.Black;
            return true;
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
            loadCbbRole();
            loadEmployeeId();
            loadEmployees();

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            insertAction();
        }

        private void btnGetID_Click(object sender, EventArgs e)
        {
            loadEmployeeId();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.CurrentRow.Selected)
            {
                DataGridViewRow row = dgvEmployee.Rows[dgvEmployee.CurrentRow.Index];
                txtEmployeeId.Text = row.Cells["Employee_Id"].Value.ToString();
                txtEmployeeFullName.Text = row.Cells["Employee_FullName"].Value.ToString();
                dpBirthday.Text = row.Cells["Employee_Birthday"].Value.ToString();
                if ((bool)row.Cells["Employee_Gender"].Value)
                {
                    rdGenderMale.Checked = true;
                }
                else rdGenderFemale.Checked = true;
                cbbRoles.SelectedValue = row.Cells["Role_Id"].Value;
                txtEmployeeAddress.Text = row.Cells["Employee_Address"].Value.ToString();
                txtEmployeeEmail.Text = row.Cells["Employee_Email"].Value.ToString();
                txtEmployeeTel.Text = row.Cells["Employee_Tel"].Value.ToString();

            }
            else MessageBox.Show("Vui lòng chọn dòng để đổ dữ liệu", "Thông báo");

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateAction();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            loadEmployeeId();
            txtEmployeeFullName.Text = txtEmployeeAddress.Text = txtEmployeeEmail.Text 
                = txtEmployeeTel.Text = "";
            txtEmployeeId.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            bool valid = true;
            valid = CustomValidate.Instance.Required(txtEmployeeId, lblId) == false ? false : valid;
            if (valid)
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    DTO_Employee employee = new DTO_Employee(txtEmployeeId.Text.Trim());
                    busEmployee.DeleteEmployee(employee);
                    loadEmployees();
                }
            }
            else MessageBox.Show("Vui lòng xem lại dữ liệu", "Thông báo");
           
            
        }
    }
}
