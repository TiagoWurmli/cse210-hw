using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        Console.WriteLine("What is the magic number?");

        int response;
        do
        {
            Console.Write("What is your guess? ");
            string userInput = Console.ReadLine();
            response = int.Parse(userInput);

            if (number < response)
            {
                Console.WriteLine("Lower");
            }
 
            else if (number > response)
            {
                Console.WriteLine("Higher");
            }

        } while (response != number); 

        Console.WriteLine("You guessed it!");

    }
}