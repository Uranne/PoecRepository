using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public class Neurologue : Medecin
    {
        public Neurologue():base("Neurologue quelconque")
        {
            Console.WriteLine("Neurologue");
        }

        public string PratiquerEMG()
        {
            return "Le neurologue pratique un EMG";
        }
        public override string Diagnostiquer()
        {
            return "Le neurologue fait un diagnostique : RAS";
        }
        public override string Former()
        {
            return "Le neurologue donne un cours de neurologie";
        }
    }
}
