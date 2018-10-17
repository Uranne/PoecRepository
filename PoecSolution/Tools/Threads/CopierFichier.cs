using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.Threads
{
    public class CopierFichier
    {
        public void Lancer(string archive, params string[] chemin)
        {
            List<Task<string>> lstTable = new List<Task<string>>();
            foreach (string c in chemin)
            {
                Console.WriteLine("Lancement des procédures de copies de fichiers depuis {0}", c);
                Task<string> tacheA = new Task<string>(() => { return Traitement(c, archive); });
                tacheA.Start();
                lstTable.Add(tacheA);
            }
            while (lstTable.Count > 0)
            {
                int intTache = Task.WaitAny(lstTable.ToArray<Task>());

                string strResultat = lstTable[intTache].Result;

                Console.WriteLine(strResultat);

                lstTable.RemoveAt(intTache);
            }
        }

        public string Traitement(string chemin, string archive)
        {
            DirectoryInfo di = new DirectoryInfo(chemin);
            int compte = di.GetFiles().Count();
            Copy(chemin, archive);
            return string.Format("Copie terminé, {0} fichiers ont été copiés depuis {1}", compte, chemin);
        }

        public void Copy(string source, string target)
        {
            Directory.CreateDirectory(Path.Combine(target, Path.GetFileName(source)));
            foreach (string file in Directory.GetFiles(source))
                File.Copy(file, Path.Combine(target, Path.GetFileName(file)));
            
            foreach (string directory in Directory.GetDirectories(source))
                Copy(directory, Path.Combine(target, Path.GetFileName(directory)));
            
        }
    }
}
