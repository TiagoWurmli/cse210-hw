using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        WritingAssignment assignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        string summary = assignment.GetSummary();
        string writingInformation = assignment.GetWritingInformation();
        Console.WriteLine(summary);
        Console.WriteLine(writingInformation);
    }
}