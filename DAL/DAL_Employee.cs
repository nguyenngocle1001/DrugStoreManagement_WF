using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace DAL
{
    public class DAL_Employee
    {
        public DAL_Employee() { }

        public void InsertEmployee(DTO_Employee employee)
        {
            try
            {
                SqlCommand command = new SqlCommand("pr_InsertEmployee", DAL_DBConnect.connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("@Employee_Id", System.Data.SqlDbType.Char, 13).Value = employee.Id;
                command.Parameters.Add("@Employee_FullName", System.Data.SqlDbType.NVarChar, 50).Value = employee.Name;
                command.Parameters.Add("@Employee_Birthday", System.Data.SqlDbType.DateTime).Value = employee.Birthday;
                command.Parameters.Add("@Employee_Gender", System.Data.SqlDbType.Bit).Value = employee.Gender;
                command.Parameters.Add("@Employee_Address", System.Data.SqlDbType.NVarChar, 250).Value = employee.Address;
                command.Parameters.Add("@Employee_Email", System.Data.SqlDbType.NVarChar, 100).Value = employee.Email;
                command.Parameters.Add("@Employee_Tel", System.Data.SqlDbType.NVarChar, 10).Value = employee.Tel;
                command.Parameters.Add("@Role_Id", System.Data.SqlDbType.Int).Value = employee.Role;
                command.ExecuteNonQuery();
                command.Parameters.Clear();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString(), "Notice");
            }
        }

        public void UpdateEmployee(DTO_Employee employee)
        {
            try
            {
                SqlCommand command = new SqlCommand("pr_UpdateEmployee", DAL_DBConnect.connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("@Employee_Id", System.Data.SqlDbType.Char, 13).Value = employee.Id;
                command.Parameters.Add("@Employee_FullName", System.Data.SqlDbType.NVarChar, 50).Value = employee.Name;
                command.Parameters.Add("@Employee_Birthday", System.Data.SqlDbType.DateTime).Value = employee.Birthday;
                command.Parameters.Add("@Employee_Gender", System.Data.SqlDbType.Bit).Value = employee.Gender;
                command.Parameters.Add("@Employee_Address", System.Data.SqlDbType.NVarChar, 250).Value = employee.Address;
                command.Parameters.Add("@Employee_Email", System.Data.SqlDbType.NVarChar, 100).Value = employee.Email;
                command.Parameters.Add("@Employee_Tel", System.Data.SqlDbType.NVarChar, 10).Value = employee.Tel;
                command.Parameters.Add("@Role_Id", System.Data.SqlDbType.Int).Value = employee.Role;
                command.ExecuteNonQuery();
                command.Parameters.Clear();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString(), "Notice");
            }
        }

        public void DeleteEmployee(DTO_Employee employee)
        {
            try
            {
                SqlCommand command = new SqlCommand("pr_DeleteEmployee", DAL_DBConnect.connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("@Employee_Id", System.Data.SqlDbType.Char, 13).Value = employee.Id;
                command.ExecuteNonQuery();
                command.Parameters.Clear();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString(), "Notice");
            }
        }
    }
}
