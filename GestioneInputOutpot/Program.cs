using System;
using System.Collections;
using PrgOggetti;

namespace GestioneInputOutpot
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList persone = new ArrayList();

            //Persona persona1 = new Persona()
            //{
            //    Nome = "Mario Rossi",
            //    DataNascita = new DateTime(1998, 2, 5),
            //    Password = "1234",
            //};

            //Persona persona2 = new Persona()
            //{
            //    Nome = "Luca Bianchi",
            //    DataNascita = new DateTime(1955, 4, 3),
            //    Password = "5678"
            //};

            //persone.Add(persona1);
            //persone.Add(persona2);

            persone = GestioneIO.CaricaPersoneDaFile();

            foreach(Persona persona in persone)
            {
                Console.WriteLine(persona);
            }

            GestioneIO.StampaPersoneSuFile(persone);


        }
    }
}

