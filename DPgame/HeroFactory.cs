using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DPgame
{
    public class HeroFactory: GameCharacterFactory
    {
        private int LIMIT = 7;

        public override GameCharacter createCharacter()
        {
            int option = getOption();
            GameCharacter hero = null;
            switch (option)
            {
                case 1:
                    hero = new ChubbyChipmunk();
                    break;
                case 2:
                    hero = new CuddlyKitten();
                    break;
                case 3:
                    hero = new DarlingDuckling();
                    break;
                case 4:
                    hero = new FuzzyPuppy();
                    break;
                case 5:
                    hero = new TinyTurtle();
                    break;
                case 6:
                    hero = new WiseOwl();
                    break;
            }
            Console.Write("Please give " + hero.Name + " a name: ");
            hero.Name = getName();
            return hero;
        }

        private int getOption()
        {
            int option = 0;
            while (option <= 0 || option >= LIMIT)
            {
                Console.WriteLine("Please choose character\n");
                Console.WriteLine("\t1. Chubby Chipmunk\n" +
                                  "\t2. Cuddly Kitten\n" +
                                  "\t3. Darling Duckling\n" +
                                  "\t4. Fuzzy Puppy\n" +
                                  "\t5. Tiny Turtle\n" +
                                  "\t6. Wise Owl");
                //"\t7. Go back");

                string input = Console.ReadLine();

                if (int.TryParse(input, out option) == true && (option >= 1 && option < LIMIT))
                {
                    option = int.Parse(input);
                }
                else
                    Console.WriteLine("\nInvalid input");
            }
            return option;
        }
        private String getName()
        {
            String name = Console.ReadLine();
            if (name.Length > 8)
                return name.Substring(0, 8);
            return name;
        }
    }
}
