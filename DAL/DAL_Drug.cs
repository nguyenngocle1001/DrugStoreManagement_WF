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
    public class DAL_Drug
    {
        public DAL_Drug() { }

        public void InsertDrug(DTO_Drug drug)
        {
            try
            {
                SqlCommand command = new SqlCommand("pr_InsertDrug", DAL_DBConnect.connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("@Drug_Id", System.Data.SqlDbType.Char, 13).Value = drug.Id;
                command.Parameters.Add("@Drug_Name", System.Data.SqlDbType.NVarChar, 250).Value = drug.Name;
                command.Parameters.Add("@Drug_Price", System.Data.SqlDbType.Money).Value = drug.Price;
                command.Parameters.Add("@Drug_QOS", System.Data.SqlDbType.Int).Value = drug.Quantity;
                command.Parameters.Add("@Drug_MFD", System.Data.SqlDbType.DateTime).Value = drug.Mfd;
                command.Parameters.Add("@Drug_EXP", System.Data.SqlDbType.DateTime).Value = drug.Exp;
                command.Parameters.Add("@Category_Id", System.Data.SqlDbType.Int).Value = drug.Category;
                command.Parameters.Add("@DVT", System.Data.SqlDbType.NVarChar, 15).Value = drug.Dvt;
                command.ExecuteNonQuery();
                command.Parameters.Clear();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString(), "Notice");
            }

        }

        public void UpdateDrug(DTO_Drug drug)
        {
            try
            {
                SqlCommand command = new SqlCommand("pr_UpdateDrug", DAL_DBConnect.connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("@Drug_Id", System.Data.SqlDbType.Char, 13).Value = drug.Id;
                command.Parameters.Add("@Drug_Name", System.Data.SqlDbType.NVarChar, 250).Value = drug.Name;
                command.Parameters.Add("@Drug_Price", System.Data.SqlDbType.Money).Value = drug.Price;
                command.Parameters.Add("@Drug_QOS", System.Data.SqlDbType.Int).Value = drug.Quantity;
                command.Parameters.Add("@Drug_MFD", System.Data.SqlDbType.DateTime).Value = drug.Mfd;
                command.Parameters.Add("@Drug_EXP", System.Data.SqlDbType.DateTime).Value = drug.Exp;
                command.Parameters.Add("@Category_Id", System.Data.SqlDbType.Int).Value = drug.Category;
                command.Parameters.Add("@DVT", System.Data.SqlDbType.NVarChar, 15).Value = drug.Dvt;
                command.ExecuteNonQuery();
                command.Parameters.Clear();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString(), "Notice");
            }
        }

        public void DeleteDrug(DTO_Drug drug)
        {
            try
            {
                SqlCommand command = new SqlCommand("pr_DeleteDrug", DAL_DBConnect.connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("@Drug_Id", System.Data.SqlDbType.Char, 13).Value = drug.Id;
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
