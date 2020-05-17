using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprawdzian_probny
{
    class KontoFirmowe : Konto
    {
        public KontoFirmowe(string wlasciciel, int saldo) : base(wlasciciel, saldo)
        {
             
        }

        public override string ToString()
        {
            return $"Konto firmmowe : właściciel {this.Wlasciciel}, saldo:{this.Saldo}";
        }

        public override void Wyplata(int wyplata)
        {
            base.Wyplata(wyplata);
            this.Saldo -= 10;
        }
    }
}
