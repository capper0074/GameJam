using GameJam.Character;
using GameJam.Combat;
using GameJam.Graphic;
using GameJam.Stuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJam.Fight
{
    public static class CombatTing
    {
        public static void Start_Combat(string def)//hvaaaaaa
        {
            AsciiArt.Ascii_GameCombat();
            Beautifier.CoolLine();
            int i = 1;

            Creatures currentCreature = Enemy.Enemy_Pick(def);

            bool game_State = true;

            
            Beautifier.CoolWrite("purple","The combat starts");
            Beautifier.CoolWrite("purple", "You are up aginst: " + currentCreature.Name + " Good luck");
            Console.ReadLine();
            Console.Clear();

            while (game_State == true)
            {
                AsciiArt.Ascii_GameCombat();
                Beautifier.CoolLine();
                if (Player.Health >= 1)
                {
                    if (currentCreature.EnemyHealth >= 1 || currentCreature.EnemyHealth - WeaponSlot.DisplayStat() > 0)//lort
                    {
                        Console.WriteLine("This is round: " + i);

                        Console.WriteLine("You attack fitst with: " + WeaponSlot.DisplayName() + "And you deal: " + WeaponSlot.DisplayStat());
                        currentCreature.EnemyHealth -= WeaponSlot.DisplayStat();
                        Beautifier.CoolBarCombat(Player.Health, Player.Name);
                        Console.ReadLine();

                        Console.WriteLine("The enemy attacks you back with: " + currentCreature.EnemyAttack + " Damage");
                        Player.Health -= currentCreature.EnemyAttack;
                        Beautifier.CoolBarCombat(currentCreature.EnemyHealth, currentCreature.Name);
                        Console.ReadLine();

                        Console.Clear();

                        i++;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You won the combat stupid :)");
                        //Inventory.AddToInventory(LootTable.GetLoot());
                        game_State = false;
                    }

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You have died");
                    Console.WriteLine("What a noob");
                    game_State = false; //If loosing the battle to we restart?
                }
            }

        }
    }
}
