using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGameRockPaperScissors
{
    public class AIPlayer : Player
    {
       

        public override int MakeMove()
        {
           
            Random random = new Random();
            return  random.Next() % 3+1;
        }

       

        public override void PrintMenuStep()
        {
            Console.WriteLine($"Игрок {Name} делает ход");
        }
    }
}
