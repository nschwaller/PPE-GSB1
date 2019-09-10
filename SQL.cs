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
        private string IP = "172.19.0.4";
        private string USER = "phpmyadmin";
        private string MDP = "0550002D";
        private string DATABASE = "GRB";
        public SQL()
        {
            string connStr = "server=" + this.IP + ";user=" + this.USER + ";database=" + this.DATABASE + ";port=3306;password=" + this.MDP;
            MySqlConnection conn = new MySqlConnection(connStr);
        }
    }
}

