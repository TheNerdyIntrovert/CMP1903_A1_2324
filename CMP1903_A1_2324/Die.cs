using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        /*
         * The Die class should contain one property to hold the current die value,
         * and one method that rolls the die, returns and integer and takes no parameters.
         */

        //Fields
        private readonly Random _randomGenerator = new Random(); // Used to generate random numbers for rolling the die.
        private int _numberOfSides; // Integer representation of number of possible outcomes for the die.

        //Properties
        public int CurrentDieValue { get; private set; } //Allows external read access to the current die value.
        public int NumberOfSides //Allows external write access to number of sides of die.
        {
            get 
            {
                return _numberOfSides; // Returns interal private die vakue.
            }

            set
            {
                if (value < 2) // If not considered valid number of sides for a die.
                {
                    throw new ArgumentException(nameof(NumberOfSides), $"Cannot set number of sides to less than 2. (got {value}.)");
                }
                _numberOfSides = value; // Else set private value of sides.  
            }

        }

        //Constructor
        public Die(int numberOfSides = 6) // Parameter sides default = 6.
        {
            this._numberOfSides = numberOfSides;
            this.CurrentDieValue = Roll(); // Method call to ensure that die has CurrentDieValue property assigned.
        }

        //Methods
        public int Roll()
        {
            this.CurrentDieValue = _randomGenerator.Next(1, _numberOfSides + 1); // Assigns random int between range (inclusive, exclusive) to current value.
            return this.CurrentDieValue; // returns current value.
        }
    }
}
