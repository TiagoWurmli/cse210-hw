using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradeString = Console.ReadLine();
        int gradePercentage = int.Parse(gradeString);
        
        if (gradePercentage >= 90) 
        {
            gradeString = "A";
        }

        else if (gradePercentage >= 80)
        {
            gradeString = "B";
        }

        else if (gradePercentage >= 70)
        {
            gradeString = "C";
        }

        else if (gradePercentage >= 60)
        {
            gradeString = "D";
        }

        else
        {
            gradeString = "F";
        }

        Console.WriteLine($"Your grade is {gradeString}.");

        if (gradeString == "A" || gradeString == "B" || gradeString == "C")
        {
            Console.WriteLine("You Pass!");
        }

        else
        {
            Console.WriteLine("You fail, good luck next time, you will need it!");
        }

    }
}