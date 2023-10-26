using GameJam.Graphic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameJam.Controls;

namespace GameJam.Levels
{
    public static class House
    {
        public static void StrangeRoom()
        {
            Beautifier.CoolWrite("green", "Narator", "white", "bla bla");
            Console.ReadLine();
            Beautifier.CoolWrite("green", "Narator", "white", "suddenly, You hear some strange sounds outside the door");
            Console.ReadLine();

            string playerChoice = Beautifier.CoolMenu("Do you want to see what the noices comes from?", "Yes", "Nej");

            if (playerChoice == "Yes")
            {

            }
            else if(playerChoice == "No")
            {
                Beautifier.CoolWrite("green", "Narator", "white", "U decide not to see where the noices comes from");
                Console.ReadLine();
                Beautifier.CoolWrite("green", "Narator", "white", "U just hop back in bed, and just hope its a wierd dream");
                Console.ReadLine();

                Control.Controls();
                TheBed();
            }

        }

        public static void Hallway()
        {

        }

        private static void TheBed()
        {

        }
    }
}
