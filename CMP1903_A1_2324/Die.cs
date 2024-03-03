using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        // Fields
        private static Random _randomGenerator = new Random();
        private int _numberOfSides;

        // Properties
        public int CurrentDieValue { get; private set; }
        public int NumberOfSides
        {
            get
            {
                return _numberOfSides;
            }

            set
            {
                if (value < 2)
                {
                    throw new ArgumentException(nameof(NumberOfSides), $"Cannot set number of sides to less than 2. (got {value}.)");
                }
                _numberOfSides = value;
            }

        }

        // Constructor
        public Die(int numberOfSides = 6)
        {
            this._numberOfSides = numberOfSides;
            this.CurrentDieValue = Roll();
        }

        // Methods
        public int Roll()
        {
            this.CurrentDieValue = _randomGenerator.Next(1, _numberOfSides + 1);
            return this.CurrentDieValue;
        }
    }
}

