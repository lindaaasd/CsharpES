using System;
using System.Diagnostics;

namespace FibonacciES2
{
    class Program
    {
        static void Main(string[] args)
        {
            int risultatoIterativo = Fibonacci.FibonacciIterativo(5);
            //Console.WriteLine($"Il valore richiesto è: {risultatoIterativo}");


            //int risultatoRicorsivo = Fibonacci.FibonacciRicorsivo(5);
            //Console.WriteLine($"Il valore richiesto, fatto in ricorsivo è: {risultatoRicorsivo}");

            //StopWatch fa parte della libreria System.Diagnostics, usato per vedere la velocità di un metodo 

            Stopwatch watch = new Stopwatch();
            watch.Start(); // facio partire il cronometro

            for ( int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Numero{i} della serie di " +
                    $"Fibonacci Iterativo: {Fibonacci.FibonacciIterativo(i)} ");
            }

            watch.Stop();
            Console.WriteLine($"Tempo impiegato {watch.ElapsedMilliseconds}");

            Stopwatch watchRicorsivo = new Stopwatch();
            watchRicorsivo.Start();

            for ( int i = 0; i< 10; i++)
            {
                Console.WriteLine($"Numero {i} della serie di " +
                    $"Fibonacci Ricursivo: {Fibonacci.FibonacciRicorsivo(i)}");
            }

            watchRicorsivo.Stop();
            Console.WriteLine($"Tempo impiegato {watchRicorsivo.ElapsedMilliseconds}");

        }
    }
}

