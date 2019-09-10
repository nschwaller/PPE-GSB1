using System;

public class officine
{
    private string codePostal;
    private string ville;
    private string numeroTel;
    private string numeroContact;
    private string nom;
    private string id;

    public officine()
	{

	}

    public getCPostal()
    {
        return this.codePostal;
    }
    public void setCPostal(string cp)
    {
        this.codePostal = cp;
    }
    public getVille()
    {
        return this.ville;
    }
    public void setVille(string vil)
    {
        this.ville = vil;
    }
    public getNumTel()
    {
        return this.numeroTel;
    }
    public void setNumTel(string tel)
    {
        this.numeroTel = tel;
    }
    public getNumContact()
    {
        return this.numeroContact;
    }
    public void setNumContact(string contact)
    {
        this.numeroContact = contact;
    }
    public getNom()
    {
        return this.nom;
    }
    public void setNom(string nm)
    {
        this.nom = nm;
    }
    public getId()
    {
        return this.id;
    }
    public void setId(string i)
    {
        this.id = i;
    }
}
