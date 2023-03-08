using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class KangurekBuilder : ZabawkaBuilder
    {
        private Kangurek kangurek = new Kangurek();
        public void dodajGlowe()
        {
            this.kangurek[CzesciCialaTypy.Glowa] = "Glowa kangurka";
        }

        public void dodajKonczynieDolne()
        {
            this.kangurek[CzesciCialaTypy.KonczynieDolne] = "Konczynie dolne kangurka";
        }

        public void dodajKonczynieGorne()
        {
            this.kangurek[CzesciCialaTypy.KonczynieGorne] = "Konczynie gorne kangurka";
        }

        public void dodajOgon()
        {
            this.kangurek[CzesciCialaTypy.Ogon] = "Ogon kangurka";
        }

        public void dodajTulow()
        {
            this.kangurek[CzesciCialaTypy.Tulow] = "Tulow kangurka";
        }

        public Zabawka getResult()
        {
            return this.kangurek;
        }
    }
}
