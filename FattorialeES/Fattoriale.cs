// dato un numero intero n >= 0, il suo fattoriale è definito come n! = n * (n-1) * (n-2) * .. 2 * 1
// Il suo valore



using System;
namespace FattorialeES
{
	public class Fattoriale
	{
		public static int FattorialeIterativo( int n)
        {
			int risultato = 1;

			if ( n == 0)
            {
				return risultato = 1;
            }

			for(int i = 1; i <= n; i++)
            {
				risultato *= i;

            }

            //Console.WriteLine($"Factorial di {n} è: {risultato}");

			return risultato;
        }

		public static int FattorialeRicorsivo(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            return n * FattorialeRicorsivo(n - 1);
        }

	}
}

