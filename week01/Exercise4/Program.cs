using System;
using System.Collections.Generic;

// List: 
// for (int i = 0; i < words.Count; i++)
// {
//  Console.WriteLine(words[i]);
// }
// foreach (string word in words)
// {
//     Console.WriteLine(word);
// }
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int newNumber = 1;
        int totalSum = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (newNumber != 0)
        {
            Console.Write(" Enter number: ");
            newNumber = int.Parse(Console.ReadLine());
            if (newNumber != 0)
            {
                numbers.Add(newNumber);
            }
        }

        int largestNumber = numbers[0];
        int smallestPositive = numbers[0];

        foreach (int number in numbers)
        {
            totalSum += number;
            if (number > largestNumber)
            {
                largestNumber = number;
            }

            if (number > 0 && number < smallestPositive)
            {
                smallestPositive = number;
            }
        }

        float averege = (float)totalSum / numbers.Count;

        Console.WriteLine($"The sum is: {totalSum}");
        Console.WriteLine($"The average is: {averege}");
        Console.WriteLine($"The largest number is: {largestNumber}");
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        Console.WriteLine("The sorted list is:");

        numbers.Sort();
        foreach (int number in numbers)
        {
            Console.WriteLine($"{number}");
        }
    }
}