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

        public static int health { get; set; }

        public static int stamina { get; set; }

        public static string name { get; set; }

        private static bool isInitialize;

        public static void Initialize()
        {
            if (isInitialize)
            {
                return;
            }
            else
            {
                health = 100;
                stamina = 100;
                name = "Møller";
                isInitialize = true;
            }
        }

        public static void Display_Stats()
        {
            Console.WriteLine("Stamina: " + stamina + " Health " + health);
        }

        public static void Tick_Stamina()
        {
            stamina = stamina - 10;
        }

        public static void Eat(Items food) //Tilføj mad her
        {

            if (food.Name.ToLower() == "øl")
            {
                stamina += food.Item_stat;
                health += food.Item_stat - 10;
            }
            else if (food.Name.ToLower() == "snus")
            {
                stamina += food.Item_stat;
                health += food.Item_stat - 10;
            }
        }

    }
}
