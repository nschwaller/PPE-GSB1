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
        private List<medicament> lesMedocs = new List<medicament>();
        private List<officine> lesOfficines = new List<officine>();

        public Form1()
        {
            SQL REQ = new SQL();
            InitializeComponent();
            MySqlConnection maConnexion = new MySqlConnection(REQ.getconn());
            //maConnexion.Open();
            //string sql = "SELECT id_hist as id_commande,date_hist as date_commande,quantite_hist as quantite_medoc, nom_off.Officine  FROM ";
            //MySqlCommand maReq = new MySqlCommand(sql, maConnexion);

            // Afficher les résultats ligne par ligne :
            //MySqlDataReader resultats = maReq.ExecuteReader();
           /* while (resultats.Read())
            {
                MessageBox.Show(resultats[2].ToString());
            }*/

            // Executer des requêtes non-SELECT (ne retournant aucun résultat)
            //maReq.ExecuteNonQuery();

            // Affichage des résultats dans un DataGridView (méthode du DataSet)
            /*MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(sql, maConnexion);
            DataSet DS = new DataSet();
            mySqlDataAdapter.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];

            maConnexion.Close();*/

            //Partie adam pour ajout medoc dans list and affiche
            maConnexion.Open();
            string medoc = "SELECT * FROM Medicament";
            string off = "SELECT * FROM Officine";
            MySqlCommand req = new MySqlCommand(medoc, maConnexion);
            MySqlCommand reqOff = new MySqlCommand(off, maConnexion);

            MySqlDataReader medicament = req.ExecuteReader();
            while (medicament.Read())
            {
                medicament leMedoc = new medicament(Convert.ToInt16(medicament["id_med"]), Convert.ToString(medicament["nom_med"]), Convert.ToBoolean(medicament["ordonnance"]));
                lesMedocs.Add(leMedoc); 
            }
            for (int i = 0; i < lesMedocs.Count(); i++)
            {
                medocSelec.Items.Add(lesMedocs[i].getNomMed());
                selecMedoc.Items.Add(lesMedocs[i]);
            }
            MySqlDataReader officine = reqOff.ExecuteReader();
            while (officine.Read())
            {
                officine Off = new officine(Convert.ToInt16(officine["id_off"]), Convert.ToString(officine["cp_off"]), Convert.ToString(officine["ville_off"]), Convert.ToString(officine["numerot_off"]), Convert.ToString(officine["nom_off"]));
                lesOfficines.Add(Off);
            }
            for (int i = 0; i < lesOfficines.Count(); i++)
            {
                selecOfficine.Items.Add(lesOfficines[i].getNom());
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            string m = Convert.ToString(medocSelec.SelectedItem);            
            string quantite = "+"+medocAjouter.Text;

            for (int i=0; i<lesMedocs.Count; i++)
            {
                if(lesMedocs[i].getNomMed() == m)
                {
                    string id = Convert.ToString(lesMedocs[i].getIdMed());
                    string medoc = "INSERT INTO Historique(date_hist, id_med, quantite_hist) VALUES ( NOW(), '" + id + "', '" + quantite + "')";
                    SQL REQ = new SQL();
                    MySqlConnection maConnexion = new MySqlConnection(REQ.getconn());
                    maConnexion.Open();
                    MySqlCommand req = new MySqlCommand(medoc, maConnexion);
                    maConnexion.Close();
                    break;
                }
            }  
        }

        private void SupprimeStock_Click(object sender, EventArgs e)
        {
            string o = Convert.ToString(selecOfficine.SelectedItem);
            string m = Convert.ToString(selecMedoc.SelectedItem);
            string quantite = "-" + quantiteCommande.Text;

            for (int i = 0; i < lesMedocs.Count; i++)
            {
                if (lesMedocs[i].getNomMed() == m)
                {
                    for (int j=0; j < lesOfficines.Count; j++)
                    {
                        if (lesOfficines[i].getNom() == o)
                        {
                            string idOff = Convert.ToString(lesOfficines[i].getId());
                            string idMed = Convert.ToString(lesMedocs[i].getIdMed());
                            string medoc = "INSERT INTO Historique(date_hist, id_med, quantite_hist, id_off) VALUES ( NOW(), '" + idMed + "', '+" + quantite + "', '" + idOff + "')";
                            SQL REQ = new SQL();
                            MySqlConnection maConnexion = new MySqlConnection(REQ.getconn());
                            maConnexion.Open();
                            MySqlCommand req = new MySqlCommand(medoc, maConnexion);
                            maConnexion.Close();
                            break;
                        }
                        
                    }
                    
                }
            }
        }
    }
}
