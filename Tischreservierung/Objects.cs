using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tischreservierung
{
	[Serializable]
	public class Reservation
	{
		public string Firstname { get; set; }

		public string Lastname { get; set; }

		public string Date { get; set; }
	
		public string Table { get; set; }

		public int NumberOfPersons { get; set; }

		public string Phonenumber { get; set; }

       
		public Reservation(string firstname, string lastname, string date, string Table, int NumberOfPersons, string Phonenumber)
		{
			this.Firstname = firstname;
			this.Lastname = lastname;
			this.Date = date;
			this.Table = Table;
			this.NumberOfPersons = NumberOfPersons;
			this.Phonenumber = Phonenumber;
		}
	}

}

