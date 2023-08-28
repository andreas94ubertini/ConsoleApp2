using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Dipendente
    {

        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Ruolo { get; set; }
        private double _stipendio;

        public double Stipendio
        {
            get { return _stipendio; }
            set { _stipendio = value; }
        }

        public string GetDet()
        { 
                return Nome + " " + Cognome+ " " + Ruolo;            
        }

    }
    
}
