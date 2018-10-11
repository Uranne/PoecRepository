using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Stagiaire
    {
        internal int Points;

        internal void Observer()
        {
            Console.WriteLine("Observation");
        }

        internal int Travailler()
        {
            Points += 10;
            return 10;
        }

        internal int Travailler(int nbpoints)
        {
            Points += nbpoints;
            return nbpoints;
        }

        internal int Travailler(int nbpoints, DayOfWeek jour)
        {
            if (jour==DayOfWeek.Saturday || jour ==DayOfWeek.Sunday)
            {
                Points += nbpoints * 2;
            }
            else
            {
                Points += nbpoints;
            }
            return nbpoints;
        }
    }
}
