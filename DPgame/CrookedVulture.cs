using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPgame
{
    public class CrookedVulture: GameCharacter
    {
        public CrookedVulture()
        {
            Name = "Crooked Vulture";
            HealthPoints = 70;
            AttackSpeed = 5;
            MaxDamage = 30;
            MinDamage = 15;
            HitChance = .8;
            //DefenseChance = ;
        }
    }
}
