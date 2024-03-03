using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        public static void RunTests()
        {
            // Test the Die class
            TestDieClass();

            // Test the Game class
            TestGameClass();
        }

        private static void TestDieClass()
        {
            // Create a Die object
            Die die = new Die();

            // Roll the die
            int roll = die.Roll();

            // Verify die roll is between 1 and 6 (inclusive)
            Debug.Assert(roll >= 1 && roll <= 6, $"Die roll value {roll} is not between 1 and 6.");
        }

        private static void TestGameClass()
        {
            // Create a Game object
            Game game = new Game();

            // Roll the dice
            game.RollDice();

            // Verify the sum of the three values is as expected
            int expectedSum = game.LastRollsList.Sum();
            Debug.Assert(game.TotalSum == expectedSum, $"Total sum {game.TotalSum} does not match expected sum {expectedSum}.");
        }
    }
}