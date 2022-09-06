using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        List<string> _TauntList = new List<string>
        {
            "Yo mother was a hamster",
            "yo Daddy was reAAal short",
            "welcome",
        };

        public void RandomTaunt()
        {
            int rnd = new Random().Next(_TauntList.Count);
            Console.WriteLine(_TauntList[rnd]);
        }
    }
}