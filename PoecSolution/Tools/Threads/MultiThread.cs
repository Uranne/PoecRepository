using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tools.Threads
{
    public class MultiThread
    {
        public void Lancer()
        {
            Task<string> tacheA = new Task<string>(() => {return Traitement("TacheA"); });
            Task<string> tacheB = new Task<string>(() => {return Traitement("TacheB"); });
            Task<string> tacheC = new Task<string>(() => {return Traitement("TacheC"); });
            List<Task<string>> lstTaches = new List<Task<string>>() { tacheA, tacheB, tacheC };
            foreach (Task t in lstTaches)
            {
                t.Start();
                Thread.Sleep(200);
            }
            while (lstTaches.Count>0)
            {
                int intTache = Task.WaitAny(lstTaches.ToArray<Task>(), 30000);

                string strResultat = lstTaches[intTache].Result;

                Console.WriteLine(strResultat);

                lstTaches.RemoveAt(intTache);
            }
        }

        private string Traitement(string Nom)
        {
            for (int i = 0; i < 4; i++)
            {
                int intAttente = ((new Random()).Next(2, 7)) * 1000;
                Thread.Sleep(intAttente);
                Console.WriteLine("Traitement {1} achevé après {0} secondes", intAttente / 1000, Nom);
            }
            return string.Format("{0} s'est terminée", Nom);
        }
    }
}
