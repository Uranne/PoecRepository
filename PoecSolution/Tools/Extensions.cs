using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public static class Extensions
    {
        public static string GetChaine(this StringBuilder sb)
        {
            return sb.ToString();

        }
        public static bool MettreEnMajuscules(this StringBuilder sb)
        {
            string CHAINE = sb.ToString().ToUpper();
            sb.Clear();
            sb.Append(CHAINE);
            return true;
        }
    }
}
