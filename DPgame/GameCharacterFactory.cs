using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPgame
{
    public abstract class GameCharacterFactory
    {
        public GameCharacter chooseCharacter(string type)
        {
            GameCharacter gc;
            gc = createCharacter(type);
            return gc;
        }
        protected abstract GameCharacter createCharacter(string type);
    }
}
