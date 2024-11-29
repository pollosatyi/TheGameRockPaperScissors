using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGameRockPaperScissors
{
    public abstract class Player
    {
        public string Name {  get; set; }

        public  void GetNamePlayer(int count)
        {
            Console.WriteLine($"Введите имя игрока {count}");
            string name = Console.ReadLine();
            if(name == "")
            {
                Name = $"player {count}";
            }
            else Name = name;
            
        }

        public abstract int MakeMove();


        public abstract void PrintMenuStep();

        //public Player(string name)
        //{
        //    Name = name;
        //}
    }
}
