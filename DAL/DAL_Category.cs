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
    public class DAL_Category
    {
        public DAL_Category() { }

        public void InsertCategory(DTO_Category category)
        {
            try
            {
                SqlCommand command = new SqlCommand("pr_InsertCategory", DAL_DBConnect.connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("@Category_Name", System.Data.SqlDbType.NVarChar, 15).Value = category.Name;
                command.ExecuteNonQuery();
                command.Parameters.Clear();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString(), "Notice");
            }
        }

        public void UpdateCategory(DTO_Category category)
        {
            try
            {
                SqlCommand command = new SqlCommand("pr_UpdateCategory", DAL_DBConnect.connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("@Category_Id", System.Data.SqlDbType.Int).Value = Convert.ToInt16(category.Id);
                command.Parameters.Add("@Category_Name", System.Data.SqlDbType.NVarChar, 15).Value = category.Name;
                command.ExecuteNonQuery();
                command.Parameters.Clear();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString(), "Notice");
            }
        }

        public void DeleteCategory(DTO_Category category)
        {
            try
            {
                SqlCommand command = new SqlCommand("pr_DeleteCategory", DAL_DBConnect.connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("@Category_Id", System.Data.SqlDbType.Int).Value = Convert.ToInt16(category.Id);
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
