using GameJam.Levels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJam.GameStart
{
    public class MenuStart
    {
        public static void Start_Menu()
        {
            Console.WriteLine("Velkommet til spillet 'The Great Beer Run'");
            Console.WriteLine("Dit mål er at skaffe så meget øl så muligt");
            Console.WriteLine("Du vil møde modstand og udfordringer på dit eventyr!");
            Console.WriteLine("Beer if life!");

            Console.WriteLine("Tryk 'Enter' hvis du har forstået og er klar");
            Console.ReadKey();

            Intro intro = new Intro();
            intro.GameIntro();
        }

        public static void Menu()
        {
            Console.WriteLine("Tryk 1 for at starte");
            Console.WriteLine("Tryk 2 for at afslutte");

            bool choise = true;
            do
            {
                string value = Console.ReadLine();

                if (value == "1")
                {
                    Start_Menu();
                }
                else if (value == "2")
                {
                    choise = false;
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Fejl input din spasser, brug dit hoved og prøv igen!");
                }

            }
            while (choise);
        }

    }
}
