using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    enum Categories
    {
        Cadres
            ,AgentDeMaitrise
            ,Employe
            ,Externe

    }

    enum Affichages
    {
        Clair,
        Standard,
        Sombre
    }

    enum Conversion
    {
        FtoC,
        CtoF,
        CtoK,
        KtoC,
        KtoF,
        FtoK
    }

    enum TypeResultat
    {
        unEntier, 
        unDouble, 
        unFloat
    }

}
