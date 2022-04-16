using System;

namespace Lab04_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tic-Tac-Toe!");
            StartGame();
        }
        static void StartGame()
        {
            Console.WriteLine("Enter Player #1 Name: ");
            string playerOneName = Console.ReadLine();

            Console.WriteLine($"Enter {playerOneName} Marker: ");
            string playerOneMarker = Console.ReadLine();

            Console.WriteLine("Enter Player #2 Name: ");
            string playerTwoName = Console.ReadLine();

            Console.WriteLine($"Enter {playerTwoName} Marker: ");
            string playerTwoMarker = Console.ReadLine();


            Player player1 = new Player();
            player1.Name = playerOneName;
            player1.Marker = playerOneMarker;

            Player player2 = new Player();
            player2.Name = playerTwoName;
            player2.Marker = playerTwoMarker;

            Game game = new Game(player1, player2);

            Player winner = game.Play();

            if (winner == null)
            {
                Console.WriteLine("D R A W !");
            }
            else
            {
                Console.WriteLine($"The Winner is {winner.Name}");
            }

        }
    }
}
