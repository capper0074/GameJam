using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJam.Stuff
{
    public class Items
    {
        public string Name { get; set; }

        public int HealthStat { get; set; }

        public int StaminaStat { get; set; }

        public Items(string name, int healthStat, int staminaStat)
        {
            Name = name;
            HealthStat = healthStat;
            StaminaStat = staminaStat;
        }

    }
}
