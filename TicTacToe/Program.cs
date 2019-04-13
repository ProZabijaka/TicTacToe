using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            string NamePlayer1 = "";
            string NamePlayer2 = "";
            char SignPlayer1 = 'x';
            char SignPlayer2 = 'o';
            char[,] table = new char[3, 3]
            {
                { '1', '2', '3' },
                { '4', '5', '6' },
                { '7', '8', '9' }
            };

            Console.Write("Enter Player 1 name: ");
            NamePlayer1 = Console.ReadLine();
            Console.Write("Enter Player 2 name: ");
            NamePlayer2 = Console.ReadLine();

            // ...
        }
    }
}
