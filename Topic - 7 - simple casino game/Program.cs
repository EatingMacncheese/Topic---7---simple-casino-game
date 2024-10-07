namespace Topic___7___simple_casino_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool done = false;
            int coinGuess, coinFlip, points;
            string playAgain;
            Random generator = new Random();
            coinFlip = generator.Next(1, 3);
            points = 3;
            Console.WriteLine("Welcom to to coin flip casino");
            Console.WriteLine("you have " + points + "points to spend");
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.WriteLine("You have 3 points to spend on a coin flip");
            Console.WriteLine("you get to call Heads or Tails and if your right you get a point");
            Console.WriteLine();
            Console.WriteLine("Press Enter to get flipping");
            Console.ReadLine();
            Console.Clear();
            
            while (!done)
            {
                --points;
                Console.WriteLine("Heads (1) or Tails (2)?");
                int.TryParse(Console.ReadLine(), out coinGuess);
                coinFlip = generator.Next(1, 3);

                if (coinFlip == 1)
                {
                    Console.WriteLine("heads");
                }
                else if (coinFlip == 2)
                {
                    Console.WriteLine("Tails");
                }
                if (coinGuess == 1 && coinFlip == 1)
                {
                    Console.WriteLine("you win 1 point");
                    ++points;
                }
                else if (coinGuess == 2 && coinFlip == 2)
                {
                    Console.WriteLine("you win 1 point");
                    ++points;
                }
                Console.WriteLine("flip again?");
                playAgain = Console.ReadLine().ToLower();
                if (playAgain == "no" || points == 0)
                {
                    done = true;

                }
                else if (playAgain == "yes")
                {
                    done = false;
                }
                if (points == 0)
                {
                    Console.WriteLine("you have no points, you can play anymore");
                }
                Console.WriteLine("you have " + points + " points");
                Console.WriteLine("Thanks for playing");
            }
        }
    }
}
