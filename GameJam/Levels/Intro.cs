using GameJam.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJam.Levels
{
    public class Intro
    {
        public void GameIntro()
        {
            Console.Clear();
            Console.WriteLine("Hey");
            Control.Controls();
        }
        
        public static void Bar() //Medium loot (Beer & snus)
        {
            Console.WriteLine("You have entered the bar");
        }

        public static void Street() // Gateway between 'Bar' and 'EnemyMansion' w/ Enemies
        {
            Console.WriteLine("You are now in the streets where enemies will occour");
        }

        public static void EnemyMansion() // Lots of loots (Beer & snus)
        {
            Console.WriteLine("");
        }

        public static void Home() // To deposite loot
        {
            
        }

    }
}
