using System;

namespace SharedConst
{
    public static class Constants
    {
        //UITexts
        public const string availableAction = "Rock(R) Paper(P) Scissors(S)";
        public const string wrongAction = "Wrong action!";
        public const string playerName = "Write name: ";
        public const string playerDraw = "It's a draw!";

        public static string getAction(string name)
        {
            string text = name + " action: ";
            return text;
        }

        public static string getWin(string name)
        {
            string text = name + " Wins!";
            return text;
        }

        //Available actions
        public const int actionsNumber = 3;
        public const char rock = 'R';
        public const char paper = 'P';
        public const char scissors = 'S';

        //Game results
        public const char draw = 'D';
    }
}
