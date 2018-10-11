using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Demonstration
    {
        static readonly string lorem = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur in congue eros. Fusce hendrerit risus ante, quis consequat neque aliquam commodo. Etiam vel congue nisi, eget sagittis augue. Nam volutpat urna eu condimentum iaculis. Morbi aliquet lacinia ante sed tempor. ";
        #region Module 1

        #region Jour 1

        internal void Demo10()
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
        internal void Demo11()
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
        internal void Demo12()
        {
            var MaCaisse = new { Cylindree = 1000, Couleur = "Rouge", Prix = "280000" };
            Console.WriteLine(MaCaisse.GetType());
        }
        internal void Demo13()
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
        internal void Demo14()
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
        internal void Demo20()
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
        internal void Demo21()
        {
            /*En récupérant le nbre de fichiers présents dans le chemin saisi par l'utilisateur
             * On affichera le type de dossier en fonction du tableau suivant :
             * +de 200 fichiers : denses
             * +de 100 fichiers : Occupé
             * +de 50 fichiers : Léger
             * +de 10 fichiers : Sous-occupé
             * -de 11 fichiers : Négligeable
             * */
            String Path = @"C:\";
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
        internal void Demo22()
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
        internal void Demo23()
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
        internal void Demo24()
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
        internal void Demo25()
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
        internal void Demo26()
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
        #region Jour 3

        internal void Demo30()
        {
            DirectoryInfo c = new DirectoryInfo(@"C:\windows\");
            foreach (FileInfo f in c.GetFiles())
            {
                //Console.WriteLine("Fichier {0} présent dans ce dossier.", f.LastWriteTime);
                if (f.Length > 20000)
                {
                    Console.WriteLine(f.Name);
                }
            }
        }
        internal void Demo31()
        {
            /*
             * Parcourir les disks de la machine et afficher leur type
             * ainsi que leur capacité totale et l'espace dispnible si différent de 0
             * DriveInfo is your friend
             * */

            foreach (DriveInfo d in DriveInfo.GetDrives())
            {
                if (d.TotalFreeSpace != 0)
                {
                    Console.WriteLine("Le disque {0} à une capacité disponible de {1} sur {2} et est de type {3}.",
                        d.Name, d.TotalFreeSpace.ToString(), d.TotalSize.ToString(), d.DriveType.ToString());
                }
                //Console.WriteLine(d.Name);
            }
        }
        internal void Demo32()
        {
            //tableau de chaine
            //string[] strModeles = new string[10];
            string[] strModeles = { "plop", "plip", "vlan", "paf" };
            Console.WriteLine("La variable strModeles {0} éléments", strModeles.Length);
            //strModeles[4] = "polo";
            // strModeles[9] = "punto";
            foreach (var item in strModeles)
            {
                Console.WriteLine(item);
            }
        }
        #endregion

        #endregion
        #region J3suite

        internal void Demo40()
        {
            //lol
            Afficher("plop, en version standard", Affichages.Standard);
            Afficher("plop, en version sombre", Affichages.Sombre);
            Afficher("plop, en version clair", Affichages.Clair);
            Console.WriteLine("retour à l'affichage normal");
        }
        internal void Demo41()
        {
            /*Créer une métode init console qui attend un style de type affichage 
             * puis change les couleurs en fonction du style
             * et vide la console de son contenu actuel
             * et affiche le texte "Console initialisé le DATE à HEURE"
             * 
             * Depuis Main Afficher plusieurs textes, attendre une frappe utilisateur, Initialiser
             * Afficher d'autre textes, Attendre une frappe, Initialiser
             * */
            Console.WriteLine(lorem);
            Console.ReadKey();
            InitConsole(Affichages.Clair);
            Console.ReadKey();
            Console.WriteLine(lorem);
            Console.ReadKey();
            InitConsole(Affichages.Sombre);
        }
        internal void Demo42()
        {
            Console.WriteLine("Saisir une température en Celsius");
            double tempe;
            while (!double.TryParse(Console.ReadLine(), out tempe)) ;
            Console.WriteLine("Pour {0}° celsius, on obtient {1}° Fahrenheit", tempe, ConvertirTemperature(tempe, Conversion.CtoF));

        }
        internal void Demo43()
        {
            /*
             * Créer une méthode saisirnumeric qui garantie que l'utilisateur devra saisir
             * tant que le type attendu n'est pas correct et retourne un double
             * (un vide doit être concidéré comme un abandon 
             * -1 pour num,
             * chaine vide pour les chaines
             * */
            Console.WriteLine("Saisie double : " + SaisirNumeric(TypeResultat.unDouble));
            Console.WriteLine("Saisie int : " + SaisirNumeric(TypeResultat.unEntier));
            Console.WriteLine("Saisie float : " + SaisirNumeric(TypeResultat.unFloat));
        }
        internal void Demo44()
        {
            Stagiaire stParticipant = new Stagiaire();
            stParticipant.Observer();
            stParticipant.Travailler();
            stParticipant.Travailler();
            stParticipant.Travailler();
            stParticipant.Travailler(40, DayOfWeek.Sunday);
            stParticipant.Travailler(40);
            Console.WriteLine(stParticipant.Points);
        }
        internal void Demo45()
        {
            Console.WriteLine("Moyenne(7, 40, 20, 54, 35, 89, 12)");
            Console.WriteLine(Moyenne(7, 40, 20, 54, 35, 89, 12));
        }
        #endregion

        #region Mes Méthodes

        internal void ChangerStyle(Affichages style)
        {
            //Peut être extrait de la méthode vers une nouvelle méthode en faisant clic droit, refactoring
            //Ctrl + ; : permet de retoucher le code et met à jour toute les implications.
            switch (style)
            {
                case Affichages.Clair:
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
                case Affichages.Standard:
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case Affichages.Sombre:
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                default:
                    break;
            }
        }
        internal void Afficher(string message, Affichages style)
        {
            ChangerStyle(style);
            Console.WriteLine(message);
            Console.ResetColor();
        }
        internal void InitConsole(Affichages style)
        {
            ChangerStyle(style);
            Console.Clear();
            Console.WriteLine("Console initialisé le {0} à {1}", DateTime.Today.ToShortDateString(), DateTime.Now.ToShortTimeString());
        }
        internal double ConvertirTemperature(double temperatureOriginale, Conversion choixConvertion)
        {
            double temperatureConvertie = temperatureOriginale;
            switch (choixConvertion)
            {
                case Conversion.FtoC:
                    temperatureConvertie = temperatureOriginale * 5 / 9 - 32;
                    break;
                case Conversion.CtoF:
                    temperatureConvertie = (temperatureOriginale * 9 / 5) + 32;
                    break;
                case Conversion.CtoK:
                    break;
                case Conversion.KtoC:
                    break;
                case Conversion.KtoF:
                    break;
                case Conversion.FtoK:
                    break;
                default:
                    break;
            }
            return temperatureConvertie;
        }
        internal double SaisirNumeric(TypeResultat t)
        {
            string sortie;
            bool ok = false;
            double retour = -1;

            do
            {
                sortie = Console.ReadLine();
                if (sortie != "")
                {
                    switch (t)
                    {
                        case TypeResultat.unEntier:
                            int mid;
                            if (int.TryParse(sortie, out mid))
                            {

                                retour = mid;
                                ok = true;
                            }
                            break;
                        case TypeResultat.unDouble:
                            if (double.TryParse(sortie, out retour))
                            {
                                ok = true;
                            }
                            break;
                        case TypeResultat.unFloat:
                            float midF;
                            if (float.TryParse(sortie, out midF))
                            {
                                retour = midF;
                                ok = true;
                            }
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    retour = -1;
                    ok = true;
                }
                if (!ok) { Console.WriteLine("La valeur retourné ne convient pas."); }
            } while (!ok);
            return retour;
        }
        private double Moyenne(double ponderation, params double[] notes )
        {
            double cumul = 0;
            foreach (double d in notes)
            {
                cumul += d;
            }

            return (ponderation+cumul)/notes.Count();
        }
    }

    #endregion
}
