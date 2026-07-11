using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Guess The Number Game");

        Random randomGenerator = new Random();

        string playAgain ="yes";

        while (playAgain == "yes")
        {
            int guessCount = 0;
            
            int magicNumber = randomGenerator.Next(1, 101);

            Console.Write("What is your guess? ");
            int guess = int.Parse(Console.ReadLine());
            guessCount++;


            while (guess != magicNumber)
            {
                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("Lower");
                }
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;
            }
            
            Console.WriteLine("You guessed it!");
            Console.WriteLine($"You guessed the number in {guessCount} guess(es).");
            
            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine().ToLower();
        }
    }
       
}