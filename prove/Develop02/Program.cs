using System;

class Program
{
    static void Main(string[] args)
    {

        int response = 0;
        while (response != 5)
        {
            Console.Write("Please select one of the following choice: \n1.Write \n2.Display \n3.Load \n4.Save \n5.Quit \nWhat would you like to do? ");
            response = int.Parse(Console.ReadLine());

            if (response == 1)
        }

        Journal journal = new Journal();

        PromptGenerator prompt = new PromptGenerator();
        prompt._prompts.Add("Who was the most interesting person I interacted with today?");
        prompt._prompts.Add("What was the best part of my day?");
        prompt._prompts.Add("How did I see the hand of the Lord in my life today?");
        prompt._prompts.Add("What was the strongest emotion I felt today?");
        prompt._prompts.Add("If I had one thing I could do over today, what would it be?");

        //Console.WriteLine(prompt.GetRamomPrompt());

        Entry entry = new Entry();
        DateTime theCurrentTime = DateTime.Now;
        entry._date = theCurrentTime.ToShortDateString();
        entry._promptText = prompt.GetRamomPrompt();
        entry._entryText = "I wrote this";
        journal.AddEntry(entry);
        //entry.Display();
        Entry entry2 = new Entry();
        DateTime theCurrentTimes = DateTime.Now;
        entry2._date = theCurrentTimes.ToShortDateString();
        entry2._promptText = prompt.GetRamomPrompt();
        entry2._entryText = "I wrote this again";
        journal.AddEntry(entry2);
        journal.DisplayAll();

        journal.SaveToFile("firstJournal.txt");

        entry._date = theCurrentTime.ToShortDateString();
        entry._promptText = prompt.GetRamomPrompt();
        entry._entryText = "I wrote this so lets be it";
        journal.DisplayAll();

        journal.LoadFromFile("firstJournal.txt");
        journal.DisplayAll();

    }
}