using System;
using System.Collections;
using System.IO;

namespace VeicoloES
{
	internal static class GestionIOauto
	{

		public static void StampareAutoSuFile(ArrayList autos)
        {

		string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "auto.txt");

			using(StreamWriter sw = File.CreateText(path))
            {
				//sw.WriteLine("Persona da inserire su file ");
				foreach(Auto autoDaStampareSuFile in autos)
                {
					sw.WriteLine(autoDaStampareSuFile);
                }
            }
        }
	}
}

