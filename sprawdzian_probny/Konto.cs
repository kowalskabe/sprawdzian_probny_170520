using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprawdzian_probny
{
    class Konto
    {
		private string wlasciciel;
		private int saldo;

		public string Wlasciciel
		{
			get { return wlasciciel; }
			set { wlasciciel = value; }
		}

		public int Saldo
		{
			get { return saldo; }
			set { saldo = value; }
		}


		public Konto(string wlasciciel, int saldo)
		{
			this.wlasciciel = wlasciciel;
			this.saldo = saldo;
		}

		public override string ToString()
		{
			return $"Konto : właściciel {wlasciciel}, saldo: {saldo}";
		}

		public virtual void Wyplata(int wyplata)
		{
			this.saldo -= wyplata; 
		}
	}
}
