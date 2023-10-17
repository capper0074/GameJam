using GameJam.Character;
using GameJam.GameStart;
using GameJam.Graphic;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJam.Controls
{
    public static class Control
    {
        public static void Controls() //Should popup when the player needs to do something
        {

            Console.Clear();


            bool state = true;

            while (state == true)
            {
                AsciiArt.Ascii_Stats();
                Beautifier.CoolLine();

                string playerChoice = AnsiConsole.Prompt(new SelectionPrompt<string>()
                    .Title("What do u want to do?")
                    .PageSize(6)
                    .AddChoices("See your stats", "Continue", "See your inventory", "See your weapon", "Exit the game"));

                if (playerChoice == "See your stats") //See stats
                {
                    Player.Display_Stats();
                    Console.ReadLine();
                    Console.Clear();

                }
                else if (playerChoice == "Continue") //Move Command
                {
                    Console.Clear();
                    Run.Game_Tick();
                    state = false;

                }
                else if (playerChoice == "See your inventory") //Inventory
                {
                    Inventory.DisplayInventory();
                    Console.ReadLine();
                    Console.Clear();

                }
                else if (playerChoice == "See your weapon")
                {
                    WeaponSlot.DisplayCurrentWeapon();
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (playerChoice == "Exit the game") //Exit
                {
                    state = false;
                    Console.Clear();
                    Environment.Exit(0);

                }

            }
        }
    }
}
