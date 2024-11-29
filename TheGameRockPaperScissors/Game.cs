using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGameRockPaperScissors
{
    public class Game
    {
        private Player _player1;
        private Player _player2;
        public Game(Player player1, Player player2)
        {
            _player1 = player1;
            _player2 = player2;
        }


        public  void StartGame()
        {
            _player1.GetNamePlayer();
            _player2.GetNamePlayer();
            PrintStart();
            bool IsPlayerWin = false;
            while (!IsPlayerWin)
            {
                int stepPlayer1 = _player1.MakeMove();
                PrintStepPlayer(stepPlayer1, _player1);
                if (typeof(AIPlayer) == _player1.GetType()) Thread.Sleep(3000);
                int stepPlayer2 = _player2.MakeMove();
                PrintStepPlayer(stepPlayer2, _player2);
                if (typeof(AIPlayer) == _player2.GetType()) Thread.Sleep(3000);
                if (stepPlayer1 == stepPlayer2)
                {
                    Console.WriteLine("Никто не выиграл");
                }
                else if (stepPlayer1 == 1 && stepPlayer2 == 2 || stepPlayer1 == 2 && stepPlayer2 == 3 || stepPlayer1 == 3 && stepPlayer1 == 1)
                {
                    PrintWinner(_player1); IsPlayerWin = true;
                }
                else
                {
                    PrintWinner(_player2); IsPlayerWin = true;
                }
            }


        }


        //public void StartGame(HumanPlayer player1, HumanPlayer player2)
        //{

        //}


        //public void StartGame(AIPlayer player1, AIPlayer player2)
        //{

        //}

        private void PrintStepPlayer(int stepPlayer, Player player)
        {
            switch (stepPlayer)
            {
                case 1: Console.WriteLine($"Игрок {player.Name} выбирает камень"); break;
                case 2: Console.WriteLine($"Игрок {player.Name} выбирает ножницы"); break;
                case 3: Console.WriteLine($"Игрок {player.Name} выбирает бумагу"); break;
            }

        }

        private void PrintWinner(Player player)
        {
            Console.WriteLine($"Игрок {player.Name} победил");
        }

        private  void PrintStart()
        {
            if(typeof(HumanPlayer)==_player1.GetType()&&typeof(AIPlayer)==_player2.GetType())
            Console.WriteLine($"Игра игрок человек {_player1.Name} против игрока компьютер {_player2.Name} началась");
            else if(typeof(HumanPlayer)==_player1.GetType()&& typeof(HumanPlayer) == _player2.GetType())
                Console.WriteLine($"Игра игрок человек {_player1.Name} против игрока человек {_player2.Name} началась");
            else
                Console.WriteLine($"Игра игрок компьютер {_player1.Name} против игрока компьютер {_player2.Name} началась");

        }

        //private  void PrintStart(HumanPlayer player1, HumanPlayer player2)
        //{
        //    Console.WriteLine($"Игра игрок человек {player1.Name} против игрока человек {player2.Name} началась");
        //}


        //private  void PrintStart(AIPlayer player1,AIPlayer player2)
        //{
        //    Console.WriteLine($"Игра игрок компьютер {player1.Name} против игрока компьютер {player2.Name} началась");

        //}

    }
}
