using System;
using System.Collections;

namespace VeicoloES
{
	internal class Auto
	{
		//marca, kilowatt, tipologia euro, anno immatricolazione, prezzo di acquisto

		private string _marca = "xxxxx";
		private string _tipologiaEuro = "xxxxx";
		private int _annoImmatricolazione;
		private decimal _prezzoAcquisto;
		private int _kilowatt;

		public string Marca { get; set; }
		public string TipologiaEuro { get; set; }
		private int AnnoImmatricolazione { get; set; }
		private decimal PrezzoAcquisto { get; set; }
		private int Kilowatt { get; set; }

		public static void MenuInserimentoAuto(ArrayList autos)
		{
			bool continua = true;

			do
			{
				PrintInserimentoAutoMenu();
				int scelta = VerificaInputIntero();

				switch (scelta)
				{
					case 0:
						continua = false;
						break;
					case 1:
						Console.WriteLine("Inserisci la marca dell'auto");
						autos.Marca = Console.ReadLine();
						break;
					case 2:
						Console.WriteLine("Inserisci la tipologia euro");
						autos.TipologiaEuro = Console.ReadLine();
						break;
					case 3:
						Console.WriteLine("Inserisci l'anno dell'immatricolazione");
						Int32.TryParse(Console.ReadLine(), out int valoreInserito);
						autos.AnnoImmatricolazione = valoreInserito;
						break;
					case 4:
						Console.WriteLine("Inserisci il prezo d'acquisto");
						Decimal.TryParse(Console.ReadLine(), out decimal valoreInserito2);
						autos.PrezzoAcquisto = valoreInserito2;
						break;
					case 5:
						Console.WriteLine("Inserisci i kilowatt");
						Int32.TryParse(Console.ReadLine(), out int valoreInserito3);
						autos.Kilowatt = valoreInserito3;
						break;
				}
			}

			while (continua);

		}

		public static void PrintInserimentoAutoMenu()
		{
			Console.WriteLine("1. Inserisci la marca dell'auto ");
			Console.WriteLine("2. Inserisci la tipologia euro ");
			Console.WriteLine("3. Inserisci l'anno dell'immatricolazione ");
			Console.WriteLine("4. Inserisci il prezzo d'acquisto ");
			Console.WriteLine("5. Inserisci il valore del kilowatt ");
			Console.WriteLine("0. Esci ");
		}

		public static void PrintDettagliAuto(Auto auto)
		{
			Console.WriteLine($"La macchina inserita è {auto.Marca}, una euro{auto.TipologiaEuro} " +
				$"registrata nel {auto.AnnoImmatricolazione}ed" +
				$" acquistata per {auto.PrezzoAcquisto} euro \n" +
				$"Il bollo da pagare è {CalcolaCostoBollo(auto)}");
		}

		public static double CalcolaCostoBollo(Auto auto)
		{
			var costoBollo = 0.00;

			if (auto.TipologiaEuro == "1")
			{
				costoBollo = auto.Kilowatt < 100 ? 2.90 : 4.35;

			}
			else if (auto.TipologiaEuro == "2")
			{
				costoBollo = auto.Kilowatt < 100 ? 2.80 : 4.20;

			}
			else if (auto.TipologiaEuro == "3")
			{
				costoBollo = auto.Kilowatt < 100 ? 2.70 : 4.05;

			}
			else
			{
				costoBollo = auto.Kilowatt < 100 ? 2.58 : 3.87;
			}

            Console.WriteLine($"Calcolato il bollo da pagare: {CalcolaCostoBollo(auto)}");
			return costoBollo;
		}

		private static int VerificaInputIntero()
		{
			int valoreIntero;
			bool conversion = Int32.TryParse(Console.ReadLine(), out valoreIntero);

			while (!conversion || valoreIntero < 0)
			{
				Console.WriteLine("Inserisci un valore corretto ");
				conversion = Int32.TryParse(Console.ReadLine(), out valoreIntero);

			}

			return valoreIntero;


		}

		public static void PrintAutos(ArrayList autos)
		{
			foreach (Auto auto in autos)
			{
				PrintAutos(auto);
			}
		}

		//public static void EliminaAuto(ArrayLista autos)
  //      {
		//	//Cerco il veicolo da eliminare
		//	Auto autoDaCancellare = CercaAuto(autos);

  //      }

		//public static Auto CercaAuto(ArrayList autos)
  //      {
  //          Console.WriteLine("Inserisci targa: ");
		//	string targa = Console.ReadLine();
		//	foreach(Auto auto in autos)
  //          {
  //              if (auto.Targa.Equals(targa))
  //              {
		//			return auto; //verifico il veicolo con la targa e lo restituisco
  //              }
  //          }
		//	return null;
  //      }
	}

}

