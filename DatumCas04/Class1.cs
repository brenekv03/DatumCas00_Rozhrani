using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatumCas04
{
    class Class1
    {
        public static int PocetDnu(DateTime prodano, int pocetLetZaruky)
        {
            DateTime posledniDenZaruky = prodano.AddYears(pocetLetZaruky);
            DateTime dt = DateTime.Now;

            TimeSpan zbyva = posledniDenZaruky - dt;

            return (int)zbyva.TotalDays;

        }
    }
}
