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

        //Console.WriteLine(prompt.GetRamomPrompt());

        Entry entry = new Entry();
        DateTime theCurrentTime = DateTime.Now;
        entry._date = theCurrentTime.ToShortDateString();
        entry._promptText = prompt.GetRamomPrompt();
        entry._entryText = "I wrote this";
        journal.AddEntry(entry);
        //entry.Display();
        DateTime theCurrentTimes = DateTime.Now;
        entry._date = theCurrentTimes.ToShortDateString();
        entry._promptText = prompt.GetRamomPrompt();
        entry._entryText = "I wrote this again";
        journal.AddEntry(entry);
        journal.DisplayAll();

    }
}