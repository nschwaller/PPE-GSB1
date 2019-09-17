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
        public Form1()
        {
            SQL REQ = new SQL();
            InitializeComponent();
            MySqlConnection maConnexion = new MySqlConnection(REQ.getconn());
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
            dataGridView1.DataSource = DS.Tables[0];

            maConnexion.Close();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }
   
    }
}
