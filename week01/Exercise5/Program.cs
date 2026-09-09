using System;

// Criar Função
// returnType FunctionName(dataType parameter1, dataType parameter2)
// {
    // function_body
// }
class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int square = SquareNumber(number);
        DisplayResult(name, square);

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int favoriteNumber = int.Parse(Console.ReadLine());
            return favoriteNumber;
        }

        static int SquareNumber(int number)
        {
            number = number*number;
            return number;
        }

        static void DisplayResult(string name, int number)
        {
            Console.Write($"{name}, the square of your number is {number}");
        }

    }
}
