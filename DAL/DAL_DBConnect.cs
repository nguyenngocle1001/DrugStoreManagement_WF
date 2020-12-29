using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace DAL
{
    public class DAL_DBConnect
    {
        public static SqlConnection connection;

        public DAL_DBConnect() { }

        public bool DBConnect(DTO_DBConnect login)
        {
            try
            {
                String connectionString = @"Data Source=" + login.SeverName
                                       + ";Initial Catalog=" + login.Database
                                       + ";Persist Security Info=True;"
                                       + "User ID=" + login.UserID
                                       + ";Password=" + login.Password;

                connection = new SqlConnection(connectionString);
                connection.Open();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }

        public bool DBDisconnect()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        //lấy datatable
        public DataTable getDataTable(String query)
        {
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(data);

            return data;
        }


        //procedure không có tham số
        public SqlDataReader getDataStoredProcedure(string query)
        {
            try
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader();
                return reader;
            }catch(Exception e)
            {
                MessageBox.Show(e.Message.ToString(), "Thông báo");
                return null;
            }
        }
    }
}
