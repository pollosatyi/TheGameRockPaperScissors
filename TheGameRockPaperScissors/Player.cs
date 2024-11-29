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

        public abstract void GetNamePlayer();

        public abstract int MakeMove();

        //public Player(string name)
        //{
        //    Name = name;
        //}
    }
}
