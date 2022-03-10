using System;

namespace PrgOggetti
{
    class Program
    {
        static void Main(string[] args)
        {
            //Istanzio oggetto di tipo persona

            Persona persona = new Persona();
            persona.Nome = "Mario"; // uso il set per settare _nome;
            persona.DataNascita = new DateTime(1980, 1, 1);

            Console.WriteLine($"Nome: {persona.Nome} - Età: {persona.Eta} ");

            persona.Password = "1234";
            // non è possibile eseguire questa operazione perché è write-only
            //Console.WriteLine($"La tua password è {persona.Password}");

            if (persona.ValidaPassword("abcd"))
            {
                Console.WriteLine("password coretta");
            } else
            {
                Console.WriteLine("password sbagliata");
            };


            Persona p = new Persona();
            Console.WriteLine(p.Nome);
            Console.WriteLine(p.DataNascita);

            p.Nome = "Marco";
            Console.WriteLine(p.Nome);

            Persona personaNonDefault = new Persona()
            {
                Nome = "Antonia",
                DataNascita = new DateTime(1993, 1, 1),
                Password = "pppp",
            };
        }
    }
}

