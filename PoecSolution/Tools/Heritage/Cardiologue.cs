using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public class Cardiologue:Medecin
    {
        public Cardiologue():base("Cardiologue Quelconque")
        {
            Console.WriteLine("Cardiologue");
        }

        public string PratiquerEC()
        {
            return "Le cardiologue pratique un EC";
        }

        public override string Diagnostiquer()
        {
            return "Diagnostique du Cardiologue : RAS";
        }
        public override string Former()
        {
            return "Le cardiologue donne un cours de cardiologie";
        }
    }
}
