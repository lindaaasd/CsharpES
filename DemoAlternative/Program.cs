using System;

namespace DemoAlternative
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            bool continua;

            do
            {
                continua = GestoreCopisteria.Menu;



            } while (continua);
        }
    }
}

