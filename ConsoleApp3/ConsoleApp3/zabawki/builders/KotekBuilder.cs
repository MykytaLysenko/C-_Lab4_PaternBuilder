using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class KotekBuilder : ZabawkaBuilder
    {
        private Kotek kotek = new Kotek();
        public void dodajGlowe()
        {
            this.kotek[CzesciCialaTypy.Glowa] = "Glowa kotka";
        }

        public void dodajKonczynieDolne()
        {
            this.kotek[CzesciCialaTypy.KonczynieDolne] = "Konczynie dolne kotka";
        }

        public void dodajKonczynieGorne()
        {
            this.kotek[CzesciCialaTypy.KonczynieGorne] = "Konczynie gorne kotka";
        }

        public void dodajOgon()
        {
            this.kotek[CzesciCialaTypy.Ogon] = "Ogon kotka";
        }

        public void dodajTulow()
        {
            this.kotek[CzesciCialaTypy.Tulow] = "Tulow kotka";
        }

        public Zabawka getResult()
        {
            return this.kotek;
        }
    }
}
