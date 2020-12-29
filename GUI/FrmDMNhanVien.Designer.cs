
namespace GUI
{
    partial class FrmDMNhanVien
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.txtEmployeeBirthday = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmployeeFullName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbRoles = new System.Windows.Forms.ComboBox();
            this.txtEmployeeTel = new System.Windows.Forms.TextBox();
            this.txtEmployeeEmail = new System.Windows.Forms.TextBox();
            this.txtEmployeeAddress = new System.Windows.Forms.TextBox();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnGetID = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.rdGenderFemale = new System.Windows.Forms.RadioButton();
            this.rdGenderMale = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.rdGenderFemale);
            this.groupBox1.Controls.Add(this.rdGenderMale);
            this.groupBox1.Controls.Add(this.txtEmployeeBirthday);
            this.groupBox1.Controls.Add(this.cbbRoles);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtEmployeeId);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtEmployeeFullName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(22, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(686, 120);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã nhân viên";
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.txtEmployeeId.Location = new System.Drawing.Point(109, 13);
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.Size = new System.Drawing.Size(209, 23);
            this.txtEmployeeId.TabIndex = 3;
            // 
            // txtEmployeeBirthday
            // 
            this.txtEmployeeBirthday.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.txtEmployeeBirthday.Location = new System.Drawing.Point(109, 81);
            this.txtEmployeeBirthday.Mask = "00/00/0000";
            this.txtEmployeeBirthday.Name = "txtEmployeeBirthday";
            this.txtEmployeeBirthday.Size = new System.Drawing.Size(209, 23);
            this.txtEmployeeBirthday.TabIndex = 10;
            this.txtEmployeeBirthday.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Họ tên";
            // 
            // txtEmployeeFullName
            // 
            this.txtEmployeeFullName.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.txtEmployeeFullName.Location = new System.Drawing.Point(109, 47);
            this.txtEmployeeFullName.Name = "txtEmployeeFullName";
            this.txtEmployeeFullName.Size = new System.Drawing.Size(560, 23);
            this.txtEmployeeFullName.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtEmployeeTel);
            this.groupBox3.Controls.Add(this.txtEmployeeEmail);
            this.groupBox3.Controls.Add(this.txtEmployeeAddress);
            this.groupBox3.Location = new System.Drawing.Point(22, 200);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(686, 120);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(347, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Quyền";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Số điện thoại";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Địa chỉ";
            // 
            // cbbRoles
            // 
            this.cbbRoles.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.cbbRoles.FormattingEnabled = true;
            this.cbbRoles.Location = new System.Drawing.Point(450, 13);
            this.cbbRoles.Name = "cbbRoles";
            this.cbbRoles.Size = new System.Drawing.Size(219, 25);
            this.cbbRoles.TabIndex = 7;
            // 
            // txtEmployeeTel
            // 
            this.txtEmployeeTel.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.txtEmployeeTel.Location = new System.Drawing.Point(109, 81);
            this.txtEmployeeTel.Name = "txtEmployeeTel";
            this.txtEmployeeTel.Size = new System.Drawing.Size(560, 23);
            this.txtEmployeeTel.TabIndex = 5;
            // 
            // txtEmployeeEmail
            // 
            this.txtEmployeeEmail.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.txtEmployeeEmail.Location = new System.Drawing.Point(109, 47);
            this.txtEmployeeEmail.Name = "txtEmployeeEmail";
            this.txtEmployeeEmail.Size = new System.Drawing.Size(560, 23);
            this.txtEmployeeEmail.TabIndex = 4;
            // 
            // txtEmployeeAddress
            // 
            this.txtEmployeeAddress.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.txtEmployeeAddress.Location = new System.Drawing.Point(109, 13);
            this.txtEmployeeAddress.Name = "txtEmployeeAddress";
            this.txtEmployeeAddress.Size = new System.Drawing.Size(560, 23);
            this.txtEmployeeAddress.TabIndex = 3;
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(22, 326);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.Size = new System.Drawing.Size(823, 252);
            this.dgvEmployee.TabIndex = 5;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnClear);
            this.groupBox4.Controls.Add(this.btnLoad);
            this.groupBox4.Controls.Add(this.btnGetID);
            this.groupBox4.Controls.Add(this.btnDelete);
            this.groupBox4.Controls.Add(this.btnUpdate);
            this.groupBox4.Controls.Add(this.btnInsert);
            this.groupBox4.Location = new System.Drawing.Point(725, 71);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(120, 245);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(12, 210);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Làm lại";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.FlatAppearance.BorderSize = 0;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Location = new System.Drawing.Point(12, 176);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(97, 23);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Đổ dữ liệu";
            this.btnLoad.UseVisualStyleBackColor = false;
            // 
            // btnGetID
            // 
            this.btnGetID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnGetID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetID.FlatAppearance.BorderSize = 0;
            this.btnGetID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetID.ForeColor = System.Drawing.Color.White;
            this.btnGetID.Location = new System.Drawing.Point(12, 142);
            this.btnGetID.Name = "btnGetID";
            this.btnGetID.Size = new System.Drawing.Size(97, 23);
            this.btnGetID.TabIndex = 3;
            this.btnGetID.Text = "Mã mới";
            this.btnGetID.UseVisualStyleBackColor = false;
            this.btnGetID.Click += new System.EventHandler(this.btnGetID_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(12, 86);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(12, 47);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(97, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(12, 11);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(97, 23);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(357, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Giới tính";
            // 
            // rdGenderFemale
            // 
            this.rdGenderFemale.AutoSize = true;
            this.rdGenderFemale.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.rdGenderFemale.Location = new System.Drawing.Point(525, 82);
            this.rdGenderFemale.Name = "rdGenderFemale";
            this.rdGenderFemale.Size = new System.Drawing.Size(43, 21);
            this.rdGenderFemale.TabIndex = 12;
            this.rdGenderFemale.Text = "Nữ";
            this.rdGenderFemale.UseVisualStyleBackColor = true;
            // 
            // rdGenderMale
            // 
            this.rdGenderMale.AutoSize = true;
            this.rdGenderMale.Checked = true;
            this.rdGenderMale.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.rdGenderMale.Location = new System.Drawing.Point(450, 83);
            this.rdGenderMale.Name = "rdGenderMale";
            this.rdGenderMale.Size = new System.Drawing.Size(53, 21);
            this.rdGenderMale.TabIndex = 11;
            this.rdGenderMale.TabStop = true;
            this.rdGenderMale.Text = "Nam";
            this.rdGenderMale.UseVisualStyleBackColor = true;
            // 
            // FrmDMNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 590);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDMNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.FrmDMNhanVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.TextBox txtEmployeeFullName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtEmployeeTel;
        private System.Windows.Forms.TextBox txtEmployeeEmail;
        private System.Windows.Forms.TextBox txtEmployeeAddress;
        private System.Windows.Forms.ComboBox cbbRoles;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnGetID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.MaskedTextBox txtEmployeeBirthday;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdGenderFemale;
        private System.Windows.Forms.RadioButton rdGenderMale;
    }
}