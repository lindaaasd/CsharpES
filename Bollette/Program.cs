using System;
using Bollette.Entities;
using System.Collections;

namespace Bollette
{
    class Program
    {
        static void Main(string[] args)
        {
            //Utente utente = new Utente()
            //{
            //    Codice = "ABCD123",
            //    Nome = "Mario",
            //    Cognome = "Rossi",
            //    DataNascita = new DateTime(1999, 4, 6),
            //};

            //Bolletta bolletta = new Bolletta()
            //{
            //    ConsumoTotale = 200,
            //    TipoBolletta = "Telefono",
            //    UnitaDiMisura = "Minuti",
            //    DataScadenza = new DateTime(2022, 3, 9),
            //};

            //Console.WriteLine("Consumo bolletta "+ bolletta.ConsumoTotale);
            Console.WriteLine("bolletta");



            Console.WriteLine("inserisci codice");
            string codice = Console.ReadLine();

            Console.WriteLine("inserisci nome");
            string nome = Console.ReadLine();

            Console.WriteLine("inserisci cognome");
            string cognome = Console.ReadLine();

            Console.WriteLine("inserisci data di nascita (dd/MM/yyyy");
            DateTime.TryParse(Console.ReadLine(), out DateTime dataNascita);

            Utente utente = new Utente()
            {
                Codice = codice,
                Nome = nome,
                Cognome = cognome,
                DataNascita = dataNascita,

            };

            // Array
            Utente[] utenti = new Utente[] { utente };
            // ArrayList
            ArrayList tantiUtenti = new ArrayList();
            tantiUtenti.Add(utente);
        }


    }
}

