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

        /// <summary>
        /// Initializes a new instance of the <see cref="Die"/> class with the specified number of sides.
        /// </summary>
        /// <param name="numberOfSides">The number of sides on the die. Defaults to 6.</param>
        public Die(int numberOfSides = 6)
        {
            this._numberOfSides = numberOfSides;
            this.CurrentDieValue = Roll();
        }

        /// <summary>
        /// Rolls the die and returns the result.
        /// </summary>
        /// <returns>The value rolled on the die.</returns>
        public int Roll()
        {
            this.CurrentDieValue = _randomGenerator.Next(1, _numberOfSides + 1);
            return this.CurrentDieValue;
        }
    }
}
