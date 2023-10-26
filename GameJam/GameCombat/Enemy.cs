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

                Creatures møller = new Creatures("Møller", 1, 25); // Base stats. > modified later
                Creatures drunkPeter = new("Drunk Peter",3, 45);
                Creatures wonderWoman = new("Wonder Woman", 1, 32);//The fuck
                Creatures randomGuy = new("Random Guy", 4, 30);

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
                enemies[num].EnemyHealth += 0;
                enemies[num].EnemyAttack += 0;
                return enemies[num];
            }

            if (dif == "Moderate")
            {

                enemies[num].EnemyHealth += 5;
                enemies[num].EnemyAttack += 1;
                return enemies[num];
            }

            if (dif == "Difficult")
            {

                enemies[num].EnemyHealth += 10;
                enemies[num].EnemyAttack += 4;
                return enemies[num];
            }

            if (dif == "Hard")
            {

                enemies[num].EnemyHealth += 20;
                enemies[num].EnemyAttack += 8;
                return enemies[num];
            }

            return null;

        }

    }
}
