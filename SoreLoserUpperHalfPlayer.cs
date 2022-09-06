using System;


namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who always rolls in the upper half of their possible role and
    //  who throws an exception when they lose to the other player
    public class SoreLoserUpperHalfPlayer : Player
    {
      public override int Roll()
        {
            // Return a random number between 1 and DiceSize
            return new Random().Next(DiceSize) + DiceSize / 2;
        }
    }
}