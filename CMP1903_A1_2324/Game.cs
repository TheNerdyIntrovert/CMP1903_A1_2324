using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        // Fields
        private Die[] _diceList = new Die[3];

        // Properties
        public int[] LastRollsList { get; private set; }
        public int TotalSum { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Game"/> class.
        /// </summary>
        public Game()
        {
            // Initialize the list of dice and the list of last rolls
            this.LastRollsList = new int[3];
            this.TotalSum = 0;

            // Create three dice objects with default 6 sides
            for (int i = 0; i < _diceList.Length; i++)
            {
                this._diceList[i] = new Die(6);
            }
        }

        /// <summary>
        /// Rolls all dice, calculates total sum, and reports results.
        /// </summary>
        public void RollDice()
        {
            // Clear the list of last rolls and reset total sum
            this.TotalSum = 0;

            // Roll each die, record the result, and calculate total sum
            for (int i = 0; i < this._diceList.Length; i++)
            {
                int rollResult = _diceList[i].Roll();

                this.LastRollsList[i] = rollResult;
                this.TotalSum += rollResult;
            }

            // Report the results of the last rolls and the total sum
            this.ReportLastRolls();
            this.ReportTotalSum();
        }

        /// <summary>
        /// Reports the results of the last rolls.
        /// </summary>
        public void ReportLastRolls()
        {
            Console.WriteLine("Game rolls:");
            for (int i = 0; i < this._diceList.Length; i++)
            {
                Console.WriteLine($"Die {i + 1}: {this._diceList[i].CurrentDieValue}");
            }
        }

        /// <summary>
        /// Reports the total sum of the last rolls.
        /// </summary>
        public void ReportTotalSum()
        {
            Console.WriteLine($"Total of the last roll: {this.TotalSum}");
        }
    }
}