using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJam.Combat
{
    public class Creatures
    {
        public string Name { get; set; }
        public int EnemyAttack { get; set; }
        public int EnemyHealth { get; set; }

        public Creatures(string name, int attack_Value, int enemy_Health)
        {
            Name = name;
            EnemyAttack = attack_Value;
            EnemyHealth = enemy_Health;
        }
    }
}
