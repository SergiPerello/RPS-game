using System;
using System.Collections.Generic;
using System.Text;
using SharedConst;

namespace RockPaperScissorsBackEnd
{
    class Rules
    {
        static char d = Constants.draw;
        static char r = Constants.rock;
        static char p = Constants.paper;
        static char s = Constants.scissors;
        public char[] index = new char[] { Constants.rock, Constants.paper, Constants.scissors };
        public char[,] rulesTable = new char[Constants.actionsNumber, Constants.actionsNumber] {
            { d, p, r },
            { p, d, s },
            { r, s, d } };
    }
}
