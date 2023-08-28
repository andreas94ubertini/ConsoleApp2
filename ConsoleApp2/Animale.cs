using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Animale
    {
        public string Razza { get; set; }
        public string Specie { get; set; }
        public string Nome { get; set; }
        public int NumeroZampe { get; set; }

        public string GetDet()
        {
            return Specie + " " + Razza + " " + Nome;
        }
    }
}
