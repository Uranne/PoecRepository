using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public class LaTrieuse
    {
        public static T[] Retourner<T>(T[] tableau)
        {
            T[] retour = new T[tableau.Length];
            for (int i = 0; i < tableau.Length; i++)
            {
                retour[tableau.Length - 1 - i] = tableau[i];
            }
            return retour;
        }
    }
}
