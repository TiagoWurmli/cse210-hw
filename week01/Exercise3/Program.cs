using System;

class Program
{
    static void Main(string[] args)
    {
        // Fiz loops
        string playAgian = "";
        do
        {
            Console.Write("What is the magic number? ");
            int magicNumber = int.Parse(Console.ReadLine());
            int guessNumber = 0;
            int attempts = 0;

            do
            {
                Console.Write("What is your guess? ");
                guessNumber = int.Parse(Console.ReadLine());
                attempts ++;

                if (guessNumber == magicNumber)
                {
                    Console.WriteLine($"You guessed it! (Guess attempts: {attempts})");
                }
                else if (magicNumber > guessNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("Lower");
                }  
            } while (magicNumber != guessNumber);

            Console.Write("Do you want to play again? ");
            playAgian = Console.ReadLine();

        } while (playAgian == "yes");
    }
}