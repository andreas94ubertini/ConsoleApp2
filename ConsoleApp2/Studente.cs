using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Studente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Eta { get; set; }
        public string MateriaPreferita { get; set; }
        public string GetDet()
        {
            return Nome + " " + Cognome + " " + Eta + " " + MateriaPreferita;
        }
    }
}
