using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Kotek : Zabawka
    {
        public Kotek()
        {
            this.name = "Kotek";
            this.id = 2;
        }

        public override void secondButtonAction()
        {
            Console.WriteLine("Idzie");
        }

        public override void thirdButtonAction()
        {
            Console.WriteLine("Patrzy sie");
        }

        public override ZabawkaBuilder getBuilder()
        {
            return new KotekBuilder();
        }
    }
}
