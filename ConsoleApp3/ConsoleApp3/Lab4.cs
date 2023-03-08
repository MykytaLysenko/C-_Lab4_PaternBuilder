using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Lab4
    {
        private List<Zabawka> zabawki = new List<Zabawka>()
        {
            new Niedzwiadek(),
            new Kotek(),
            new Tygrysek(),
            new Pies(),
            new Kangurek()
        };

        public void init()
        {
            Console.WriteLine();

            Console.WriteLine("Wybierz zabawke: ");
            foreach(var zabawka in zabawki)
            {
                Console.WriteLine(zabawka.Id + "." + " " + zabawka.Name);
            }

            Console.WriteLine();

            int idZabawki = 0;

            try
            {
                idZabawki = int.Parse(Console.ReadKey().KeyChar.ToString());
            }
            catch (FormatException)
            {
                Console.WriteLine("Musisz wprowadzic liczbe \n");
                this.init();
            }

            Zabawka wybranaZabawka = this.zabawki.Find(z => z.Id == idZabawki);
            ZabawkaBuilder builder = wybranaZabawka.getBuilder();
            Director director = new Director();
            director.Construct(builder);
            Zabawka zbudowanaZabawka = builder.getResult();
            Console.WriteLine("Zbudowana zabawka: \n");
            zbudowanaZabawka.getInfo();

            Console.WriteLine();
            Console.WriteLine("Kliknij jeden z ponizszych przyciskow zeby zagrac. \n\n" +
                "Zeby przestac grac kliknij ESC.\n\nZeby zaczac tworzenie nowej zabawki kliknij C \n");
            Console.WriteLine("1.");
            Console.WriteLine("2.");
            Console.WriteLine("3.");

            this.playGame(zbudowanaZabawka);
        }

        public void playGame(Zabawka zabawka)
        {
            ConsoleKeyInfo key = Console.ReadKey(true);
            switch (key .Key)
            {
                case ConsoleKey.D1:
                    zabawka.firstButtonAction();
                    this.playGame(zabawka);
                    break;
                case ConsoleKey.D2:
                    zabawka.secondButtonAction();
                    this.playGame(zabawka);
                    break;
                case ConsoleKey.D3:
                    zabawka.thirdButtonAction();
                    this.playGame(zabawka);
                    break;
                case ConsoleKey.Escape:
                    break;
                case ConsoleKey.C:
                    this.init();
                    break;
                default:
                    Console.WriteLine("Niepoprawna opcja");
                    break;
            }
        }
    }
}
