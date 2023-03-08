using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    interface ZabawkaBuilder
    {
        void dodajGlowe();

        void dodajTulow();

        void dodajKonczynieGorne();

        void dodajKonczynieDolne();

        void dodajOgon();

        Zabawka getResult();
    }
}
