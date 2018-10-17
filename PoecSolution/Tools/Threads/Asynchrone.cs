using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tools.Threads
{
    public class Asynchrone
    {
        public async void Lancer()
        {
            Console.WriteLine("Lancement d'une méthode asynchrone sur le point de débuter");

            string tache = await Traitement(FinDesOperations);

            //Console.WriteLine("Résultat asynchrone récupéré : {0}", tache);
        }

        public Task<string> Traitement(Action Rappel)
        {
            return Task.Run(() => { Thread.Sleep(8000);
                Rappel.Invoke();
                return "Tâche terminée"; });
        }

        public void FinDesOperations()
        {
            Console.WriteLine("Opérations terminées");
        }
    }
}
