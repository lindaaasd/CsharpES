using System;

namespace FattorialeES
{
    class Program
    {
        static void Main(string[] args)
        {
            int risultatoIterativo = Fattoriale.FattorialeIterativo(5);

            Console.WriteLine($"Il valore richiesto è: {risultatoIterativo}");
            Console.ReadLine();

            int risultatoRicorsivo = Fattoriale.FattorialeRicorsivo(5);
            Console.WriteLine($"Il valore in ricorsivo è: {risultatoRicorsivo}");
            Console.ReadLine();
        }
    }
}

