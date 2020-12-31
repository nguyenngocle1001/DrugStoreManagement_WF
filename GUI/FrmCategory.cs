using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Forms;
using DTO;
using BUS;
using GUI.Class;

namespace GUI
{
    public partial class FrmCategory : MaterialForm
    {
        BUS_Category busCategory = new BUS_Category();
        BUS_GetData getData = new BUS_GetData();

        public FrmCategory()
        {
            InitializeComponent();
        }

        #region methods

        private void clear()
        {
            txtId.Text = txtName.Text = "";
            txtId.Focus();
        }

        private void loadCategory()
        {
            dgvCategory.DataSource = getData.getDataTable("SELECT * FROM CATEGORYS");
        }

        #endregion

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool valid = true;
            valid = CustomValidate.Instance.IsInteger(txtId, lblId) == false ? false : valid;
            if (valid)
            {
                if(MessageBox.Show("Bạn có chắc muốn xóa không", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    DTO_Category category = new DTO_Category(int.Parse(txtId.Text.Trim()));
                    busCategory.DeleteCategory(category);
                    loadCategory();
                    clear();
                }
               
            }
            else
            {
                MessageBox.Show("Vui lòng điền thông tin", "Thông báo");
                txtId.Focus();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool valid = true;
            valid = CustomValidate.Instance.IsInteger(txtId, lblId) == false ? false : valid;
            valid = CustomValidate.Instance.Required(txtName, lblName) == false ? false : valid;
            if (valid)
            {
                DTO_Category category = new DTO_Category(int.Parse(txtId.Text.Trim()), txtName.Text.Trim());
                busCategory.UpdateCategory(category);
                loadCategory();
                clear();
            }
            else
            {
                MessageBox.Show("Vui lòng điền thông tin", "Thông báo");
                txtId.Focus();
            }
           
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            bool valid = true;
            valid = CustomValidate.Instance.Required(txtName, lblName) == false ? false : valid;

            if (valid)
            {
                DTO_Category category = new DTO_Category(txtName.Text.Trim());
                busCategory.InsertCategory(category);
                clear();
                loadCategory();
            }
            else
            {
                MessageBox.Show("Vui lòng điền thông tin", "Thông báo");
                txtName.Focus();
            }
        }

        private void FrmCategory_Load(object sender, EventArgs e)
        {
            loadCategory();
        }
    }
}
