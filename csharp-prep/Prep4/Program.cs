using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int response;
        List<int> numberList = new List<int>();
        do
        {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            response = int.Parse(userInput);

            numberList.Add(response);
            
        } while (response != 0);

        int sum = 0;
        int largestNumber = 0;
        foreach (int number in numberList)
        {
            sum = sum + number;
            if (largestNumber < number)
            {
                largestNumber = number;
            }
        }

        int listLenght = numberList.Count - 1;
        float average = ((float)sum) / listLenght;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");

    }
}