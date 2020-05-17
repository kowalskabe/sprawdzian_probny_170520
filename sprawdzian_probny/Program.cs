using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprawdzian_probny
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Konto> bank = new List<Konto>();
            bank.Add(new Konto("Ania", 500));
            bank.Add(new Konto("Basia", 11500));
            bank.Add(new Konto("Czesia", 1500));
            bank.Add(new KontoFirmowe("Daria", 5500));
            bank.Add(new Konto("Ewa", 3500));
            bank.Add(new Konto("Fiona", 4500));

            foreach (Konto konto in bank)
            {
                konto.Wyplata(100);
            }
            foreach (Konto konto in bank)
            {
                Console.WriteLine(konto);
            }

            List<Konto> bankPosortowane = new List<Konto>();
            bankPosortowane = bank.OrderByDescending(konto => konto.Wlasciciel).ToList();

            foreach (Konto konto in bankPosortowane)
            {
                Console.WriteLine(konto);
            }

            bank.Reverse();

            foreach (Konto konto in bank)
            {
                Console.WriteLine(konto);
            }

            Console.ReadKey();
        }

    }
}
