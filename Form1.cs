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

        public void datagried()
        {
            this.dataGridView2.DataSource = null;
            SQL REQ = new SQL();
            MySqlConnection maConnexion = new MySqlConnection(REQ.getconn());
            maConnexion.Open();
            string sql = "SELECT id_hist as id_commande,date_hist as date_commande,quantite_hist as quantite_medoc, Officine.nom_off as Officine, Medicament.nom_med as Medicament FROM Historique INNER JOIN Officine ON Historique.id_off = Officine.id_off INNER JOIN Medicament ON Historique.id_med = Medicament.id_med WHERE Historique.id_off IS NOT NULL ORDER BY date_hist ASC;";
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
            datagried();
        }

        private void DataGridView2_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {
                string id;
                id=row.Cells[0].Value.ToString();
                SQL REQ = new SQL();
                MySqlConnection maConnexion = new MySqlConnection(REQ.getconn());
                maConnexion.Open();
                string sql = "DELETE FROM Historique WHERE id_hist =" + id ;
                MySqlCommand maReq = new MySqlCommand(sql, maConnexion);
                maReq.ExecuteNonQuery();
                maConnexion.Close();
            }
        }

    }
}
