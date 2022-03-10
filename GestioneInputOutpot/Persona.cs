using System;
namespace PrgOggetti
{
	internal class Persona
	{
		public static string Codice = "PERS";
		//campi
							// prende di default il valore "giovanni" finché non verrà modificato
		private string _nome = "Giovanni";
		private string _password;
		private string _stipendio;

		//proprietà

		public string Nome
        {
			get{return _nome;}
            set{_nome = value;}
        }

		// proprietà calcolata e read-only
		public int Eta
        {
			get { return new DateTime().Year - DataNascita.Year; }
        }

		public string Password
        {
			set { _password = value;  }
        }
												// metto il valore di default
		public DateTime DataNascita { get; set; } = new DateTime(1990, 1, 1);

		public bool ValidaPassword(string passwordDaControllare)
        {
			if(passwordDaControllare == _password)
            {
				return true;
            } else
            {
				return false;
            }
        }

		//public string GetClasseSociale()
  //      {
		//	if ( _stipendio > 2000)
  //          {
		//		return "Persona ricca";
  //          } else
  //          {
		//		return "Ceto medio";
  //          }
  //      }
	}
}

