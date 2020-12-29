using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUS
{
    public class BUS_DBConnect
    {
        DAL_DBConnect dBConnection = new DAL_DBConnect();
        public BUS_DBConnect()
        {
            
        }

        public bool DBConnect(DTO_DBConnect dto)
        {
            return dBConnection.DBConnect(dto);
        }

        public bool DBDisconnect()
        {
            return dBConnection.DBDisconnect();
        }
    }
}
