using System;

class Program
{ 
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        PromptGenerator prompt = new PromptGenerator();
        prompt._prompts.Add("Who was the most interesting person I interacted with today?");
        prompt._prompts.Add("What was the best part of my day?");
        prompt._prompts.Add("How did I see the hand of the Lord in my life today?");
        prompt._prompts.Add("What was the strongest emotion I felt today?");
        prompt._prompts.Add("If I had one thing I could do over today, what would it be?");

        int response = 0;
        while (response != 5)
        {
            Console.Write("Please select one of the following choice: \n1.Write \n2.Display \n3.Load \n4.Save \n5.Quit \nWhat would you like to do? ");
            response = int.Parse(Console.ReadLine());

            if (response == 1) {
                Entry entry = new Entry();

                DateTime theCurrentTime = DateTime.Now;
                entry._date = theCurrentTime.ToShortDateString();

                entry._promptText = prompt.GetRamomPrompt();
                Console.WriteLine(entry._promptText);
                entry._entryText = Console.ReadLine();

                journal.AddEntry(entry);
            }

            else if (response == 2) {
                journal.DisplayAll();
            }

            else if (response == 3) {
                Console.WriteLine("What is the filename?");
                string journalFile = Console.ReadLine();
                journal.LoadFromFile(journalFile);
            }

            else if (response == 4) {
                Console.WriteLine("What is the filename?");
                string journalFile = Console.ReadLine();
                journal.SaveToFile(journalFile);
            }

            else if (response ==5) {
                Console.WriteLine("Goodbye!");
            }

            else {
                Console.WriteLine("Please select a valid value.");
            }
        }
    }
}