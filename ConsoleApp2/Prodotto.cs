using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Prodotto
    {
        public string Nome { get; set; }
        public double Prezzo { get; set; }
        public int Quantita { get; set; }
        public string getDetails
        {
            get
                { return Nome + " " + Prezzo + " " + Quantita; }
        }

        public double GetPrice()
        {
            return Prezzo * Quantita;
        }
    }
}
