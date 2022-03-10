using System;
using System.Collections;
using Week2.EsercizioAutomobili.Entities;

namespace Week2.EsercizioAutomobili
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Veicolo veicoloDaAggiungere = new Veicolo();
            ArrayList listaVeicoli = new ArrayList();
            bool continua = true;
            while (continua)
            {
                int scelta = SchermoMenu();

                switch (scelta)
                {
                    case 1:
                        //veicoloDaAggiungere = VeicoliManagement.InserisciVeicolo();
                        //Veicolo veicoloDaAggiungere = VeicoliManagement.InserisciVeicolo();
                        //listaVeicoli.Add(veicoloDaAggiungere);
                        listaVeicoli.Add(VeicoliManagement.InserisciVeicolo());
                        break;
                    case 2:
                        //VeicoliManagement.StampaVeicolo(veicoloDaAggiungere);
                        VeicoliManagement.StampaVeicoli(listaVeicoli);
                        break;
                    case 3:
                        VeicoliManagement.EliminaVeicolo(listaVeicoli);
                        break;
                    default: //un numero diverso da 0
                        continua = false;
                        Console.WriteLine("Arrivederci");
                        break;
                }
            }

        }

        public static int SchermoMenu()
        {
            Console.WriteLine("1. Inserisci veicolo");
            Console.WriteLine("2. Stampa veicolo");
            Console.WriteLine("3. Rimuovi veicolo");
            Console.WriteLine("Qualsiasi altro valore per uscire");
            Console.Write("Scelta: >");
            Int32.TryParse(Console.ReadLine(), out int scelta);
            return scelta;
        }
    }
}
