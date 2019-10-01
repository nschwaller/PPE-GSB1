using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PPE_GSB1
{
    public class SQL
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

        //REQUETE POUR L'HISTORIQUE//
        public DataSet ReqHistorique()
        {
            string requete = "SELECT date_hist as Date,quantite_hist as Quantiter,nom_med as Nom FROM Historique INNER JOIN Medicament ON Medicament.id_med = Historique.id_med ORDER BY date_hist DESC";
            MySqlCommand maReq = new MySqlCommand(requete, this.conn);
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(requete, this.conn);
            DataSet DS = new DataSet();
            mySqlDataAdapter.Fill(DS);
            return DS;
        }
        //*******************//
        //REQUETE POUR LES STOCKS//
        public DataSet ReqStock()
        {
            string requete = "SELECT SUM(quantite_hist) as Quantite, nom_med as Medicament FROM Medicament INNER JOIN Historique ON Medicament.id_med = Historique.id_med GROUP By Historique.id_med ORDER BY Quantite DESC, Medicament ASC";
            MySqlCommand maReq = new MySqlCommand(requete, this.conn);
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(requete, this.conn);
            DataSet DS = new DataSet();
            mySqlDataAdapter.Fill(DS);
            return DS;
        }
        //*******************//
        //REQUETE POUR RECUP LES PARAPHARMACIE//
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
        //*******************//
        //REQUETE POUR AJOUTER UN HISTORIQUE DE COMMANDE//
        public void insertHist(string idOFF,string idmed, string quantite)
        {
            string medoc = "INSERT INTO Historique(date_hist, id_med, quantite_hist, id_off) VALUES ( NOW(), '" + idmed + "', '-" + quantite + "', '" + idOFF + "')";
            MySqlCommand req = new MySqlCommand(medoc, this.conn);
            this.conn.Open();
            req.ExecuteNonQuery();
            this.conn.Close();
        }
        //*******************//
        //REQUETE POUR AJOUTER UN MEDOC AU STOCK//
        public void AjoutMedStock(int id , int quantite)
        {
            string medoc = "INSERT INTO Historique(date_hist, id_med, quantite_hist) VALUES ( NOW(), '" + id + "', '" + quantite + "')";
            this.conn.Open();
            MySqlCommand req = new MySqlCommand(medoc, this.conn);
            req.ExecuteNonQuery();
            this.conn.Close();
        }
        //*******************//
        //REQUETE POUR RECUP LES COMMANDE//
        public DataSet ReqCommand()
        {
            string sql = "SELECT id_hist as `Id Commande`,date_hist as `Date Commande`,quantite_hist as Quantite, Officine.nom_off as Officine, Medicament.nom_med as Medicament FROM Historique INNER JOIN Officine ON Historique.id_off = Officine.id_off INNER JOIN Medicament ON Historique.id_med = Medicament.id_med WHERE Historique.id_off IS NOT NULL ORDER BY date_hist DESC;";
            MySqlCommand maReq = new MySqlCommand(sql, this.conn);
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(sql, this.conn);
            DataSet DS = new DataSet();
            mySqlDataAdapter.Fill(DS);
            return DS;
        }
        //*******************//
        //REQUETE POUR SUPPRIMER UNE COMMANDE//
        public void supprCommande(string id)
        {
            string sql = "DELETE FROM Historique WHERE id_hist =" + id;
            this.conn.Open();
            MySqlCommand maReq = new MySqlCommand(sql, this.conn);
            maReq.ExecuteNonQuery();
            this.conn.Close();
        }
        //*******************//
    }
}

