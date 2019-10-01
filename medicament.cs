using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE_GSB1
{
    class medicament
    {
        private int id_med;
        private string nom_med;
        private bool ordonnance;

        public medicament(int id, string nom, bool ordo)
        {
            this.id_med = id;
            this.nom_med = nom;
            this.ordonnance = ordo;
        }

        public int getIdMed()
        {
            return id_med;
        }

        public string getNomMed()
        {
            return nom_med;
        }

        public bool getOrdonance()
        {
            return ordonnance;
        }

        public void setIdMed(int leid_med)
        {
            this.id_med=leid_med;
        }

        public void setNomMed(string lenom_med)
        {
            this.nom_med = lenom_med;
        }

        public void setordonnance(bool lordonnance)
        {
            this.ordonnance = lordonnance;
        }

    }
}
