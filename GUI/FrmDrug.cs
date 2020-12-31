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
using BUS;
using DTO;
using System.Data.SqlClient;
using GUI.Class;

namespace GUI
{
    public partial class FrmDrug : MaterialForm
    {
        BUS_GetData getData = new BUS_GetData();
        BUS_Drug busDrug = new BUS_Drug();

        public FrmDrug()
        {
            InitializeComponent();
        }

        #region
        private void loadDrugs()
        {
            dgvDrug.DataSource = getData.getDataTable("SELECT * FROM DRUGS");
        }

        private void loadCategorys()
        {
            cbbCategory.DataSource = getData.getDataTable("SELECT * FROM CATEGORYS");
            cbbCategory.DisplayMember = "Category_Name";
            cbbCategory.ValueMember = "Category_Id";
        }

        private void loadDrugId()
        {
            SqlDataReader sqlDataReader = getData.getDataStoredProcedure("pr_CreateDrugId");
            if (sqlDataReader.Read())
            {
                txtId.Text = sqlDataReader.GetString(0).ToString();
                sqlDataReader.Close();
            }
        }

        private String getDrugId()
        {
            String result = "";
            SqlDataReader sqlDataReader = getData.getDataStoredProcedure("pr_CreateDrugId");
            if (sqlDataReader.Read())
            {
                result = sqlDataReader.GetString(0).ToString();
                sqlDataReader.Close();
            }
            return result;
        }

        private void clear()
        {
            txtId.Text = getDrugId();
            txtName.Text = txtPrice.Text = txtQuantity.Text = txtUnit.Text = "";
            txtName.Focus();
        }
        #endregion

        private void FrmDrug_Load(object sender, EventArgs e)
        {
            loadDrugs();
            loadCategorys();
            loadDrugId();

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            bool valid = true;
            valid = CustomValidate.Instance.Compare(getDrugId(), txtId, lblId) == false ? false : valid;
            valid = CustomValidate.Instance.Required(txtName, lblName) == false ? false : valid;
            valid = CustomValidate.Instance.Required(txtUnit, lblUnit) == false ? false : valid;
            valid = CustomValidate.Instance.IsQuantity(txtQuantity, lblQuantity) == false ? false : valid;
            valid = CustomValidate.Instance.IsPrice(txtPrice, lblPrice) == false ? false : valid;

            if (valid)
            {
                String id = txtId.Text.Trim();
                String name = txtName.Text.Trim();
                double price = double.Parse(txtPrice.Text.Trim());
                int quantity = int.Parse(txtQuantity.Text.Trim());
                DateTime mfd = DateTime.Parse(dpMFD.Text);
                DateTime exp = DateTime.Parse(dpEXP.Text);
                int category = (int) cbbCategory.SelectedValue;
                String dvt = txtUnit.Text.Trim();
                busDrug.InsertDrug(new DTO_Drug(id, name, price, quantity, mfd, exp, category, dvt));

                loadDrugs();
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra dữ liệu", "Thông báo");
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnGetID_Click(object sender, EventArgs e)
        {
            loadDrugId();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool valid = true;
            valid = CustomValidate.Instance.Required(txtId, lblId) == false ? false : valid;
            valid = CustomValidate.Instance.Required(txtName, lblName) == false ? false : valid;
            valid = CustomValidate.Instance.Required(txtUnit, lblUnit) == false ? false : valid;
            valid = CustomValidate.Instance.IsQuantity(txtQuantity, lblQuantity) == false ? false : valid;
            valid = CustomValidate.Instance.IsPrice(txtPrice, lblPrice) == false ? false : valid;

            if (valid)
            {
                String id = txtId.Text.Trim();
                String name = txtName.Text.Trim();
                double price = double.Parse(txtPrice.Text.Trim());
                int quantity = int.Parse(txtQuantity.Text.Trim());
                DateTime mfd = DateTime.Parse(dpMFD.Text);
                DateTime exp = DateTime.Parse(dpEXP.Text);
                int category = (int)cbbCategory.SelectedValue;
                String dvt = txtUnit.Text.Trim();
                busDrug.UpdateDrug(new DTO_Drug(id, name, price, quantity, mfd, exp, category, dvt));

                loadDrugs();
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra dữ liệu", "Thông báo");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (dgvDrug.CurrentRow.Selected)
            {
                DataGridViewRow row = dgvDrug.Rows[dgvDrug.CurrentRow.Index];
                txtId.Text = row.Cells["Drug_Id"].Value.ToString();
                txtName.Text = row.Cells["Drug_Name"].Value.ToString();
                txtPrice.Text = row.Cells["Drug_Price"].Value.ToString();
                txtQuantity.Text = row.Cells["Drug_QOS"].Value.ToString();
                txtUnit.Text = row.Cells["DVT"].Value.ToString();
                cbbCategory.SelectedValue = row.Cells["Category_Id"].Value.ToString();
                dpEXP.Text = row.Cells["Drug_EXP"].Value.ToString();
                dpMFD.Text = row.Cells["Drug_MFD"].Value.ToString();
            }
            else MessageBox.Show("Vui lòng chọn dòng để đổ dữ liệu", "Thông báo");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool valid = true;
            valid = CustomValidate.Instance.Required(txtId, lblId) == false ? false : valid;

            if (valid)
            {
                if(MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    String id = txtId.Text.Trim();
                    busDrug.DeleteDrug(new DTO_Drug(id));
                    loadDrugs();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra dữ liệu", "Thông báo");
            }
        }
    }
}
