using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PPE_GSB1
{
    public partial class Form1 : Form
    {
        public void initialisationDataView()
        {
            SQL connectBase = new SQL();
            DV_Affiche_Hist.DataSource = connectBase.ReqHistorique().Tables[0];
            DV_aff_Stock.DataSource = connectBase.ReqStock().Tables[0];
        }
        public Form1()
        {
            /*SQL REQ = new SQL();*/
            InitializeComponent();
            initialisationDataView();
            /*MySqlConnection maConnexion = new MySqlConnection(REQ.getconn());
            maConnexion.Open();
            string sql = "SELECT id_hist as id_commande,date_hist as date_commande,quantite_hist as quantite_medoc, nom_off.Officine  FROM ";
            MySqlCommand maReq = new MySqlCommand(sql, maConnexion);

            // Afficher les résultats ligne par ligne :
            MySqlDataReader resultats = maReq.ExecuteReader();
            while (resultats.Read())
            {
                MessageBox.Show(resultats[2].ToString());
            }

            // Executer des requêtes non-SELECT (ne retournant aucun résultat)
            maReq.ExecuteNonQuery();

            // Affichage des résultats dans un DataGridView (méthode du DataSet)
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(sql, maConnexion);
            DataSet DS = new DataSet();
            mySqlDataAdapter.Fill(DS);
            DV_Affiche_Hist.DataSource = DS.Tables[0];

            maConnexion.Close();*/

        }
    }
}
