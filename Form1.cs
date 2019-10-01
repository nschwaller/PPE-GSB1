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
        

        //public Form1()
        public void initialisationDataView()
        {
            SQL connectBase = new SQL();
            DV_Affiche_Hist.DataSource = connectBase.ReqHistorique().Tables[0];
            DV_aff_Stock.DataSource = connectBase.ReqStock().Tables[0];
        }
       // public Form1()
       //CODE COMMANDE PAGE 3//
        public void datagried()
        {
            this.dataGridView2.DataSource = null;
            SQL REQ = new SQL();
            MySqlConnection maConnexion = new MySqlConnection(REQ.getconn());
            maConnexion.Open();
            string sql = "SELECT id_hist as `Id Commande`,date_hist as `Date Commande`,quantite_hist as Quantite, Officine.nom_off as Officine, Medicament.nom_med as Medicament FROM Historique INNER JOIN Officine ON Historique.id_off = Officine.id_off INNER JOIN Medicament ON Historique.id_med = Medicament.id_med WHERE Historique.id_off IS NOT NULL ORDER BY date_hist ASC;";
            MySqlCommand maReq = new MySqlCommand(sql, maConnexion);

            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(sql, maConnexion);
            DataSet DS = new DataSet();
            mySqlDataAdapter.Fill(DS);
            dataGridView2.DataSource = DS.Tables[0];

            maConnexion.Close();

            
       
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public Form1()
        {          
            InitializeComponent();
            initialisationDataView();
            datagried();
            //Partie adam pour ajout medoc dans list and affiche
            SQL REQ = new SQL();
            MySqlConnection maConnexion = new MySqlConnection(REQ.getconn());
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
                selecMedoc.Items.Add(lesMedocs[i].getNomMed());
            }
            maConnexion.Close();
            maConnexion.Open();
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
            maConnexion.Close();
        }
        private void DataGridView2_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {
                string id;
                id = row.Cells[0].Value.ToString();
                SQL REQ = new SQL();
                MySqlConnection maConnexion = new MySqlConnection(REQ.getconn());
                maConnexion.Open();
                string sql = "DELETE FROM Historique WHERE id_hist =" + id;
                MySqlCommand maReq = new MySqlCommand(sql, maConnexion);
                maReq.ExecuteNonQuery();
                maConnexion.Close();
            }
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
                    req.ExecuteNonQuery();
                    maConnexion.Close();
                    initialisationDataView();
                    datagried();
                    medocSelec.Text = "";
                    medocAjouter.Text = "";
                    break;
                }
            }  
        }

        private void SupprimeStock_Click(object sender, EventArgs e)
        {
            string o = Convert.ToString(selecOfficine.SelectedItem);
            string m = Convert.ToString(selecMedoc.SelectedItem);
            string quantite = quantiteCommande.Text;

            for (int i = 0; i < lesMedocs.Count; i++)
            {
                if (lesMedocs[i].getNomMed() == m)
                {
                    SQL connexionbase = new SQL();

                    DataSet stock = connexionbase.ReqStock();
                    bool ValideStock = false;
                    foreach (DataRow dr in stock.Tables[0].Rows)
                    {
                        if (lesMedocs[i].getNomMed() == dr["Medicament"].ToString())
                        {
                            if(Convert.ToInt64(dr["Quantite"].ToString())>= Convert.ToInt64(quantite))
                            {
                                ValideStock = true;
                            }                                
                        }
                    }
                    if (ValideStock)
                    {
                        for (int j = 0; j < lesOfficines.Count; j++)
                        {
                            if (lesOfficines[j].getNom() == o)
                            {
                                string idOff = Convert.ToString(lesOfficines[j].getId());
                                string idMed = Convert.ToString(lesMedocs[i].getIdMed());
                                List<int> lesoffs = new List<int>();

                                lesoffs = connexionbase.Parapharmacie();
                                bool cestparaph = false;
                                foreach (int officine in lesoffs)
                                {
                                    if (officine == Convert.ToInt32(idOff))
                                    {
                                        cestparaph = true;
                                        break;
                                    }
                                }

                                if (lesMedocs[i].getOrdonance())
                                {
                                    if (cestparaph)
                                    {
                                        MessageBox.Show("Les parapharmacie ne peuvent pas acheter de médicaments sous ordonnance");
                                    }
                                    else
                                    {
                                        connexionbase.insertHist(idOff, idMed, quantite);
                                    }
                                }
                                else
                                {
                                    connexionbase.insertHist(idOff, idMed, quantite);
                                }
                                initialisationDataView();
                                datagried();
                                quantiteCommande.Text = "";
                                selecOfficine.Text = "";
                                selecMedoc.Text = "";
                                break;
                            }

                        }
                    }
                    else
                        MessageBox.Show("Nous avons pas assez de ce Medicament en stock ");
                    
                }
            }
        }
    }
}
