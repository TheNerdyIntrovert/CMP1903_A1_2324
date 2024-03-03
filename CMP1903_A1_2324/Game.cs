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
        private List<Die> _diceList;

        // Properties
        public List<int> LastRollsList { get; private set; }
        public int TotalSum { get; private set; }

        // Constructor
        public Game()
        {
            // Initialize the list of dice and the list of last rolls
            this._diceList = new List<Die>();
            this.LastRollsList = new List<int>();
            this.TotalSum = 0;

            // Create three dice objects with default 6 sides
            for (int i = 0; i < 3; i++)
            {
                this._diceList.Add(new Die());
            }
        }

        // Method to roll all dice, calculate total sum, and report results
        public void RollDice()
        {
            // Clear the list of last rolls and reset total sum
            this.LastRollsList.Clear();
            this.TotalSum = 0;

            // Roll each die, record the result, and calculate total sum
            foreach (Die dieObject in this._diceList)
            {
                int rollResult = dieObject.Roll();
                this.LastRollsList.Add(rollResult);
                this.TotalSum += rollResult;
            }

            // Report the results of the last rolls and the total sum
            this.ReportLastRolls();
            this.ReportTotalSum();
        }

        // Method to report the results of the last rolls
        public void ReportLastRolls()
        {
            Console.WriteLine("Last rolls:");
            for (int i = 0; i < this._diceList.Count; i++)
            {
                Console.WriteLine($"Die {i + 1}: {this._diceList[i].CurrentDieValue}");
            }
        }

        // Method to report the total sum of the last rolls
        public void ReportTotalSum()
        {
            Console.WriteLine($"Total of the last roll: {this.TotalSum}");
        }
    }
}
