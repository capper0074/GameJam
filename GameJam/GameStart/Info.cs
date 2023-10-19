using GameJam.Graphic;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJam.GameStart
{
    public static class Info
    {
        public static void GameInfo()
        {
            AsciiArt.Ascii_GameInfo();
            Beautifier.CoolPanel("", "Hej og velkommen til dette eventyr"); //Skal laves om
            Console.ReadKey();
            Console.Clear();
        }




    }
}
