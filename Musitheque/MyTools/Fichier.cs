using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyTools
{
    class Fichier
    {
        private string strPath;
        private Tag _tag;

        public Fichier(string path)
        {
            if (path != "")
            {
                if (File.Exists(path))
                {
                    strPath = path;
                    _tag = new Tag(path);
                }
            }
        }

        public string getCheminAcces()
        {
            if (File.Exists(strPath))
            {
                return strPath;
            }
            else
            {
                return "";
            }
        }

        public string getFileName()
        {
            string strNomFichier = Path.GetFileName(strPath);
            return strNomFichier;
        }

        public Tag getTag()
        {
            return _tag;
        }

        public override string ToString()
        {
            return strPath + " - " + getFileName();
        }
    }
}
