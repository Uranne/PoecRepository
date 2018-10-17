using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public class Angiologue:Medecin
    {
        public Angiologue():base("Angiologue Quelconque")
        {
            Console.WriteLine("Angiologue");
        }
        public string PratiquerDoppler()
        {
            return "L'angiologue pratique un Doppler";
        }
        public override string Diagnostiquer()
        {
            return "Diagnostique de l'Angiologue : RAS";
        }
        public override string Former()
        {
            return "L'angiologue donne un cours d'angiologie";
        }
    }
}
