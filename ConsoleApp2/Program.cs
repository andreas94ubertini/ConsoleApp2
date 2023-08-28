using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dipendente dipendente = new Dipendente();
            dipendente.Nome = "Andreas";
            dipendente.Cognome = "Ubertini";
            dipendente.Ruolo = "Web developer";
            Dipendente dipendente2 = new Dipendente();
            dipendente2.Nome = "Mario";
            dipendente2.Cognome = "Rossi";
            dipendente2.Ruolo = "Ceo";
            Dipendente dipendente3 = new Dipendente();
            dipendente3.Nome = "Marco";
            dipendente3.Cognome = "Verdi";
            dipendente3.Ruolo = "Barman";
            Studente studente = new Studente();
            studente.Nome = "Andreas";
            studente.Cognome = "Ubertini";
            studente.Eta = 29;
            studente.MateriaPreferita = "Italiano";
            Studente studente2 = new Studente();
            studente2.Nome = "Mario";
            studente2.Cognome = "Rossi";
            studente2.Eta = 27;
            studente2.MateriaPreferita = "Matematica";
            Studente studente3 = new Studente();
            studente3.Nome = "Maria";
            studente3.Cognome = "Bianchi";
            studente3.Eta = 25;
            studente3.MateriaPreferita = "Storia";
            Animale animale = new Animale();
            animale.Specie = "Cane";
            animale.Razza = "Labrador";
            animale.Nome = "Fuffi";
            animale.NumeroZampe = 4;
            Animale animale2 = new Animale();
            animale2.Specie = "Gatto";
            animale2.Razza = "Persiano";
            animale2.Nome = "Ciccio";
            animale2.NumeroZampe = 4;
            Animale animale3 = new Animale();
            animale3.Specie = "Topo";
            animale3.Razza = "Topo Domestico";
            animale3.Nome = "Ratto";
            animale3.NumeroZampe = 4;
            Atleta atleta = new Atleta();
            atleta.Nome = "Francesco";
            atleta.Cognome = "Totti";
            atleta.Anni = 45;
            atleta.Sport = "Calcio";
            atleta.Ruolo = "Attaccante";
            Atleta atleta2 = new Atleta();
            atleta2.Nome = "Lebron";
            atleta2.Cognome = "James";
            atleta2.Anni = 38;
            atleta2.Sport = "Basket";
            atleta2.Ruolo = "Ala";
            Atleta atleta3 = new Atleta();
            atleta3.Nome = "Valentino";
            atleta3.Cognome = "Rossi";
            atleta3.Anni = 42;
            atleta3.Sport = "MotoGp";
            atleta3.Ruolo = "Pilota";
            Prodotto prodotto = new Prodotto();
            prodotto.Nome = "Playstation 5";
            prodotto.Prezzo = 500.00;
            prodotto.Quantita = 2;
            Prodotto prodotto2 = new Prodotto();
            prodotto2.Nome = "Iphone 14";
            prodotto2.Prezzo = 799.00;
            prodotto2.Quantita = 3;
            Prodotto prodotto3 = new Prodotto();
            prodotto3.Nome = "Nvidia RTX 4090";
            prodotto3.Prezzo = 1850.50;
            prodotto3.Quantita = 5;

            Console.WriteLine("Dipendente 1- " + dipendente.GetDet());
            Console.WriteLine("Dipendente 2- " + dipendente2.GetDet());
            Console.WriteLine("Dipendente 3- " + dipendente3.GetDet());
            Console.WriteLine("Studente 1- " + studente.GetDet());
            Console.WriteLine("Studente 2- " + studente2.GetDet());
            Console.WriteLine("Studente 3- " + studente3.GetDet());
            Console.WriteLine("Animale 1- " + animale.GetDet());
            Console.WriteLine("Animale 2- " + animale2.GetDet());
            Console.WriteLine("Animale 3- " + animale3.GetDet());
            Console.WriteLine("Atleta 1- " + atleta.GetDet());
            Console.WriteLine("Atleta 2- " + atleta2.GetDet());
            Console.WriteLine("Atleta 3- " + atleta3.GetDet());
            Console.WriteLine("Prodotto 1- " + prodotto.getDetails  + prodotto.GetPrice() + " euro");
            Console.WriteLine("Prodotto 2- " + prodotto2.getDetails + prodotto2.GetPrice() + " euro");
            Console.WriteLine("Prodotto 3- " + prodotto3.getDetails + prodotto3.GetPrice() + " euro");

            Console.ReadLine();

        }
    }
}
