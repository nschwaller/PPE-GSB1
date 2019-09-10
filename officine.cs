using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE_GSB1
{
    public class officine
    {
        private string codePostal;
        private string ville;
        private string numeroTel;
        private string numeroContact;
        private string nom;
        private int id;

        public officine()
        {

        }

        public string getCPostal()
        {
            return this.codePostal;
        }
        public void setCPostal(string cp)
        {
            this.codePostal = cp;
        }
        public string getVille()
        {
            return this.ville;
        }
        public void setVille(string vil)
        {
            this.ville = vil;
        }
        public string getNumTel()
        {
            return this.numeroTel;
        }
        public void setNumTel(string tel)
        {
            this.numeroTel = tel;
        }
        public string getNumContact()
        {
            return this.numeroContact;
        }
        public void setNumContact(string contact)
        {
            this.numeroContact = contact;
        }
        public string getNom()
        {
            return this.nom;
        }
        public void setNom(string nm)
        {
            this.nom = nm;
        }
        public int getId()
        {
            return this.id;
        }
        public void setId(int i)
        {
            this.id = i;
        }
    }
}
