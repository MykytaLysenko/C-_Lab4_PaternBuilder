using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Director
    {
        public void Construct(ZabawkaBuilder builder)
        {
            builder.dodajGlowe();
            builder.dodajTulow();
            builder.dodajKonczynieGorne();
            builder.dodajKonczynieDolne();
            builder.dodajOgon();
        }
    }
}
