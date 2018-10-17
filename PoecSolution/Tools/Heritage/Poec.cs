using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public class Poec
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public Poec(string nom, string prenom)
        {
            Nom = nom;
            Prenom = prenom;
        }

        public virtual void SuivreUnCours(string Titre)
        {
            Console.WriteLine("{0} {1} suit un cours de {2}", Prenom, Nom, Titre);
            Progresser(5);
        }
        public void Progresser(int Points)
        {
            Niveau += Points;
            Console.WriteLine("{0} {1} progresse de {2} points\nSon total est donc de {3}", Prenom,Nom,Points, Niveau);
        }

        private int _niveau;

        public int Niveau
        {
            get { return _niveau; }
            set
            {
                if (value >= 0)
                {
                    _niveau = value;
                }
            }
        }

    }
}
