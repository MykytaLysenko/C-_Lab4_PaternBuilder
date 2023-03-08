using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class PiesBuilder : ZabawkaBuilder
    {
        private Pies pies = new Pies();
        public void dodajGlowe()
        {
            this.pies[CzesciCialaTypy.Glowa] = "Glowa psa";
        }

        public void dodajKonczynieDolne()
        {
            this.pies[CzesciCialaTypy.KonczynieDolne] = "Konczynie dolne psa";
        }

        public void dodajKonczynieGorne()
        {
            this.pies[CzesciCialaTypy.KonczynieGorne] = "Konczynie gorne psa";
        }

        public void dodajOgon()
        {
            this.pies[CzesciCialaTypy.Ogon] = "Ogon psa";
        }

        public void dodajTulow()
        {
            this.pies[CzesciCialaTypy.Tulow] = "Tulow psa";
        }

        public Zabawka getResult()
        {
            return this.pies;
        }
    }
}
