using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public interface ICompte
    {
        double Solde { get; set; }

        bool Deposer(double montant);

        bool Retirer(double montant);
    }
}
