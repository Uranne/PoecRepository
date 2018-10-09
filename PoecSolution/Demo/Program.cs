using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        /* Exercice
         * Fournir un pseudo à un utilisateur
         * 
         * Déroulement
         * L'utilisateur est invité à saisir son nom, puis son prénom
         * Le programme génère un pseudo à l'aide des deux premiers caractères du nom et des trois premier caractère du prénom
         * (La méthode .Substring() des objets string est votre ami
         * Affichage du pseudo de l'utilisateur à l'aide d'un message "Joe Dalton, votre pseudo est DAJoe
         * */
        #region Jour 1

        static void Exercice1()
        {
            string prenom, nom;
            string shortpre = "";
            string shortnom = "";
            string sortie;
            //Format de la console
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Title = "Ma Console de test du futur";

            Console.WriteLine("Veuillez indiquer votre prénom d'abord.");
            prenom = Console.ReadLine();
            Console.WriteLine("Maintenant votre nom.");
            nom = Console.ReadLine();
            if (nom.Length < 2)
            {
                shortnom = nom;
            }
            else { shortnom = nom.Substring(0, 2); }
            if (prenom.Length < 3)
            {
                shortpre = prenom;
            }
            else { shortpre = prenom.Substring(0, 3); }
            sortie = shortnom.ToUpper() + shortpre;
            if (sortie.Length != 0)
            {
                Clipboard.SetText(sortie);
                Console.WriteLine("{0} {1}, félicitation, votre pseudo est {2}.", prenom, nom, sortie);
                Console.WriteLine("Vous le trouverez dans le presse papier");
            }
            else
            {
                Console.WriteLine("Salut Ulysse, prend un siège, discutons");
            }

        }
        static void Demo1()
        {
            #region Demo1
            ///*Ma première démo*/
            //Console.WriteLine("Hello World");
            //Console.ReadKey();

            //Demo2 
            string strMessage = "Merci de saisir votre nom : ";
            string strChoix = "";
            string strReponse;


            //Message
            Console.WriteLine(strMessage);
            //Saisie nom
            strChoix = Console.ReadLine();
            //Bienvenue
            strReponse = String.Format("Bienvenue {0}, jeune padawan, en ce {1:dd MMMM}."
                , strChoix
                , DateTime.Today);
            Console.WriteLine(strReponse);
            #endregion
        }
        static void Demo2()
        {
            var MaCaisse = new { Cylindree = 1000, Couleur = "Rouge", Prix = "280000" };
            Console.WriteLine(MaCaisse.GetType());
        }
        static void VariableObjet()
        {
            //Exploitation de la classe StringBuilder pour concaténer des chaines
            StringBuilder sbChaine = new StringBuilder();
            sbChaine.AppendLine("Mon premier poème");
            sbChaine.AppendLine("C'est de dev de ma vie");
            Console.WriteLine("Ma chaine {0}à une capacité de {1}.",
                sbChaine.ToString(),
                sbChaine.Capacity);

            //Manipulation de fichiers
            DirectoryInfo di = new DirectoryInfo(@"c:\windows");
            Console.WriteLine("Dans mon dossier {0}, il y a {1} fichiers"
                , di.Name
                , di.GetFiles().Count());

        }
        static void Convertion()
        {
            int intAge;
            string strSaisie;

            Console.Write("Indiquez votre âge : ");
            strSaisie = Console.ReadLine();

            //out : permet de donner le pointeur et non la valeur de la variable
            if (int.TryParse(strSaisie, out intAge))
            {
                Console.WriteLine("Plus que {0} à vivre, vieux croulant", 100 - intAge);
            }
            else
            {
                Console.WriteLine("Saisie incorrecte");
            }

        } 
        #endregion



        [STAThreadAttribute]
        static void Main(string[] args)
        {
            #region Jour 1
            //Demo1();
            //Exercice1();
            //Demo2();
            //VariableObjet();
            //Convertion(); 
            #endregion


        }
    }
}
