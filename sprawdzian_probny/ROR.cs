using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprawdzian_probny
{
    class ROR : IOperacje
    {
		private double saldo;

		public double Saldo
		{
			get { return saldo; }
			set { saldo = value; }
		}

		public void Wplata(double wplata)
		{
			saldo += wplata;
		}

		public void Odsetki()
		{
			if (this.saldo > 0)
			{
				this.saldo += 5;
			}
			else 
			{
				this.saldo -= 10;
			}
		}

	}
}
