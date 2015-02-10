using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPgame
{
    public class Hero: GameCharacterFactory
    {
        protected override GameCharacter createCharacter(string type)
        {
            if(type.Equals("Fuzzy Puppy"))
            {
                return new FuzzyPuppy();
            }
            else if(type.Equals("Chubby Chipmunk"))
            {
                return new ChubbyChipmunk();
            }
            else if(type.Equals("Cuddly Kitten"))
            {
                return new CuddlyKitten();
            }
            else if(type.Equals("Wise Owl"))
            {
                return new WiseOwl();
            }
            else if(type.Equals("Tiny Turtle"))
            {
                return new TinyTurtle();
            }
            else if(type.Equals("Darling Duckling"))
            {
                return new DarlingDuckling();
            }
            else
            {
                return null;
            }
        }
    }
}
