using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUS_GetData
    {
        DAL_DBConnect dbConnect = new DAL_DBConnect();
        public SqlDataReader getDataStoredProcedure(String query)
        {
            return dbConnect.getDataStoredProcedure(query);
        }

        public DataTable getDataTable(String query)
        {
            return dbConnect.getDataTable(query);
        }
    }
}
