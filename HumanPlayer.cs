using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A player that prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override int Roll()
        {
            Console.WriteLine("Enter a number of (1-6) for roll");
            int chosenHumanRoll = int.Parse(Console.ReadLine());
             return chosenHumanRoll;
        }
    }
}