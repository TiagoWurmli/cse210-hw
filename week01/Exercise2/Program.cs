using System;

class Program
{
    static void Main(string[] args)
    {
        //Pega a nota em porcentagem e transforma em letra de nota americana
        Console.Write("Insert the grade in percentage: ");
        string gradeString = Console.ReadLine();
        float gradeFloat = float.Parse(gradeString);

        string letterGrade = "F";
        string signalGrade = "";
        bool pass = false;

        // Logica pra transformar em letra e pra ver se passou
        if (gradeFloat >= 90)
        {
            letterGrade = "A";
            pass = true;
        }
        else if (gradeFloat >= 80)
        {
            letterGrade = "B";
            pass = true;
        }
        else if (gradeFloat >= 70)
        {
            letterGrade = "C";
            pass = true;
        }
        else if (gradeFloat >= 60)
        {
            letterGrade = "D";
        }

        // Logica pra Ver se é '+' ou '-'
        float residualGrade = gradeFloat % 10;

        if (residualGrade >= 7)
        {
            signalGrade = "+";
        }
        else if (residualGrade <= 3)
        {
            signalGrade = "-";
        }

        Console.WriteLine($"Your grade is {letterGrade}{signalGrade}");

        if (pass)
        {
            Console.WriteLine($"You pass! Congrats");
        }
        else
        {
            Console.WriteLine($"You fail... do better");
        }
    }
}