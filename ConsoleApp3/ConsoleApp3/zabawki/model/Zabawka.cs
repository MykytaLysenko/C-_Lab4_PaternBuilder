using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp3
{
    abstract class Zabawka
    {

        protected string name;

        protected int id;

        public string Name { get => name; }

        public int Id { get => id; }

        private Dictionary<CzesciCialaTypy, string> dict = new Dictionary<CzesciCialaTypy, string>();

        public string this[CzesciCialaTypy klucz]
        {
            get { return dict[klucz]; }
            set { dict[klucz] = value; }
        }

        public void firstButtonAction()
        {
            if(this.dict[CzesciCialaTypy.Glowa] != null)
            {
                Console.WriteLine("Jestem " + this.name);
            }
        }

        public abstract void secondButtonAction();
        public abstract void thirdButtonAction();
        public abstract ZabawkaBuilder getBuilder();

        public void getInfo()
        {
            foreach(var item in dict)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }

    public enum CzesciCialaTypy
    {
        Glowa,
        Tulow,
        KonczynieGorne,
        KonczynieDolne,
        Ogon
    }
}
