using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DPgame
{
    public class MonsterParty: Party
    {
        private MonsterFactory monsters;

        public MonsterParty()
        {
            monsters = new MonsterFactory();
        }

        public override void initParty()
        {
            GameCharacter m1 = monsters.createCharacter();
            GameCharacter m2 = monsters.createCharacter();
            GameCharacter m3 = monsters.createCharacter();

            Characters.AddFirst(m3);
            Characters.AddFirst(m2);
            Characters.AddFirst(m1);                        
        }
    }
}
