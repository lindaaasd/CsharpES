using System;
using System.Collections;

namespace Arrary_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            // la variabile array può contenere fino a 50 int
            int[] array = new int[50]; // {1, 2, 3 ...50 };

            array[0] = 10;
            array[49] = 4;
            array[50] = 40; // lo puoi scrivere, ma non sarà eseguito visto che
                            // l'array non ha la posizione 50
                            // ( finisce a 49, inizio con 0 )

            double[] arrayDiDouble = new double[] { 1.3, 2.3, 5.6 };
            for (int i = 0; i < arrayDiDouble.Length, i++)
            {
                Console.WriteLine(arrayDiDouble[i]);
            }

            //IndexOf mi dice la posizione di un valore dentro l'array
            // se non c'è il valore, il risultato è -1
            int indicePrimoValore = Array.IndexOf(arrayDiDouble, 5.6);
            Console.WriteLine($"Il valore 5.6 si trova in posizione {indicePrimoValore}");

            int[] arrayVuoto = new int[] {};
            if(arrayVuoto.Length == 0)
            {
                Console.WriteLine("questo array è vuoto");
            }

            ArrayList esempio = new ArrayList(); //lista vuota
            ArrayList esempioMisto = new ArrayList() { 1, "ciao", 4.5, true };
            Console.WriteLine(esempioMisto[0]);

            esempioMisto.Add(45); // aggiunta in coda di un elemento;

            for (int i= 0; i < esempioMisto.Count; i++)
            {
                Console.WriteLine($"Elemento in posizione {i}: {esempioMisto[i]}");
            }

            foreach (var value in esempioMisto)
            {
                Console.WriteLine(value);
            }

            esempioMisto.RemoveAt(0); // rimozione elemento in prima posizione
            esempioMisto.RemoveAt(esempioMisto.Count - 1); // rimozione ultimo elemento

            esempioMisto.AddRange(arrayDiDouble);
            foreach( var value in esempioMisto)
            {
                Console.WriteLine(value);
            }
           



        }
    }
}

