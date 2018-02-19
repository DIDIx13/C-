using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTDD
{    
    class Pizza
    {
        private const int MAX_GARNITURES = 8;

        private int iNumero;
        private string strNom;
        private double dblPrixDeVente;
        private List<Garniture> _garnitures;

        public Pizza(int num, string nom)
        {
          
        }
        public Pizza(int num, string nom, double prixDeVente)
        {
          
        }

        private void initialisation(int num, string nom, double prixDeVente)
        {
          
        }

        public string LireGarnitures()
        {
            string strGarnitures = "";
            return strGarnitures;
        }

        public bool AjouterGaniture(string nom, double prixRevient, int quantite)
        {
            bool bReussi = false;
            return bReussi;
        }
    }
}
