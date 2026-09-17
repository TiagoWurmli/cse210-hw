using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        int answer = 0;
        Journal journal = new Journal();

        while(answer != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            answer = int.Parse(Console.ReadLine());

            if(answer == 1)
            {
                Entry entry = new Entry();

                DateTime theCurrentTime = DateTime.Now;
                entry._date = theCurrentTime.ToShortDateString();

                PromptGenerator randomPrompt = new PromptGenerator();
                entry._promptText = randomPrompt.GetRandomPrompt();

                Console.WriteLine($"{entry._promptText}");
                entry._entryText = Console.ReadLine();

                journal.AddEntry(entry);

            }
            else if(answer == 2)
            {
                journal.DisplayAll();
            }
            else if(answer == 3)
            {
                Console.WriteLine("What is the filiname?");
                string fileName = Console.ReadLine();
                journal.LoadFromFile(fileName);
            }
            else if(answer == 4)
            {
                Console.WriteLine("What is the filiname?");
                string fileName = Console.ReadLine();
                journal.SaveToFile(fileName);
            }
        }
    }
}