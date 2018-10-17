using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public class LecteurPartage : ILecteur, IDisposable
    {
        private string _chemin;
        private FileStream flux;

        public LecteurPartage(string chemin)
        {
            Chemin = chemin;
            flux = File.Open(Chemin, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
        }

        public string Chemin
        {
            get
            {
                return _chemin;
            }
            set
            {
                if (File.Exists(value))
                {
                    _chemin = value;
                }
                else
                {
                    throw new FileNotFoundException();
                }
            }
        }

        public string Ajouter()
        {
            string ajout = string.Format("Ligne insérée à {0}\n", DateTime.Now.ToLongTimeString());
            flux.Write(Encoding.ASCII.GetBytes(ajout), 0, ajout.Length);
            flux.Flush();

            return ajout;
        }

        public string Ajouter(string chemin)
        {
            string ajout = string.Format("Ligne insérée à {0}\n", DateTime.Now.ToLongTimeString());
            FileStream fluxTemp = File.Open(chemin, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
            fluxTemp.Write(Encoding.ASCII.GetBytes(ajout), 0, ajout.Length);
            fluxTemp.Flush();
            fluxTemp.Close();


            return ajout;
        }

        public void Dispose()
        {
            flux.Close();
        }

        public string Lire()
        {
            Byte[] ByResultat = new Byte[512];
            flux.Read(ByResultat,0,512).ToString();
            return ByResultat.ToString();
        }

        public string Lire(string chemin)
        {
            FileStream fluxTemp = File.Open(chemin, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
            Byte[] ByResultat = new Byte[512];
            fluxTemp.Read(ByResultat, 0, 512).ToString();
            return ByResultat.ToString();
        }
    }
}
