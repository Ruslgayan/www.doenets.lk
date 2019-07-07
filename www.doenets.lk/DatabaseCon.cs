using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace www.doenets.lk
{
    class DatabaseCon
    {
        public static MySqlConnection connectDB()
        {
            string server = "localhost";
            string database = "doenets";
            string uid = "root";
            string pwd = "";

            string conString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + pwd + ";";

            MySqlConnection con = new MySqlConnection(conString);
            return con;
        }
    }
}
