using System;
using System.Collections.Generic;
public class Livre : Produit
{
    private string strTitre;
    private string strIsbn;
    private string strGenre;
    private List<string> _auteurs;

    private void Init(string titre, string isbn, string genre)
    {
        strTitre = titre;
        strIsbn = isbn;
        strGenre = genre;
        
        _auteurs = new List<string>();
    }
    public Livre(string titre, string isbn, string genre,string id):base(id)
    {
        Init(titre, isbn, genre);
    }
    public Livre(string titre, string isbn, string genre, string id, double prix, DateTime date):base(id, prix, date)
    {
        Init(titre, isbn, genre);
    }
    public void AddAuteur(string auteur)
    {
        _auteurs.Add(auteur);
    }
    public List<string> Auteurs
    {
        get { return _auteurs; }        
        private set { _auteurs = value; }
    } 
    public string Titre
    {
        get { return strTitre; }
        private set { strTitre = value; }
    }
    public string Isbn
    {
        get { return strIsbn; }
        private set { strIsbn = value; }
    }
    public string Genre
    {
        get { return strGenre; }
        set { strGenre = value; }
    }
    public override string ToString()
    {
        string s = base.ToString();
        s += "Titre: " + Titre + Environment.NewLine;
        s += "Genre: " + Genre + Environment.NewLine;
        s += "isbn: " + Isbn + Environment.NewLine;
        s += "Auteur(s)" + Environment.NewLine + "=========" + Environment.NewLine;
        foreach (string auteur in _auteurs)
        {
            s += "* " + auteur + Environment.NewLine;
        }
        return s;
    }
}


