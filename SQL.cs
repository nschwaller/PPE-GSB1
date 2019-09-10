using System;
using System.Collections.Generic;
using System.Data;
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
        private string DATABASE = "GSB";
        MySqlConnection conn;
        public SQL()
        {
            string connStr = "server=" + this.IP + ";user=" + this.USER + ";database=" + this.DATABASE + ";port=3306;password=" + this.MDP;
            conn = new MySqlConnection(connStr);
        }
        public string test() {
            conn.Open();
            string information = "rien";
            string req = "SELECT * FROM Medicament";
            MySqlCommand command = new MySqlCommand(req, this.conn);            
            DataSet DS = new DataSet();
            MySqlDataAdapter rep = new MySqlDataAdapter(req, this.conn);
            rep.Fill(DS);
            conn.Close();

            return information;
        }
    }
}

