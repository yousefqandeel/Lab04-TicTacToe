using System;
using Xunit;
using Lab04_TicTacToe;

namespace Lab04_Testing
{
    public class UnitTest1
    {
        [Fact]
        public void Test_Winner_1()
        {
            string[,] board = new string[,]
            {
                {"X", "2", "3"},
                {"4", "X", "6"},
                {"7", "8", "X"},
            };


            Game game = new Game(new Player(), new Player());
            game.Board.GameBoard = board;

            Assert.True(game.CheckForWinner(game.Board));
        }

        [Fact]
        public void Test_Winner_2()
        {
            string[,] board = new string[,]
            {
                {"X", "2", "O"},
                {"4", "X", "O"},
                {"7", "8", "O"},
            };


            Game game = new Game(new Player(), new Player());
            game.Board.GameBoard = board;

            Assert.True(game.CheckForWinner(game.Board));
        }

        [Fact]
        public void Test_Switch_Players()
        {
            Game game = new Game(new Player(), new Player());

            game.PlayerOne.IsTurn = true;

            game.SwitchPlayer();

            Assert.Equal(game.PlayerTwo, game.NextPlayer());

        }

    }
}