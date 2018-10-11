using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        [STAThreadAttribute]
        static void Main(string[] args)
        {
            MenuDemo();

        }

        private static void MenuDemo()
        {
            int intCode;
            Demonstration demo = new Demonstration();
            
            MethodInfo m;

            do
            {
                m = Menub();

                if (m != null)
                {
                    Console.Clear();
                    m.Invoke(demo, null);
                }

                Console.WriteLine();
                Console.WriteLine("Appuyez sur une touche...");
                Console.ReadLine();

            } while (m != null);


            Console.Clear();
            Console.WriteLine("A bientôt");
        }

        private static void MenuDemoVersionDegueu()
        {
            string reponse = "";
            int intReponse;
            bool saisieCorrect = false;
            Demonstration d = new Demonstration();
            do
            {
                Console.WriteLine("Veuillez saisir un chiffre correspondant au module à executer : ");
                reponse = Console.ReadLine();
                if (int.TryParse(reponse, out intReponse))
                {
                    saisieCorrect = true;
                    reponse = "Demo" + intReponse;
                }
            } while (reponse != "q" && !saisieCorrect);
            if (reponse == "q")
            {
                Console.WriteLine("Au revoir");
            }
            else
            {
                switch (reponse)
                {
                    case "Demo10":
                        d.Demo10();
                        break;
                    case "Demo11":
                        d.Demo11();
                        break;
                    case "Demo12":
                        d.Demo12();
                        break;
                    case "Demo13":
                        d.Demo13();
                        break;
                    case "Demo14":
                        d.Demo14();
                        break;
                    case "Demo20":
                        d.Demo20();
                        break;
                    case "Demo21":
                        d.Demo21();
                        break;
                    case "Demo22":
                        d.Demo22();
                        break;
                    case "Demo23":
                        d.Demo23();
                        break;
                    case "Demo24":
                        d.Demo24();
                        break;
                    case "Demo25":
                        d.Demo25();
                        break;
                    case "Demo26":
                        d.Demo26();
                        break;
                    case "Demo30":
                        d.Demo30();
                        break;
                    case "Demo31":
                        d.Demo31();
                        break;
                    case "Demo32":
                        d.Demo32();
                        break;
                    case "Demo40":
                        d.Demo40();
                        break;
                    case "Demo41":
                        d.Demo41();
                        break;
                    case "Demo42":
                        d.Demo42();
                        break;
                    case "Demo43":
                        d.Demo43();
                        break;
                    case "Demo44":
                        d.Demo44();
                        break;
                    default:
                        Console.WriteLine("La méthode demandé n'existe pas.");
                        MenuDemo();
                        break;
                }
            }

        }

        private static MethodInfo Menub()
        {
            int intCpt = 0;
            int intChoix;


            //
            MethodInfo[] methodInfos = Type.GetType("Demo.Demonstration")
                           .GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);
            //Utilisation de méthodes Linq OrderBy Then,By
            foreach (var item in methodInfos.OrderBy(m => m.Name.Length).ThenBy(m => m.Name))
            {
                intCpt++;
                Console.WriteLine("{0}{1}{2}"
                    , item.Name
                    , new String('.', 30 - item.Name.ToString().Length)
                    , intCpt
                    );
            }

            while (!int.TryParse(Console.ReadLine(), out intChoix) && intChoix < 1 && intChoix > intCpt) { }

            return (intChoix != 0) ? methodInfos[intChoix - 1] : null;

        }
    }
}

