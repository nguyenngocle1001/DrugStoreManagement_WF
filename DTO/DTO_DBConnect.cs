using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DBConnect
    {
        private string severName;
        private string database;
        private string userID;
        private string password;

        public DTO_DBConnect()
        {
            this.SeverName = "";
            this.Database = "";
            this.UserID = "";
            this.Password = "";
        }

        public DTO_DBConnect(string severName, string database, string userID, string password)
        {
            this.SeverName = severName;
            this.Database = database;
            this.UserID = userID;
            this.Password = password;
        }

        public string SeverName { get => severName; set => severName = value; }
        public string Database { get => database; set => database = value; }
        public string UserID { get => userID; set => userID = value; }
        public string Password { get => password; set => password = value; }
    }
}
