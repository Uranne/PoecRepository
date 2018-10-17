using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public abstract class Medecin
    {
        public Medecin(string quidonc)
        {
            Console.WriteLine("Médecin {0} initialisé", quidonc);
        }
        public virtual string Diagnostiquer()
        {
            return "Diagnostique du médecin : RAS";
        }
        public string Ausculter()
        {
            return "Auscultation du médecin en cours";
        }
        public string Orienter(string confrere)
        {
            return "le médecin vous oriente vers le docteur " + confrere;
        }
        public string Prescrire(params string[] medocs)
        {
            StringBuilder sbMedocs = new StringBuilder();
            sbMedocs.AppendLine("Le médecin vous prescrit : ");
            foreach (string item in medocs)
            {
                sbMedocs.AppendLine(item);
            }
            return sbMedocs.ToString();
        }
        public string Facture(double montant)
        {
            return string.Format("Vous devez régler la somme de {0:N2} au médecin", montant);
        }

        public abstract string Former();
    }
}
