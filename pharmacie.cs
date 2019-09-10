using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE_GSB1
{
    class Pharmacie : officine
    {
        private int registre_pha;

        public Pharmacie()
        {

        }

        public int getregistre()
        {
            return this.registre_pha;

        }

        public void setregistre(int leregistre)
        {
            this.registre_pha = leregistre;
        }
    }
}
