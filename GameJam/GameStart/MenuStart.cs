using GameJam.Character;
using GameJam.Graphic;
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

            bool state = true;

            while (state == true)
            {
                //Sound.BeerRun();
                Console.Clear();
                AsciiArt.Ascii_Name();
                //Ascii_Art.Ascii_GameStart();
                //Made a new menu system, so we can iteract with it.
                string playerChoice = Beautifier.CoolMenu("Welcome to the beer game", "Start the game", "Exit the game");

                bool loopStage = true;

                int nameCounter = 0;

                if (playerChoice == "Start the game")
                {
                    Console.Clear();
                    Info.GameInfo();
                    AsciiArt.Ascii_GameStart();
                    Beautifier.CoolLine();
                    Beautifier.CoolCenterLine("Just so you know, you only have 3 tries to do this", "blue");
                    Console.ReadLine();
                    Console.Clear();

                    while (loopStage == true)
                    {
                        AsciiArt.Ascii_GameStart();
                        Beautifier.CoolLine();
                        Beautifier.CoolCenterLine($"You have {3 - nameCounter} tries left", "red");
                        Beautifier.CoolCenterLine("Hvad hedder du?", "blue");
                        Player.Name = Console.ReadLine();
                        
                        if (nameCounter == 2)
                        {
                            Beautifier.CoolCenterLine("You fucking idiot, you did not have enough brain cells so your name are now idiot", "red");
                            Player.Name = "Idiot";
                            loopStage = false;
                            Console.ReadLine();
                        }
                        else if (Player.Name == "")
                        {
                            Console.WriteLine("Er du dum? Skriv dit navn!");
                            nameCounter++;
                            loopStage = true;
                            Console.Clear();
                        }
                        else
                        {
                            loopStage = false;
                            nameCounter++;
                            Console.Clear();
                        }
                    }

                    Console.Clear();
                    state = false;
                    Intro.GameIntro();
                }
                else if (playerChoice == "Exit the game")
                {
                    state = false;
                    Console.Clear();
                    Environment.Exit(0);
                    //SendKeys.SendWait("{ENTER}");

                }
            }
        }

    }
}
