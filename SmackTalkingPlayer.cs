using System;
namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer
    {
        public string Taunt { get; }

        SmackTalkingPlayer(string taunt)
        {
            Taunt = taunt;
        }
        public void Shout()
        {
            Console.WriteLine(Taunt);
        }

    }
}