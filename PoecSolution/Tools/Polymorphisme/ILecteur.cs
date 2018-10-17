using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public interface ILecteur
    {
        //propriété
        string Chemin { get; set; }

        //2 surcharges de méthodes Lire
        string Lire();
        string Lire(string chemin);

        //2 surcharge de méthode Ajouter
        string Ajouter();
        string Ajouter(string chemin);
    }
}
