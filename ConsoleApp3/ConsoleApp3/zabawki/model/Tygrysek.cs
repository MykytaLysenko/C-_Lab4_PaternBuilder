using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Tygrysek : Zabawka
    {


        public Tygrysek()
        {
            this.name = "Tygrysek";
            this.id = 3;
        }

        public override void secondButtonAction()
        {
            Console.WriteLine("Odgania lapa muchy");
        }

        public override void thirdButtonAction()
        {
            Console.WriteLine("Biegnie");
        }

        public override ZabawkaBuilder getBuilder()
        {
            return new TygrysekBuilder();
        }
    }
}
