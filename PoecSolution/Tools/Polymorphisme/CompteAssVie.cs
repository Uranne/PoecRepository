using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public class CompteAssVie : ICompte
    {
        private double _solde;

        public double Solde
        {
            get
            {
                return _solde;
            }
            set
            {
                if (value>=500)
                {
                    _solde = value;
                }
                else
                {
                    throw new Exception("Solde insuffisant");
                }
            }
        }
        
        public bool Deposer(double montant)
        {
            Solde += (montant * 0.95);
            return true;
        }

        public bool Retirer(double montant)
        {
            Solde -= (montant * 1.04);
            return true;
        }
    }
}
