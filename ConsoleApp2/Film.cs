using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Film
    {
        public string Titolo { get; set; }
        public string Regista { get; set; }
        public int Anno { get; set; }
        public string Genere { get; set; }

        public string GetDet()
        {
            return Titolo + " " + Anno + " " + Genere + " " + Regista;
        }
    }
}
