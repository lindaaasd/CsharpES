using System;
namespace FibonacciES2
{
	internal class Fibonacci
	{
	
            #region ITERAZIONE VS RICORSIONE

            // 0..1..1..2..3..5..8..13..

            public static int FibonacciIterativo(int n)
            {
                int primoNumeroSerie = 0;
                int secondoNumeroSerie = 1;
                int risultato = 0;

                if (n == 0)
                {
                    return primoNumeroSerie;
                }

                if( n == 1)
                {
                    return secondoNumeroSerie;
                }

                for( int i = 2; i <= n; i++)
                 {
                    risultato = primoNumeroSerie + secondoNumeroSerie;

                    primoNumeroSerie = secondoNumeroSerie;
                    secondoNumeroSerie = risultato;
                 }

            return risultato;
            }

        public static int FibonacciRicorsivo(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            if (n == 1)
            {
                return 1;
            }

            return FibonacciRicorsivo(n - 1) + FibonacciRicorsivo(n - 2);
        }

            #endregion

    }
}

