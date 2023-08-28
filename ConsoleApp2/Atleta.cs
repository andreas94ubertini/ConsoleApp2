using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Atleta
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Anni { get; set; }
        public string Sport { get; set; }
        public string Nazionalita { get; set; }
        public string Ruolo { get; set; }
        public string FullName
        {
            get
            {
                return Nome + " " + Cognome;
            }
        }

        public string GetDet()
        {
            return FullName + " " + Nazionalita+ " " + Sport;
        }
    }
}
