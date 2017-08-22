using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    // This is the dice class which represents a single dice

    class Dice
    {
        // static random so every dice object can use it.
        private static readonly Random rng = new Random();

        public int NumberOfDice { get; private set; }


        public Dice()
        {
            NumberOfDice = rng.Next(1, 7);
        }

        

        public void Reroll()
        {
            NumberOfDice = rng.Next(1, 7);
        }



    }
}
