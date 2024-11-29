

namespace TheGameRockPaperScissors
{
    public class AIPlayer : Player
    {
        public override int MakeMove()
        {
            PrintMenuStep();
            Random random = new Random();
            return random.Next() % 3 + 1;
        }


        public override void PrintMenuStep()
        {
            Console.WriteLine($"Игрок {Name} делает ход");
        }
    }
}
