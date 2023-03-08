using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Niedzwiadek : Zabawka
    {
        public Niedzwiadek()
        {
            this.name = "Niedzwiadek";
            this.id = 1;
        }

        public override void secondButtonAction()
        {
            Console.WriteLine("Prawa lapka rusza sie");
        }

        public override void thirdButtonAction()
        {
            Console.WriteLine("Lewa lapka rusza sie");
        }

        public override ZabawkaBuilder getBuilder()
        {
            return new NiedzwiadekBuilder();
        }
    }
}
