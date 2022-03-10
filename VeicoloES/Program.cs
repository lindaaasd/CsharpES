using System;
using System.Collections;

namespace VeicoloES
{
    class Program
    {
        static void Main(string[] args)
        {

            bool continua = true;

            ArrayList autos = new ArrayList();
            //Auto auto = new Auto();

            do
            {
                PrintMenu();

                int scelta = VerificaInputIntero();

                switch (scelta)
                {
                    case 0:
                        continua = false;
                        break;
                    case 1:
                        // Inserimento di una nuova auto
                        //Auto.MenuInserimentoAuto(auto);

                        //Auto autoDaAggiungere = Auto.MenuInserimentoAuto();
                        //listaAuto.Add(autoDaAggiungere);

                        autos.Add(Auto.MenuInserimentoAuto(autos));
                        break;
                    case 2:
                        // Calcola costo bollo
                        Auto.CalcolaCostoBollo(autos);
                        break;
                    case 3:
                        // Stampa i dettagli dell'auto

                        Auto.PrintAutos(autos);

                        //Auto.PrintDettagliAuto(auto);
                        break;
                    ////case 4:
                    //    // Rimuovi auto
                    //    Auto.EliminaAuto(autos);
                    //    break;

                }

            } while (continua);

            static void PrintMenu()
            {
                Console.WriteLine("1. Inserisci nuova auto ");
                Console.WriteLine("2. Calcola costo bollo ");
                Console.WriteLine("3. Stampa i dettagli dell'auto ");
                Console.WriteLine("0. Esci ");
            }


            static int VerificaInputIntero()
            {
                int valoreIntero;
                bool conversion = Int32.TryParse(Console.ReadLine(), out valoreIntero);

                while (!conversion || valoreIntero < 0)
                {
                    Console.WriteLine("Inserisci un valore corretto ");
                    conversion = Int32.TryParse(Console.ReadLine(), out valoreIntero);

                }

                return valoreIntero;
            }

          

        }
    }
}