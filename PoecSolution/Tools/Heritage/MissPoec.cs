using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public class MissPoec:Poec
    {
        public MissPoec(string nom, string prenom):base(nom, prenom)
        {

        }

        public override void SuivreUnCours(string Titre)
        {
            Console.WriteLine("{0} {1} suit un cours de {2}", Prenom, Nom, Titre);
            Progresser(7);
        }
    }
}
