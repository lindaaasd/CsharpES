using System;

namespace AlbergoES
{
    class Program
    {
        public const int MAX = 20;

        static void Main(string[] args)
        {
            string[] camereAlbergo = new string[10];

            camereAlbergo[0] = "John Lenon";
            camereAlbergo[1] = "Ringo Star";
            camereAlbergo[2] = "Paul McCartney ";
            camereAlbergo[3] = "George Harrison";
            camereAlbergo[4] = "Joey Ramone";
            camereAlbergo[5] = "Tommy Ramone";
            camereAlbergo[6] = "DeeDee Ramone";
            camereAlbergo[7] = "Johnny Ramone";


            AlbergoES.PrintRooms(camereAlbergo);
            Console.ReadLine();

            Console.WriteLine("Scrivi il nome del cliente per vedere il numero della sua camera");

            var numeroCamera = Array.IndexOf(camereAlbergo, Console.ReadLine());
            Console.WriteLine($"Il numero della camera è {numeroCamera}");
            Console.ReadLine();

            //    string[] camere = new string[MAX];
            //bool continua;

            //    do
            //    {
            //        continua = GestoreAlbergo.Menu(camere);

            //    } while (continua);


        }
    }
}

