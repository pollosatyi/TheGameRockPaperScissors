using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGameRockPaperScissors
{
    public class HumanPlayer : Player
    {
        public override int MakeMove()
        {
            PrintMenu();
            string stepPlayerStr = Console.ReadLine();
            if (!CheckInputForInt(stepPlayerStr, out int stepPlayer)) { Console.WriteLine("Это не число"); return MakeMove(); }
            if (!CheckInputForCorrectNumber(stepPlayer)) { Console.WriteLine("Неверный номер команды"); return MakeMove(); }
            return stepPlayer;
        }



        private bool CheckInputForInt(string stepPlayerStr, out int stepPlayer)
        {
            if (int.TryParse(stepPlayerStr, out stepPlayer)) return true;
            return false;
        }


        private bool CheckInputForCorrectNumber(int stepPlayer) => stepPlayer >= 1 && stepPlayer <= 3;


        private void PrintMenu()
        {
            Console.WriteLine($"игрок {Name} делает ход");
            Console.WriteLine("Нажмите 1, чтобы выбрать камень");
            Console.WriteLine("\t  2,чтобы выбрать ножницы");
            Console.WriteLine("\t  3,чтобы выбрать ножницы");
            Console.WriteLine("Сделайте ход: ");
        }


        
    }
}
