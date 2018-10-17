using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class vehicule
    {
        //constructeur par défaut
        public vehicule() {Vitesse = 1; }
        //contructeur avec initialisation de la vitesse 
        public vehicule(double vitesse)
        {
            Vitesse = vitesse;
        }

        private double _vitesse;
        //Propriété
        public double Vitesse
        {
            get { return _vitesse; }
            set {
                if (value>=0)
                {
                    _vitesse = value;
                }
                else
                {
                    throw new VehiculeException();
                }
               
            }
        }

        //Méthode
        public double Accelerer()
        {
            Vitesse += 5;
            return Vitesse;
        }
        public double Accelerer(double increment)
        {
            Vitesse += increment;
            return Vitesse;
        }

        public static string GetPrefectureUrl()
        {
            return @"http://www.prefecturedurhone69.fr";
        }
    }
}
