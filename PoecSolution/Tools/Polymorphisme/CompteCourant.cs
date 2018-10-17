using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public class CompteCourant : ICompte
    {
        private double _solde;

        public double Solde
        {
            get { return _solde; }
            set
            {
                if (value >= -1000)
                {
                    _solde = value;
                }
                else
                {
                    throw new Exception("Découvert insuffisant");
                }
            }
        }


        public bool Deposer(double montant)
        {
            if (montant > 0)
            {
                Solde += montant;
                return true;
            }
            else
                return false;

        }

        public bool Retirer(double montant)
        {
            if (montant >0)
            {
                Solde -= montant;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RetirerFraisDeCarte()
        {
            if (Solde>50)
            {
                Solde -= 50;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
