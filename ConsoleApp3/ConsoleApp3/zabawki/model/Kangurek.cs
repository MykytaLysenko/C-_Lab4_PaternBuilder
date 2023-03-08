using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Kangurek : Zabawka
    {
        public Kangurek()
        {
            this.name = "Kangurek";
            this.id = 5;
        }

        public override void secondButtonAction()
        {
            Console.WriteLine("Spi");
        }

        public override void thirdButtonAction()
        {
            Console.WriteLine("Skacze");
        }

        public override ZabawkaBuilder getBuilder()
        {
            return new KangurekBuilder();
        }
    }
}
