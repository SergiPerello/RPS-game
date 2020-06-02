using System;
using RockPaperScissorsBackEnd;
using SharedConst;

namespace RockPaperScissorsFrontEnd
{
    class Frontend
    {
        static void Main(string[] args)
        {
            string playerOneName = SetPlayerName();
            string playerTwoName = SetPlayerName();

            //10 calls
            Controller(playerOneName, playerTwoName);
            Controller(playerOneName, playerTwoName);
            Controller(playerOneName, playerTwoName);
            Controller(playerOneName, playerTwoName);
            Controller(playerOneName, playerTwoName);
            Controller(playerOneName, playerTwoName);
            Controller(playerOneName, playerTwoName);
            Controller(playerOneName, playerTwoName);
            Controller(playerOneName, playerTwoName);
            Controller(playerOneName, playerTwoName);
        }
        private static void Controller(string playerOneName, string playerTwoName)
        {
            char playerOneAction = SetPlayerAction(playerOneName);
            char playerTwoAction = SetPlayerAction(playerTwoName);

            var match = new Match(playerOneName, playerTwoName, playerOneAction, playerTwoAction);
        }

        private static string SetPlayerName()
        {
            Console.WriteLine(Constants.playerName);
            string playerName = Console.ReadLine();
            return playerName;
        }

        private static char SetPlayerAction(string name)
        {
            Console.WriteLine(Constants.availableAction);
            Console.WriteLine(Constants.getAction(name));
            char playerAction = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();
            while (playerAction != Constants.rock && playerAction != Constants.scissors && playerAction != Constants.paper)
            {
                Console.WriteLine(Constants.wrongAction);
                Console.WriteLine(Constants.availableAction);
                playerAction = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();
            }
            return playerAction;
        }
    }
}
