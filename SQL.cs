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
        private string USER = "root";
        private string MDP = "0550002D";
        private string DATABASE = "GSB";
        private MySqlConnection conn;
        public SQL()
        {
            string connStr = "server=" + this.IP + ";user=" + this.USER + ";database=" + this.DATABASE + ";port=3306;password=" + this.MDP;
            conn = new MySqlConnection(connStr);
        }
        public MySqlConnection GetConnecttion()
        {
            return conn;
        }

        public string getconn()
        {
            return "server=" + this.IP + ";user=" + this.USER + ";database=" + this.DATABASE + ";port=3306;password=" + this.MDP;
        }
        public DataSet ReqHistorique()
        {
            string requete = "SELECT date_hist as Date,quantite_hist as Quantiter,nom_med as Nom FROM Historique INNER JOIN Medicament ON Medicament.id_med = Historique.id_med ORDER BY date_hist DESC";
            MySqlCommand maReq = new MySqlCommand(requete, this.conn);
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(requete, this.conn);
            DataSet DS = new DataSet();
            mySqlDataAdapter.Fill(DS);
            return DS;
        }
        public DataSet ReqStock()
        {
            string requete = "SELECT SUM(quantite_hist) as Quantite, nom_med as Medicament FROM Medicament INNER JOIN Historique ON Medicament.id_med = Historique.id_med GROUP By Historique.id_med ORDER BY Quantite DESC, Medicament ASC";
            MySqlCommand maReq = new MySqlCommand(requete, this.conn);
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(requete, this.conn);
            DataSet DS = new DataSet();
            mySqlDataAdapter.Fill(DS);
            return DS;
        }

        public List<int> Parapharmacie()
        {
            string para = "SELECT id_off FROM Parapharmacie";
            List<int> Parapharmacie = new List<int>();
            MySqlCommand larequete = new MySqlCommand(para, this.conn);
            this.conn.Open();
            MySqlDataReader paraph = larequete.ExecuteReader();
            while (paraph.Read())
            {
                Parapharmacie.Add(Convert.ToInt32(paraph["id_off"]));
            }
            this.conn.Close();
            return Parapharmacie;
        }

        public void insertHist(string idOFF,string idmed, string quantite)
        {
            string medoc = "INSERT INTO Historique(date_hist, id_med, quantite_hist, id_off) VALUES ( NOW(), '" + idmed + "', '-" + quantite + "', '" + idOFF + "')";
            MySqlCommand req = new MySqlCommand(medoc, this.conn);
            this.conn.Open();
            req.ExecuteNonQuery();
            this.conn.Close();
        }
    }
}

