using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    class Hand
    {
        public bool FirstRound { get; private set; } = true; // set this to false when the user has made the first move
        // this class has a hand of all the dices in the game (5)
        public readonly Dice[] Dices =
        {
            new Dice(),
            new Dice(),
            new Dice(),
            new Dice(),
            new Dice()
        };

        // Now comes the tricky part, I need a new method where the user chooses a set number of dices which then I have to keep and reroll the others. 

        public void KeepDices(int[] toReroll)
        {

            // now we need to go through every dice in the toReroll array and check if it's in Dices array. If it's in the array do nothing with it. If we find a value that is not equal to the toReroll number we have to reroll it

            

            for (int i = 0; i < Dices.Length; i++)
            {
                bool numFound = false;

                foreach (int roll in toReroll)
                {
                    if (Dices[i].NumberOfDice == roll)
                    {
                        numFound = true;
                    }
                }

                if (numFound)
                {
                    continue;
                } else
                {
                    Dices[i].Reroll();
                }


            }

            ShowDices();


            
        }



        public void ShowDices()
        {
            Console.WriteLine();
            foreach (Dice dice in Dices)
            {
                Console.Write("[{0}] ", dice.NumberOfDice);
                FirstRound = false;
            }
            Console.WriteLine();
            Console.WriteLine();

        }

        public void RerollAll()
        {
            foreach (Dice dice in Dices)
            {
                dice.Reroll();
            }

            // display all dices after the are rerolled
            ShowDices();

        }

        
    }
}
