using GameJam.Character;
using GameJam.Combat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJam.GameStart
{
    public static class Run
    {

        public static void Game_Tick()
        {
            Player.Tick_Stamina();
        }

        public static void StartGame()
        {
            Enemy.Initialize();
            WeaponSlot.Initialize();
            Player.Initialize();
            Inventory.Initialize();

            MenuStart.Menu();

        }

    }
}
