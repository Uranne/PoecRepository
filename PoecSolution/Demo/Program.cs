using System;
using System.Collections.Generic;
using System.IO;
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
                //Clipboard.SetText(sortie);
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

        #region Jour 2
        static void Ifstatment()
        {
            //après saisie de l'age et du nombre de trimestre déjà acquis
            //Indiquer si la personne peut prendre sa retraite (+ de 62 ans et 172 trimestre)
            //ou peut-etre faudra t'il attendre (moins de 62 ans)
            //ou travailler (moins de 172 trimestre)
            int age, nbreTrimestre;
            String sAge, sNbreTri;
            String result;
            do
            {
                Console.WriteLine("Saisissez votre age : ");
                sAge = Console.ReadLine();
            } while (!int.TryParse(sAge, out age));

            do
            {
                Console.WriteLine("Saisissez votre nombre de trimestre travaillé : ");
                sNbreTri = Console.ReadLine();
            } while (!int.TryParse(sNbreTri, out nbreTrimestre));

            if (age > 61 && nbreTrimestre > 171)
            {
                result = "Félicitation, profitez bien de votre retraite";
            }
            else
            {
                result = "Dommage \n";
                if (nbreTrimestre < 172)
                {
                    result += "Il vous manque encore " + (172 - nbreTrimestre) + " trimestres.\n";
                }
                if (age < 62)
                {
                    result += "Il vous manque encore " + (62 - age) + " années.\n";
                }
                Console.WriteLine(result);
            }


        }
        static void Exercice2(String Path = @"C:\")
        {
            /*En récupérant le nbre de fichiers présents dans le chemin saisi par l'utilisateur
             * On affichera le type de dossier en fonction du tableau suivant :
             * +de 200 fichiers : denses
             * +de 100 fichiers : Occupé
             * +de 50 fichiers : Léger
             * +de 10 fichiers : Sous-occupé
             * -de 11 fichiers : Négligeable
             * */
            String Category;
            DirectoryInfo di = new DirectoryInfo(Path);
            if (!di.Exists)
            {
                Console.WriteLine("Le dossier cherché n'existe pas.");
            }
            else
            {
                if (di.GetFiles().Count() > 200)
                {
                    Category = "Dense";
                }
                else if (di.GetFiles().Count() > 100)
                {
                    Category = "Occupé";
                }
                else if (di.GetFiles().Count() > 50)
                {
                    Category = "Léger";
                }
                else if (di.GetFiles().Count() >= 10)
                {
                    Category = "Sous-Occupé";
                }
                else
                {
                    Category = "Négligeable";
                }
                Console.WriteLine("Le répertoire {0}, composé de {1} fichiers est concidéré comme {2}", Path, di.GetFiles().Count(), Category);
            }



        }
        static void SwitchFunction()
        {
            string reponse;
            int intCat;
            do
            {
                Console.WriteLine("Saisir la catégorie (0, 1, 2, 3) (-1 pour quitter)");
                reponse = Console.ReadLine();
                if (int.TryParse(reponse, out intCat))
                {
                    switch ((Categories)intCat)
                    {
                        case Categories.Cadres:
                            Console.WriteLine("La catégorie a ne vous permet pas d'accéder au niveau supérieur.");
                            break;
                        case Categories.AgentDeMaitrise:
                            Console.WriteLine("La catégorie b ne vous permet que d'accéder au niveau 2.");
                            break;
                        case Categories.Employe:
                            Console.WriteLine("La catégorie c vous permet l'inimaginable, d'ailleurs on l'a pas imaginé.");
                            break;
                        case Categories.Externe:
                            Console.WriteLine("Trouver un truc à afficher");
                            break;
                        default:
                            Console.WriteLine("Il me semblait bien que vous étiez hors catégorie.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Veuillez entrer un chiffre");
                }

            } while (intCat != -1);
        }
        static void Boucle()
        {
            StringBuilder s = new StringBuilder();
            for (int i = 270; i > 1; i--)
            {
                s.Append(char.ConvertFromUtf32(65 + i));
            }
            Console.WriteLine(s);
            s.Clear();
            for (char i = 'a'; i <= 'z'; i++)
            {
                s.Append(i);
            }
            Console.WriteLine(s);
        }
        static void ExerciceBoucle()
        {
            /*demander le chemin d'un nouveau à créer sur c:\
             * Exploiter la classe directory.exists
             * pour vérifier qu'il n'existe pas déjà
             * créer le dossier à l'aide de la classe directory
             * créer dans le nouveau dossier 10 fichiers nommé fichier1.txt à fichier10.txt
             * 
             * */
            string rep;
            Console.WriteLine(@"Donner le nom du dossier à créer dans ""C:\""");
            rep = Console.ReadLine();
            if (!Directory.Exists(@"C:\" + rep))
            {
                Directory.CreateDirectory(@"C:\" + rep);
                for (int i = 0; i < 10; i++)
                {
                    StreamWriter flux = File.CreateText(@"C:\" + rep + @"\fichier" + (i + 1) + ".txt");
                    flux.Dispose();
                }
                Console.ReadKey();
                Directory.Delete(@"C:\" + rep, true);
            }
            else
                Console.WriteLine("Votre dossier existe déjà");

        }
        static void ExerciceWhile()
        {
            /*
             * Faire saisir autant de fois que nécessaire jusqu'à obtention d'un nbre
             * */

            int nbre;
            do
            {
                Console.WriteLine("Veuillez saisir un nombre.");
            } while (!int.TryParse(Console.ReadLine(), out nbre));

            Console.WriteLine("C'est bien, vous êtes docile.");
        }
        static void JeuNbreSecret()
        {
            // définir secret
            int secret, compteur, choix, max;
            string saisie;
            Random r = new Random();

            // Définir un compteur
            compteur = 0;
            //Définir un Message
            do
            {
                Console.WriteLine("Définir la valeur maximum du secret.");
            } while (!int.TryParse(Console.ReadLine(), out max));
            string message = "Veuillez choisir un nombre entre 1 et " + max + " (0 pour sortir)";
            secret = r.Next(1, max);
            //Récupérer choix
            do
            {
                Console.WriteLine(message);
                saisie = Console.ReadLine();
                if (saisie.Length > secret.ToString().Length)
                {
                    message = "Attention, n'écrivez pas un nombre trop grand";
                    choix = 5;
                }
                else
                {
                    int.TryParse(saisie, out choix);
                    if (choix > secret)
                    {
                        message = "Veuillez choisir un nombre plus petit (0 pour sortir)";
                        compteur++;
                    }
                    else if (choix == 0)
                    {
                        message = "Vous avez abandonné en " + compteur + " essais. Tant pis !";
                    }
                    else if (choix < secret)
                    {
                        message = "Veuillez choisir un nombre plus grand (0 pour sortir)";
                        compteur++;
                    }
                    else
                    {
                        compteur++;
                        message = "Bien joué, vous avez gagné en " + compteur + " essais. Trop bien !";
                        choix = 0;
                    }
                    // message = (Choix>secret)?"Choisir plus petit":"Choisir plus grand";
                }
            } while (choix != 0);
            Console.WriteLine(message);
            //Incrémenter compteur

            //Conditionnnement de la suite
            //-> CHoisir plus petit
            //-> Choisir plus grand
            //-> Bien joué

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

            #region Jour 2
            //Ifstatment();
            //Exercice2(@"C:\Windows\System32\");
            //SwitchFunction();
            //Boucle();
            //ExerciceBoucle();
            //ExerciceWhile();
            //JeuNbreSecret();
            #endregion
            

        }
    }
}
