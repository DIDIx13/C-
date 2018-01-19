using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyTools
{
    class Tag
    {
        #region GENRES
        private string[] genres =
        {
        "Blues","Classic Rock","Country","Dance","Disco","Funk","Grunge","Hip-Hop","Jazz","Metal",
        "New Age","Oldies","Other","Pop","R&B","Rap","Reggae","Rock","Techno","Industrial",
        "Alternative","Ska","Death Metal","Pranks","Soundtrack","Euro-Techno","Ambient","Trip-Hop",
        "Vocal","Jazz+Funk","Fusion","Trance","Classical","Instrumental","Acid","House",
        "Game","Sound Clip","Gospel","Noise","Alternative Rock","Bass","Soul","Punk","Space",
        "Meditative","Instrumental Pop","Instrumental Rock","Ethnic","Gothic",
        "Darkwave","Techno-Industrial","Electronic","Pop-Folk","Eurodance","Dream",
        "Southern Rock","Comedy","Cult","Gangsta","Top 40","Christian Rap","Pop/Funk","Jungle",
        "Native American","Cabaret","New Wave","Psychadelic","Rave","Showtunes","Trailer","Lo-Fi",
        "Tribal","Acid Punk","Acid Jazz","Polka","Retro","Musical","Rock & Roll","Hard Rock","Folk",
        "Folk/Rock","National Folk","Swing","Fast-Fusion","Bebob","Latin","Revival","Celtic","Bluegrass",
        "Avantgarde","Gothic Rock","Progressive Rock","Psychedelic Rock","Symphonic Rock","Slow Rock",
        "Big Band","Chorus","Easy Listening","Acoustic","Humour","Speech","Chanson","Opera","Chamber Music",
        "Sonata","Symphony","Booty Bass","Primus","Porn Groove","Satire","Slow Jam","Club",
        "Tango","Samba","Folklore","Ballad","Power Ballad","Rhytmic Soul","Freestyle","Duet",
        "Punk Rock","Drum Solo","Acapella","Euro-House","Dance Hall","Goa","Drum & Bass","Club-House",
        "Hardcore","Terror","Indie","BritPop","Negerpunk","Polsk Punk","Beat","Christian Gangsta Rap",
        "Heavy Metal","Black Metal","Crossover","Contemporary Christian",
        "Christian Rock","Merengue","Salsa","Trash Metal","Anime","JPop","SynthPop"
};
        #endregion
        private int iAnnee;
        private int iNoPiste;
        private string strCommentaire;
        private string strGenreMusical;
        private string strNomAlbum;
        private string strNomInterprete;
        private string strTitre;

        /// <summary>
        /// Constructeur spécifique
        /// </summary>
        /// <param name="path">Chemin du fichier mp3</param>
        public Tag(string path)
        {
            GetTags(path);
        }

        /// <summary>
        /// Accesseur de lecture pour l'année
        /// </summary>
        /// <returns>L'année de parution</returns>
        public int getAnnee()
        {
            return iAnnee;
        }

        /// <summary>
        /// Accesseur de lecture pour les commentaires
        /// </summary>
        /// <returns>Les commentaires</returns>
        public string getCommentaire()
        {
            return strCommentaire;
        }

        /// <summary>
        /// Accesseur de lecture pour le genre musical
        /// </summary>
        /// <returns>Le genre musical</returns>
        public string getGenreMusical()
        {
            return strGenreMusical;
        }

        /// <summary>
        /// Accesseur de lecture pour le nom de l'album
        /// </summary>
        /// <returns>Le nom de l'album</returns>
        public string getNomAlbum()
        {
            return strNomAlbum;
        }

        /// <summary>
        /// Accesseur de lecture pour le nom de l'interprète
        /// </summary>
        /// <returns>Le nom de l'interprète</returns>
        public string getNomInterprete()
        {
            return strNomInterprete;
        }

        /// <summary>
        /// Accesseur de lecture pour le numéro de piste
        /// </summary>
        /// <returns>Le numéro de piste</returns>
        public int getNoPiste()
        {
            return iNoPiste;
        }

        /// <summary>
        /// Accesseur de lecture pour le titre
        /// </summary>
        /// <returns>Le titre</returns>
        public string getTitre()
        {
            return strTitre;
        }

        public void GetTags(string path)
        {
            byte[] data = new byte[128];

            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                fs.Seek(-128, SeekOrigin.End);
                for (int i = 0; i < 128; i++)
                {
                    fs.Read(data, 0, 128);
                }
            }

            ArraySegment<byte> bytes;

            if (data[0] == 'T' && data[1] == 'A' && data[2] == 'G')
            {
                bytes = new ArraySegment<byte>(data, 3, 30);
                strTitre = Encoding.Default.GetString(bytes.ToArray());

                if (strTitre != null && strTitre.IndexOf('\0') > 0)
                    strTitre = strTitre.Substring(0, strTitre.IndexOf('\0')); // Supprime les '\0' en trop

                bytes = new ArraySegment<byte>(data, 33, 30);
                strNomInterprete = Encoding.Default.GetString(bytes.ToArray());

                if (strNomInterprete != null && strNomInterprete.IndexOf('\0') > 0)
                    strNomInterprete = strNomInterprete.Substring(0, strNomInterprete.IndexOf('\0'));

                bytes = new ArraySegment<byte>(data, 63, 30);
                strNomAlbum = Encoding.Default.GetString(bytes.ToArray());

                if (strNomAlbum != null && strNomAlbum.IndexOf('\0') > 0)
                    strNomAlbum = strNomAlbum.Substring(0, strNomAlbum.IndexOf('\0'));

                bytes = new ArraySegment<byte>(data, 93, 4);
                iAnnee = Convert.ToInt32(Encoding.Default.GetString(bytes.ToArray()));

                bytes = new ArraySegment<byte>(data, 97, 28);
                strCommentaire = Encoding.Default.GetString(bytes.ToArray());

                if (strCommentaire != null && strCommentaire.IndexOf('\0') > 0)
                    strCommentaire = strCommentaire.Substring(0, strCommentaire.IndexOf('\0'));

                iNoPiste = Convert.ToInt32(data[126]);

                int iIndice = Convert.ToInt32(data[127]);

                if (iIndice >= 0 && iIndice <= genres.Length)
                {
                    strGenreMusical = genres[iIndice];
                }
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
