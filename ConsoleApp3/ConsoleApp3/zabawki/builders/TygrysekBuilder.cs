using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class TygrysekBuilder : ZabawkaBuilder
    {
        private Tygrysek tygrysek = new Tygrysek();
        public void dodajGlowe()
        {
            this.tygrysek[CzesciCialaTypy.Glowa] = "Glowa tygryska";
        }

        public void dodajKonczynieDolne()
        {
            this.tygrysek[CzesciCialaTypy.KonczynieDolne] = "Konczynie dolne tygryska";
        }

        public void dodajKonczynieGorne()
        {
            this.tygrysek[CzesciCialaTypy.KonczynieGorne] = "Konczynie gorne tygryska";
        }

        public void dodajOgon()
        {
            this.tygrysek[CzesciCialaTypy.Ogon] = "Ogon tygryska";
        }

        public void dodajTulow()
        {
            this.tygrysek[CzesciCialaTypy.Tulow] = "Tulow tygryska";
        }

        public Zabawka getResult()
        {
            return this.tygrysek;
        }
    }
}
