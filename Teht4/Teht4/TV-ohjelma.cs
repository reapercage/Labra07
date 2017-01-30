using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht4
{
    class TV_ohjelma
    {
        private string nimi;
        private string kanava;
        private string alku;
        private string loppu;
        private string info;
        public string Nimi { get { return nimi; } set { nimi = value; } }
        public string Kanava { get; set; }
        public string Alku { get; set; }
        public string Loppu { get; set; }
        public string Info { get; set; }
        public TV_ohjelma()
        {
        }
        public TV_ohjelma(string Nimi, string Kanava) //jne
        {
            //esim. Nimi = nimi;
        }
        public override string ToString()
        {
            //esim.
            return "Nimi: " + Nimi + "\nKanava: " + Kanava;
        }
    }
}
