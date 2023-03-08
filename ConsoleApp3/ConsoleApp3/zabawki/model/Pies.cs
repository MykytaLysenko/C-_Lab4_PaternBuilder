using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Pies : Zabawka
    {
        public Pies()
        {
            this.name = "Pies";
            this.id = 4;
        }

        public override void secondButtonAction()
        {
            Console.WriteLine("Szczeka");
        }

        public override void thirdButtonAction()
        {
            Console.WriteLine("Merda ogonem");
        }

        public override ZabawkaBuilder getBuilder()
        {
            return new PiesBuilder();
        }
    }
}
