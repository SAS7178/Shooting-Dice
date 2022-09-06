using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player whose role will always be in the upper half of their possible rolls
    public class UpperHalfPlayer : Player
    {
        public override int Roll()
        {
            // Return a random number between 1 and DiceSize
            return new Random().Next(DiceSize / 2, DiceSize) + 1;
        }
           public override void Play(Player other)
        {
            {
                // Call roll for "this" object and for the "other" object
                int myRoll = Roll();
                int otherRoll = other.Roll();
                try
                {
                    Console.WriteLine($"{Name} rolls a {myRoll}");
                    Console.WriteLine($"{other.Name} rolls a {otherRoll}");
                    if (myRoll > otherRoll)
                    {
                        Console.WriteLine($"{Name} Wins!");
                    }

            else if (myRoll < otherRoll)
                {
                    throw new Exception();
                }
                else
                {
                    // if the rolls are equal it's a tie
                    Console.WriteLine("It's a tie");
                }
                }
                catch(Exception)
                {
                    Console.WriteLine("You Looooooooooseeer!!");
                }
            }
        }
    }
}