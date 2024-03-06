using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Creating and playing a game from Game class
            Game game = new Game();
            game.RollDice();

            // Run tests
            Testing.RunTests();
            Console.WriteLine("Testing completed.");

            Console.ReadLine();
        }
    }
}


