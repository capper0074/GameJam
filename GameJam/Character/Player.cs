using GameJam.GameStart;
using GameJam.Graphic;
using GameJam.Stuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJam.Character
{
    public static class Player
    {

        public static int Health { get; set; }

        public static int Stamina { get; set; }

        public static string Name { get; set; }

        private static bool isInitialize;

        public static void Initialize()
        {
            if (isInitialize)
            {
                return;
            }
            else
            {
                Health = 100;
                Stamina = 100;
                Name = "Møller";
                isInitialize = true;
            }
        }

        public static void Display_Stats()
        {
            Console.Clear();
            Console.WriteLine("Your name are: " + Name);
            Beautifier.CoolBar(Health, Stamina);
        }

        public static void Tick_Stamina()
        {
            Stamina = Stamina - 10;
        }

        public static void Eat(Items food) //Lortet er forkert
        {
            if(Health + food.HealthStat !> 100 && Stamina + food.StaminaStat !> 100)
            {
                Console.Clear();
                AsciiArt.Ascii_StatIncrease();
                Beautifier.CoolLine();
                Beautifier.CoolWrite("purple", $"Your Health have increased by {food.HealthStat}");
                Beautifier.CoolWrite("purple", $"Your Stamina have increased by {food.StaminaStat}");
            }
            else
            {
                Console.Clear();
                AsciiArt.Ascii_GameInfo();
                Beautifier.CoolLine();
                Beautifier.CoolWrite("red", "Are you sure, you want to eat this \n if u do "); 
            }


            Console.Clear();
            AsciiArt.Ascii_StatIncrease();
            Beautifier.CoolLine();
            //Beautifier.CoolWrite("purple", $"Your Health have increased by {food.Item_stat}");
            //Beautifier.CoolWrite("purple", $"Your Stamina have increased by {food.Item_stat}");
        }

    }
}
