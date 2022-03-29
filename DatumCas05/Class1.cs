using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatumCas05
{
    class Class1
    {
        public static bool MinTrvanlivostDny(DateTime prodano, int pocetDniZaruky, int cena, out int sleva)
        {

            DateTime posledniDenZaruky = prodano.AddDays(pocetDniZaruky);
            DateTime dt = DateTime.Now;
            TimeSpan zbyva = posledniDenZaruky - dt;
            bool prodejne = true;
            sleva = 0;
            if ((int)zbyva.TotalDays > 3)
            {
                sleva = cena;
                prodejne = true;
            }
            if ((int)zbyva.TotalDays <= 3)
            {
                sleva = (cena * 75) / 100;
                prodejne = true;
            }
            if ((int)zbyva.TotalDays < 0)
            {
                sleva = (cena * 50) / 100;
                prodejne = true;
            }
            if ((int)zbyva.TotalDays < -10)
            {
                prodejne = false;
            }

            return prodejne;

        }
    }
}
