using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testEF
{
    public class Etudiant
    {
        public int id { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public List<Etudiant> amis { get; set; }
        public string image { get; set; }
        public Etudiant(string n, string m)
        {
            this.nom = n;
            this.prenom = m;
            amis = new List<Etudiant>();
        }
        public Etudiant() { }
        public void addAmis(Etudiant e)
        {
            this.amis.Add(e);
        }
        public string print()
        {
            return this.nom + " " + this.prenom + "\n";
        }
    }
}
