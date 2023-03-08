using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class NiedzwiadekBuilder : ZabawkaBuilder
    {
        private Niedzwiadek niedzwiadek = new Niedzwiadek();
        public void dodajGlowe()
        {
            this.niedzwiadek[CzesciCialaTypy.Glowa] = "Glowa niedzwiadka";
        }

        public void dodajKonczynieDolne()
        {
            this.niedzwiadek[CzesciCialaTypy.KonczynieDolne] = "Konczynie dolne niedzwiadka";
        }

        public void dodajKonczynieGorne()
        {
            this.niedzwiadek[CzesciCialaTypy.KonczynieGorne] = "Konczynie gorne niedzwiadka";
        }

        public void dodajOgon()
        {
            this.niedzwiadek[CzesciCialaTypy.Ogon] = "Ogon niedzwiadka";
        }

        public void dodajTulow()
        {
            this.niedzwiadek[CzesciCialaTypy.Tulow] = "Tulow niedzwiadka";
        }

        public Zabawka getResult()
        {
            return this.niedzwiadek;
        }
    }
}
