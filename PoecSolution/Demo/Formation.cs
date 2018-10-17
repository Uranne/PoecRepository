using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    struct Formation
    {
        //Equiper la structure formation d'une propriété
        //Cout, qui doit autoriser des valeurs comprises
        //entre 0 et 10000
        //Hors de cette plage, lever une exception "cout invalide"

        private int _duree;

        public int Duree
        {
            get { return _duree; }
            set
            {
                if (value > 0)
                {
                    _duree = value;
                }
                else
                {
                    throw new Exception("Pas de durée négative");
                }
            }
        }

        private double _cout;

        public double Cout
        {
            get { return _cout; }
            set
            {
                if (!(value < 0 || value > 10000))
                {
                    _cout = value;
                }
                else
                {
                    throw new Exception("Cout invalide (non compris entre 0 et 10000)");
                }

            }
        }


        public string Titre { get; set; }

        public Formation(int duree)
        {
            Titre = "Inconnu";
            _duree = duree;
            _cout = 0;
            this.Cout = 0;
        }


    }
}
