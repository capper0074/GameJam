using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJam.Combat
{
    public static class Enemy
    {
        private static bool isInitialize;

        private static List<Creatures> enemies;

        public static void Initialize()
        {
            if(isInitialize)
            {
                return;
            }

            enemies = new List<Creatures>();

            if (!isInitialize)
            {

                Creatures møller = new Creatures("Møller", 1, 10); // Base stats. > modified later
                Creatures drunkPeter = new("Drunk Peter",3, 15);
                Creatures wonderWoman = new("Wonder Woman", 1, 12);
                Creatures randomGuy = new("Random Guy", 4, 10);

                enemies.Add(møller);
                enemies.Add(drunkPeter);
                enemies.Add(wonderWoman);
                enemies.Add(randomGuy);
                isInitialize = true;
            }
        }


        public static Creatures Enemy_Pick(string dif)
        {
            Random rnd = new Random();
            int num = rnd.Next(0, enemies.Count);
            if (dif == "Esay")
            {
                enemies[num].Enemy_Health += 0;
                enemies[num].Attack_Value += 0;
                return enemies[num];
            }

            if (dif == "Moderate")
            {

                enemies[num].Enemy_Health += 0;
                enemies[num].Attack_Value += 0;
                return enemies[num];
            }

            if (dif == "Difficult")
            {

                enemies[num].Enemy_Health += 0;
                enemies[num].Attack_Value += 0;
                return enemies[num];
            }

            if (dif == "Hard")
            {

                enemies[num].Enemy_Health += 0;
                enemies[num].Attack_Value += 0;
                return enemies[num];
            }

            return null;

        }

    }
}
