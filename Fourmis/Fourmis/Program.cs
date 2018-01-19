using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fourmis
{
    class Program
    {
        static void Main(string[] args)
        {
            Livre unLivre = new Livre();

        }
        public class Livre
        {
            private string strTitre;
            private int INbPage;
            private string strAuteur;
            private DateTime _dateParution;
            private string strIsbn;
            private double dblPrix;
            
            public void setTitre(string Titre)
            {
                this.strTitre = Titre;
            }
            public void setAuteur(string Auteur)
            {
                this.strAuteur = Auteur;
            }
            public void setIsbn(string Isbn)
            {
                this.strIsbn = Isbn;
            }
            public void setINbPage(int INbPage)
            {
                this.INbPage = INbPage;
            }
            public void set(string Titre)
            {
                this.strTitre = Titre;
            }
        }
    }
}
