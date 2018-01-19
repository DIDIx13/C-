using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyTools
{
    class Musitheque
    {
        private string strRepertoire;
        private List<Fichier> _fichiers;

        public Musitheque()
        {
            _fichiers = new List<Fichier>();
        }

        public Musitheque(string path)
        {
            _fichiers = new List<Fichier>();
            strRepertoire = path;
        }

        public List<Fichier> getFichier()
        {
            return _fichiers;
        }

        public string getRepertoire()
        {
            return strRepertoire;
        }

        public void Scan()
        {
            List<string> paths;
            paths = Directory.GetFiles(strRepertoire, "*.mp3", SearchOption.AllDirectories).ToList();
        }

        public void setRepertoire(string path)
        {
            strRepertoire = path;
        }
    }
}