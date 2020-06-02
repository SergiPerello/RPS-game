using System;
using SharedConst;

namespace RockPaperScissorsBackEnd
{
    public class Match
    {
        public Match(string playerOneName, string playerTwoName, char playerOneAction, char playerTwoAction)
        {
            Player playerOne = new Player(playerOneName,playerOneAction);
            Player playerTwo = new Player(playerTwoName,playerTwoAction);
            DiscoverWinner(playerOne, playerTwo);
        }

        void DiscoverWinner(Player playerOne, Player playerTwo)
        {
            Rules rules = new Rules();
            int playerOneAction = 0;
            int playerTwoAction = 0;
            for (int i = 0; i < Constants.actionsNumber; i++)
            {
                if (playerOne.action == rules.index[i])
                {
                    playerOneAction = i;
                }
                if (playerTwo.action == rules.index[i])
                {
                    playerTwoAction = i;
                }
            }
            char result = rules.rulesTable[playerOneAction, playerTwoAction];
            if (result == playerOne.action)
            {
                Console.WriteLine(Constants.getWin(playerOne.name));
            }
            else if (result == playerTwo.action)
            {
                Console.WriteLine(Constants.getWin(playerTwo.name));
            }
            else
            {
                Console.WriteLine(Constants.playerDraw);
            }
        }
    }
}
