using System;
public class Produit
{
    private string strID;
    private DateTime _date;
    protected double dblPrice;

    private void Initialisation(string id, double prix, DateTime dateCreationProduit)
    {
        strID = id;
        dblPrice = prix;
        _date = dateCreationProduit;
    }
    public Produit(string id)
    {
        Initialisation(id, 0.0, DateTime.Now);
    }
    public Produit(string id, double prix, DateTime date)
    {
        Initialisation(id, prix, date);
    }
    public string id
    {
        get { return strID; }
        private set { strID = value; }
    }
    protected double prix
    {
        get { return dblPrice; }
        private set { dblPrice = value; }
    }
    public DateTime date
    {
        get { return _date; }
        private set { _date = value; }
    }
    public override string ToString()
    {
        return "ID: " + id + Environment.NewLine + "Prix de : " + prix + Environment.NewLine + "Date: " + date;
    }
}
