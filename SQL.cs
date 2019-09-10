using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PPE_GSB1
{
    class SQL
    {
        public SQL()
        {
            string connStr = "server=172.19.0.4;user=phpmyadmin;database=GRB;port=3306;password=0550002D";
            MySqlConnection conn = new MySqlConnection(connStr);
        }
    }
}

