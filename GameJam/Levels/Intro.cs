using GameJam.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameJam.Fight;
using System.Runtime.InteropServices;
using GameJam.Graphic;

namespace GameJam.Levels
{
    public static class Intro
    {
        public static void GameIntro()
        {
            Console.Clear();
            AsciiArt.Ascii_GameIntro();
            Beautifier.CoolLine();

            Beautifier.CoolWrite("green", "Narator", "white", "You find your self in a strange house");
            Console.ReadLine();
            Beautifier.CoolWrite("green", "Narator", "white", "The last thing you remember is that u where out drinking");
            Console.ReadLine();
            Beautifier.CoolWrite("green", "Narator", "white", "U get up from you bed and look around the room");
            Console.ReadLine();

            Control.Controls();

            House.StrangeRoom();
        }


    }
}
