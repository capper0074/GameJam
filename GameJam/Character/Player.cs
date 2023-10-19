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
                Name = "";
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

        public static bool Eat(Items food) //Denne metode skal laves om, der er alt for mange if statements Det er lort lavet haha
        {
            int tempHealth = Health + food.HealthStat;
            int tempStamina = Stamina + food.StaminaStat;

            if (tempHealth < 100 && tempStamina < 100)
            {
                Console.Clear();
                AsciiArt.Ascii_StatIncrease();
                Beautifier.CoolLine();
                Health += food.HealthStat;
                Stamina += food.StaminaStat;
                Beautifier.CoolWrite("purple", $"Your Health have increased by {food.HealthStat}");
                Beautifier.CoolWrite("purple", $"Your Stamina have increased by {food.StaminaStat}");
                Console.ReadLine();
                return true;
            }
            else if(tempHealth >= 100 && tempStamina >= 100)
            {
                Console.Clear();
                AsciiArt.Ascii_GameInfo();
                Beautifier.CoolLine();
                Beautifier.CoolWrite("red", "Are you sure, you want to eat this \n if u do your stats will ecsead 100 \n therefor it will be be resat to 100");
                string playerChoice = Beautifier.CoolMenu("", "Yes", "No");

                if(playerChoice == "Yes")
                {
                    Health = 100;
                    Stamina = 100;
                    Beautifier.CoolWrite("purple", "Your stats have been resat at 100");
                    return true;

                }
                else if(playerChoice == "No")
                {
                    Beautifier.CoolWrite("purple", "Your stats are as they were before");
                    return false;
                }
                else //Kommer aldrig herned skal lige fixes
                {
                    return false;
                }
            }
            else if(tempHealth < 100 && tempStamina > 100)
            {
                Console.Clear();
                AsciiArt.Ascii_GameInfo();
                Beautifier.CoolLine();
                Beautifier.CoolWrite("red", "Are you sure, you want to eat this \n if u do your Stamina will go over 100 \n and therfor it will be resat at 100");
                string playerChoice = Beautifier.CoolMenu("", "Yes", "No");

                if (playerChoice == "Yes")
                {
                    Health += food.HealthStat;
                    Stamina = 100;
                    Beautifier.CoolWrite("purple", $"Your Health have increased by {food.HealthStat}");
                    Beautifier.CoolWrite("purple", "Your Stamina stat have been resat at 100");
                    return true;

                }
                else if (playerChoice == "No")
                {
                    Beautifier.CoolWrite("purple", "Your stats are as they were before");
                    return false;
                }
                else //Kommer aldrig herned skal lige fixes
                {
                    return false;
                }
            }
            else if (tempHealth > 100 && tempStamina < 100)
            {
                Console.Clear();
                AsciiArt.Ascii_GameInfo();
                Beautifier.CoolLine();
                Beautifier.CoolWrite("red", "Are you sure, you want to eat this \n if u do your Health will go over 100 \n and therfor it will be resat at 100");
                string playerChoice = Beautifier.CoolMenu("", "Yes", "No");

                if (playerChoice == "Yes")
                {
                    Health = 100;
                    Stamina = food.StaminaStat;
                    Beautifier.CoolWrite("purple", $"Your Stamina have increased by {food.StaminaStat}");
                    Beautifier.CoolWrite("purple", "Your Health stat have been resat at 100");
                    return true;

                }
                else if (playerChoice == "No")
                {
                    Beautifier.CoolWrite("purple", "Your stats are as they were before");
                    return false;
                }
                else //Kommer aldrig herned skal lige fixes
                {
                    return false;
                }
            }
            else //Der skal kontrolleres for hvis kun en af parameterne overskrider 100
            {
                return false;
            }


            Console.Clear();
            AsciiArt.Ascii_StatIncrease();
            Beautifier.CoolLine();
            //Beautifier.CoolWrite("purple", $"Your Health have increased by {food.Item_stat}");
            //Beautifier.CoolWrite("purple", $"Your Stamina have increased by {food.Item_stat}");
        }

    }
}
