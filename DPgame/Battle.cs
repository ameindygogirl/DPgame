using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DPgame
{
    public class Battle
    {
        private HeroParty heroes;
        private Party monsters;
        private GameCharacterList turnList;

        public HeroParty Heroes
        {
            get { return heroes; }
            set { heroes = value; }
        }
        public Party Monsters
        {
            get { return monsters; }
            set { monsters = value; }
        }
        private GameCharacterList TurnList
        {
            get { return turnList; }
            set { turnList = value; }
        }

        public void start()
        {
            LinkedListNode<GameCharacter> primary = turnList.First;
            Action action = null;
            initTurnList();

            while(heroes.isDead() == false && monsters.isEmpty() == false)
            {
                action = primary.Value.takeAction();
                action.Characters = turnList;
                action.chooseTarget();
                
                //action.update();
                if(confirmAction(action) == true)
                {
                    action.execute();
                    primary = primary.Next;
                }
            }

            if (heroes.isDead())
            {
                Console.WriteLine("Game Over");
            }
            else
            {
                Console.WriteLine("Enemies defeated");
            }
        }

        private void initTurnList()
        {
            GameCharacterList allCharacters = new GameCharacterList();
            foreach (GameCharacter gc in heroes.Characters)
            {
                allCharacters.AddFirst(gc);
            }
            foreach (GameCharacter gc in monsters.Characters)
            {
                allCharacters.AddFirst(gc);
            }
            allCharacters.sort();
            turnList = allCharacters;
        }

        private Boolean confirmAction(Action action)
        {
            if(action.Primary is Monster)
                return true;

            Console.WriteLine(action.ToString() + "? (y/n)");
            String confirm = Console.ReadLine();
            if (confirm.ToLower().CompareTo("y") == 0)
                return true;

            return false;
        }
    }
}
