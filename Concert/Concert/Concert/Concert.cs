using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concert
{
    class Concert
    {
        private string salle;
        private string lieu;
        private DateTime date;
        private double cachet;
        private int NbSpectateurs;
        private int note;
        private string commentaires;
        private string avantagesDivers;

        public Concert()
        {

        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
