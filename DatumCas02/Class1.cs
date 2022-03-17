using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatumCas02
{
    class Class1
    {

        public static TimeSpan PocetDnu(DateTime narozen)
        {
            TimeSpan Uplynulo;
            narozen = narozen.AddYears(65);
            Uplynulo = DateTime.Today - narozen;
            return Uplynulo;

        }
    }
}
