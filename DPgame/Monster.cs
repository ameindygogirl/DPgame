using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPgame
{
    public class Monster: GameCharacterFactory
    {
        protected override GameCharacter createCharacter(string type)
        {
            if(type.Equals("Fierce Lion"))
            {
                return new FierceLion();
            }
            else if(type.Equals("Slithering Snake"))
            {
                return new SlitheringSnake();
            }
            else if(type.Equals("Scary Shark"))
            {
                return new ScaryShark();
            }
            else if(type.Equals("Crooked Vulture"))
            {
                return new CrookedVulture();
            }
            else if(type.Equals("Stealthy Spider"))
            {
                return new StealthySpider();
            }
            else if(type.Equals("Deadly Dinosaur"))
            {
                return new DeadlyDinosaur();
            }
            else
            {
                return null;
            }
        }
    }
}
