using System;
namespace AlbergoES
{
	public class AlbergoES
	{
		 public static void PrintRooms(string[] camereAlbergo)
        {
			//foreach(var camera in camereAlbergo)
   //         {
   //             Console.WriteLine(camera);
   //         }

			// stampa l'indice dell'array con il valore assegnato
			for(int i = 0; i < camereAlbergo.Length; i++)
            {
				if ( !(camereAlbergo[i] == null))
                {
				Console.WriteLine($"Nella camera numero {i} si trova l'ospite {camereAlbergo[i]}");

                }

			}


			//verifica se ci sono indici vuoti dentro l'array & stampa l'indice dell'array vuoto

			var camereLibere = false;

			for (int j = 0; j < camereAlbergo.Length; j++)
            {
				if (camereAlbergo[j] == null)
                {
                    Console.WriteLine($"La camera {j} è libera");
					camereLibere = true;
				} 
            } 

			if(camereLibere == false)
            {
			Console.WriteLine("Tutte le camere sono occupate");
            } 

			return;
        }
		

	}
}

