namespace TheGameRockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Игра Камень, Ножницы, Бумага");
            bool isGameWork=true;
            while (isGameWork)
            {
                Console.WriteLine("0 для выхода");
                Console.WriteLine("1 для игры человек против компьютера");
                Console.WriteLine("2 для игры человек против человека");
                Console.WriteLine("3 для игры компьютер против компьютера");
                Console.WriteLine("Введите число: ");
                if(int.TryParse(Console.ReadLine(),out int gameNumber))
                {
                    switch(gameNumber)
                    {
                        case 0:isGameWork = false; break;
                        case 1:  break;

                    }

                }
                else
                {
                    Console.WriteLine("Это не число.Введите заново");
                }
            }
        }
    }
}
