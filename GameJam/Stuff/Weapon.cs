using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJam.Stuff
{
    public class Weapon
    {
        public string Name { get; set; }

        public int WeaponAttack { get; set; }

        public int WeaponCrit { get; set; }

        public Weapon (String name, int weapon_Attack, int weaponCrit)
        {
            Name = name;
            WeaponAttack = weapon_Attack;
            WeaponCrit = weaponCrit;

        }



    }
}
