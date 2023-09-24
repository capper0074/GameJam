using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJam.Stuff
{
    public static class LootTable
    {
        private static bool isInitialize; // Is automatically false when given no value for a bool variable

        private static List<Items> lootTable;

        public static void Initialize()
        {
            if (isInitialize)
            {
                return;
            }

            lootTable = new List<Items>();

            if (!isInitialize)
            {

                Items beer = new Items("Beer", 20);
                Items snus = new Items("Snus", 25);
                lootTable.Add(beer);
                lootTable.Add(snus);

                isInitialize = true;
            }

        }

        public static Items GetLoot()
        {
            Random rnd = new Random();

            int num = rnd.Next(0, lootTable.Count + 1);

            return lootTable[num];
        }

    }
}
