using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPgame
{
    public class FuzzyPuppy : GameCharacter
    {
        public FuzzyPuppy()
        {
            Name = "Fuzzy Puppy";
            HealthPoints = 100;
            AttackSpeed = 8;
            MaxDamage = 90;
            MinDamage = 40;
            HitChance = .4;
            //DefenseChance = ;
        }
    }
}
