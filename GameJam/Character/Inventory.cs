using GameJam.Graphic;
using GameJam.Stuff;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJam.Character
{
    public static class Inventory
    {
        private static bool isInitialize;

        private static List<Items> inventory;

        public static void Initialize()
        {
            if (isInitialize)
            {
                return;
            }

            inventory = new List<Items>();

            if (inventory.Count == 0)
            {
                Items cookie = new Items("Cookie", 5, 10);
                inventory.Add(cookie);

                Items empty_slot = new Items("Empty_Slot", 0, 0);

                for (int i = 0; i < 6; i++)
                {
                    inventory.Add(empty_slot);
                }

                isInitialize = true;
            }

        }

        public static void DisplayInventory()
        {
            Console.Clear();
            AsciiArt.Ascii_Inventory();
            Beautifier.CoolLine();
            Console.WriteLine("This is your inventory");

            Beautifier.CoolPanel("", $"{inventory[0].Name}\n{inventory[1].Name}\n{inventory[2].Name}\n{inventory[3].Name}\n{inventory[4].Name}\n{inventory[5].Name}\n{inventory[6].Name}");
            //Beautifier.CoolPanel("", $"{inventory[0].Item_stat}\n{inventory[1].Item_stat}\n{inventory[2].Item_stat}\n{inventory[3].Item_stat}\n{inventory[4].Item_stat}\n{inventory[5].Item_stat}\n{inventory[6].Item_stat}");


            bool inv_State = true;
            while (inv_State == true)
            {
                var player_Answer = AnsiConsole.Prompt(new SelectionPrompt<string>()
                    .Title("Do you want to use anything from your inventroy\n ---------------------------")
                    .PageSize(3)
                    .AddChoices("yes", "no"));

                if (player_Answer == "yes")
                {
                    Console.Clear();

                    bool player_state = true;

                    while (player_state == true)
                    {
                        Console.WriteLine("What do you want from your inventory");
                        Beautifier.CoolLine();
                        var inv_index = AnsiConsole.Prompt(new SelectionPrompt<string>()
                            .PageSize(7)
                            .AddChoices(inventory[0].Name, inventory[1].Name, inventory[2].Name, inventory[3].Name, inventory[4].Name, inventory[5].Name, inventory[6].Name));

                        if (inv_index == "Empty_Slot")
                        {
                            Console.Clear();
                            Beautifier.CoolWrite("red", "U dont have anything in that slot"); //this can add color to your text
                            player_state = true;
                        }
                        else if (inv_index != "Empty_Slot")
                        {
                            int index = inventory.FindIndex(item => item.Name == inv_index);
                            PickFromInventory(inventory[index]);
                            player_state = false;
                        }


                    }
                    inv_State = false;
                }
                else if (player_Answer == "no")
                {
                    inv_State = false;
                    Console.Clear();
                }
            }

        }

        public static void AddToInventory(Items item)
        {

            for (int i = 0; i < inventory.Count; i++)
            {
                if (inventory[i].Name == "Empty_Slot")
                {
                    inventory.Add(item);
                }
            }
        }

        private static void PickFromInventory(Items item)
        {

            Player.Eat(item);
            inventory.Remove(item);
            Items empty_slot = new Items("Empty_Slot", 0, 0);
            inventory.Add(empty_slot);

        }
    }
}
