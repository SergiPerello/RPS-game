using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsBackEnd
{
    class Player
    {
        public string name { get; set; }
        public char action { get; set; }
        public Player(string playerName, char playerAction)
        {
            this.name = playerName;
            this.action = playerAction;
        }
    }
}
