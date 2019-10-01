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
        public SQL connectBase = new SQL();

        public Form1()
        {
            InitializeComponent();
            INITIALISATION();
            RecuperationMedoOffi();
        }

        //AFFICHAGE HISTORIQUE ET STOCK//
        public void initialisationDataView()
        {        
            DV_Affiche_Hist.DataSource = connectBase.ReqHistorique().Tables[0];
            DV_aff_Stock.DataSource = connectBase.ReqStock().Tables[0];
        }

       //AFFICHAGE COMMANDE//
        public void datagried()
        {
            this.dataGridView2.DataSource = null;
            dataGridView2.DataSource = connectBase.ReqCommand().Tables[0];
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        
        //FONCTION QUI APPEL NOS DEUX FONCTIONS PERMET D'ECRIRE UNE LIGNE AU LIEU DE DEUX//
        private void INITIALISATION()
        {           
            initialisationDataView();
            datagried();    
        }

        //REQUETE POUR RECUP MEDICAMENT ET OFFICINE POUR LES SELECT//
        private void RecuperationMedoOffi()
        {
            lesMedocs = connectBase.ALLMedicament();
            lesOfficines = connectBase.ALLOfficine();
            for (int i = 0; i < lesMedocs.Count(); i++)
            {
                medocSelec.Items.Add(lesMedocs[i].getNomMed());
                selecMedoc.Items.Add(lesMedocs[i].getNomMed());
            }
            for (int i = 0; i < lesOfficines.Count(); i++)
            {
                selecOfficine.Items.Add(lesOfficines[i].getNom());
            }
        }

        //SUPPRESSION DES COMMANDES QUAND L'UTILISATEUR SELECTIONNE UNE LIGNE ET APPUIE SUR "SUPPR"//
        private void DataGridView2_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {
                string id;
                id = row.Cells[0].Value.ToString();
                connectBase.supprCommande(id);
            }
        }

        //BOUTON AJOUTER POUR AJOUTER LES MEDICAMENTS AU STOCK
        private void Ajouter_Click(object sender, EventArgs e)
        {
            string m = Convert.ToString(medocSelec.SelectedItem);            
            int quantite = Convert.ToInt32(medocAjouter.Text);

            for (int i=0; i<lesMedocs.Count; i++)
            {
                if(lesMedocs[i].getNomMed() == m)
                {
                    int id = lesMedocs[i].getIdMed();
                    connectBase.AjoutMedStock(id, quantite);
                    INITIALISATION();
                    medocSelec.Text = "";
                    medocAjouter.Text = "";
                    break;
                }
            }  
        }

        //BOUTON ENVOYER POUR ENVOYER LES MEDICAMENTS AUX OFFICINES EN TESTANT LA QUANTITE EN STOCK ET SI IL FAUT UNE ORDONANCE//
        private void SupprimeStock_Click(object sender, EventArgs e)
        {
            string o = Convert.ToString(selecOfficine.SelectedItem);
            string m = Convert.ToString(selecMedoc.SelectedItem);
            string quantite = quantiteCommande.Text;

            for (int i = 0; i < lesMedocs.Count; i++)
            {
                if (lesMedocs[i].getNomMed() == m)
                {
                    DataSet stock = connectBase.ReqStock();
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

                                lesoffs = connectBase.Parapharmacie();
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
                                        connectBase.insertHist(idOff, idMed, quantite);
                                    }
                                }
                                else
                                {
                                    connectBase.insertHist(idOff, idMed, quantite);
                                }
                                INITIALISATION();
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
