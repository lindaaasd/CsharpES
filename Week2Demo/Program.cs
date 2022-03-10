//In una copisteria il costo unitario delle fotocopie varia a seconda
//del numero da effettuare secondo quest suddivisione:
//• Tra 1 - 19 fotocopie 0,10€
//• Tra 20 - 100 fotocopie 0,08€
//• Maggiore di 100 fotocopie 0,05€
//Inoltre se le fotocopie sono da rilegare viene aggiunto un costo di
//1,80€.
//Scrivere un programma che:
//prenda in input il numero di fotocopie da effettuare, il nome
//del
//cliente e se la rilegatura deve essere effettuata o meno

//Scrivere un programma che:
//• Calcoli il prezzo totale
//• Stampi il sequente prospetto:
//«Gentile Sig.
//il suo preventivo è di
//€
//compreso la rilegatura»
//N.B l'ultima riga è da scrivere solo se è richiesta la rilegatura.

using System;

namespace Week2Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome ="", cognome ="";
            int numeroFotocopie = 0;
            string rilegatura ="";
            decimal costoTotaleFotocopie;
            int scelta;
            do
            {
                PrintMenu();
                scelta = VerificaInputIntero();

                switch (scelta)
                {
                    case 0:
                        Console.WriteLine("Arrivederci");
                        break;
                    case 1:
                        Console.WriteLine("Inserisci i tuoi dati");
                        nome = InsertData("nome");
                        cognome = InsertData("cognome");
                        break;
                    case 2:
                        Console.WriteLine("** Prezzi delle fotocopie **");
                        PrintPrezziFotocopie();
                        break;
                    case 3:
                        Console.WriteLine("Inserisci numero fotocopie");
                        numeroFotocopie = VerificaInputIntero();
                        break;
                    case 4:
                        Console.WriteLine("Inserisci se ti serve la rilegatura");
                        rilegatura = Console.ReadLine();
                        break;
                    case 5:
                        Console.WriteLine("** Costo Totale **");
                        costoTotaleFotocopie = CalcolaCostoTotale(numeroFotocopie, rilegatura);
                        PrintTotale(nome, cognome, costoTotaleFotocopie, rilegatura);
                        break;
                    default:
                        Console.WriteLine("Non hai fatto la scelta giusta, riprova");
                        break;

                }
            } while (scelta != 0);

        }

        public static void PrintMenu()
        {
            Console.WriteLine("** COPISTERIA **");
            Console.WriteLine("1. Inserisci i tuoi dati (nome e cognome)");
            Console.WriteLine("2. Visualizzare i prezzi delle fotocopie");
            Console.WriteLine("3. Inserisci numero fotocopie");
            Console.WriteLine("4. Inserisci rilegatura Sì/No");
            Console.WriteLine("5. Stampa Totale");
            Console.WriteLine("0. Esci");

        }

        public static string InsertData (string dato)
        {
            Console.WriteLine($"Inserisci {dato} -> ");
            string info = Console.ReadLine();
            return info;
        }

        public static void PrintPrezziFotocopie()
        {
            Console.WriteLine("Questi sono i costi delle fotocopie");
            Console.WriteLine("Tra 1 - 19 fotocopie 0,10€");
            Console.WriteLine("Tra 20 - 100 fotocopie 0,08€");
            Console.WriteLine("Maggiore di 100 fotocopie 0,05€");
        }

        //Esegui l'acquisto

        public static decimal CalcolaCostoTotale(int numeroFotocopie, string chiedeRilegatura)
        {
            decimal prezzoIndividualeFotocopie;
            if (numeroFotocopie >= 1 && numeroFotocopie <= 19)
            {
                prezzoIndividualeFotocopie = 0.10m;
            } else if (numeroFotocopie >= 20 && numeroFotocopie <= 100)
            {
                prezzoIndividualeFotocopie = 0.08m;
            } else
            {
                prezzoIndividualeFotocopie = 0.05m;
            }

            decimal costoTotaleFotocopie = numeroFotocopie * prezzoIndividualeFotocopie;

  

            if (chiedeRilegatura.ToLower() == "sì")
            {
                costoTotaleFotocopie += 0.80m; 
            }

            return costoTotaleFotocopie;
        }

        //public static decimal SceltaServizioRilegatura(decimal rilegatura)
        //{
        //    //Inoltre se le fotocopie sono da rilegare viene aggiunto un costo di
        //    //1,80€.

        //    //if ("Si")
        //    //{
        //    //    rilegatura;
        //    //} else
        //    //{
        //    //    !rilegatura;
        //    //}


        //}


        public static int VerificaInputIntero()
        {
            int valoreIntero;

            bool conversion = Int32.TryParse(Console.ReadLine(), out valoreIntero);
            //while(!conversion || valoreIntero < 0)
            while (conversion == false || valoreIntero < 0)
            {
                Console.Write("Valore errato, reinserisci: ");
                conversion = Int32.TryParse(Console.ReadLine(), out valoreIntero);
            }
            return valoreIntero;
        }

        public static void PrintTotale(string nome, string cognome, decimal costoTotaleFotocopie, string rilegatura)
        {
            Console.WriteLine($"{nome} - {cognome} pagherai: {costoTotaleFotocopie} euro");
            if (rilegatura.ToLower() == "sì")
                Console.WriteLine("compresa la rilegatura");
        }


    }
}




