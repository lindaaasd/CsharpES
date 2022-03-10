using System;
using System.Collections;
using System.IO;
using PrgOggetti;

namespace GestioneInputOutpot
{
	internal static class GestioneIO
	{
		public static void StampaPersoneSuFile(ArrayList persone)
        {
			//per usare Path bisogna importare System.IO
			//restituisce il percorso del desktop con il file persone.txt
			string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "persone.txt");

			using(StreamWriter sw = File.CreateText(path))
            {
				//sw.WriteLine("Persona da inserire su file ");
				foreach(Persona personaDaStampareSuFile in persone)
                {
					sw.WriteLine(personaDaStampareSuFile);
                }
            }
        }

		public static ArrayList CaricaPersoneDaFile()
        {
			ArrayList personeCaricateDaFile = new ArrayList();
			// carichiamo i valori a partire dal file;
			// specifico il path del file da cui leggere

			string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "persone.txt");
			string line; // stringa che conterrà la linea che leggo da file

			//apro il flusso di lettura
			//ATTENZIONE: se il file non esiste, non viene creato e il programma si interrompe;
			using(StreamReader sr = File.OpenText(path))
            {
				line = sr.ReadLine();
				while (line != null) // finchè c'è qualcosa da leggere nel file, vado avanti
                {
					string[] valoriPersona = line.Split('-');
					string nome = valoriPersona[0];
					DateTime.TryParse(valoriPersona[1], out DateTime dataNascita);
					Persona p = new Persona()
					{
						Nome = nome,
						DataNascita = dataNascita,
					};

                    personeCaricateDaFile.Add(p);
					line = sr.ReadLine();
                }
            }

			return personeCaricateDaFile;
        }
	}
}

