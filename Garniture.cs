using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTDD
{
    public class Garniture
    {
        private int iQuantite;
        private double dblPrixDeRevient;

        public Garniture (string nom, double prixDeRevient, int quantite)
        {
            Nom = nom;
            Update(prixDeRevient);
            Update(quantite);
        }
        public string Nom { get; private set; }

        public double getPrixDeRevient()
        {
            return dblPrixDeRevient;
        }
        public int getQuantite()
        {
            return iQuantite;
        }

        public int Quantite
        {
            get { return iQuantite; }
        }
        public void Update(double prixDeRevient)
        {
            dblPrixDeRevient = prixDeRevient;
            if (prixDeRevient<0)
            {
                dblPrixDeRevient = 0.0;
            }
        }
        public void Update(int quantite)
        {
            iQuantite = quantite;
            if (quantite < 5 || quantite > 70)
            {
                iQuantite = 15;
            }
        }
        public void Update(double prixDeRevient, int quantite)
        {
            Update(prixDeRevient);
            Update(quantite);
        }

        public override string ToString()
        {
            return Nom + ", " + iQuantite.ToString()
                + "g (" + dblPrixDeRevient.ToString("F2") + " CHF)";
        }
    }
}
