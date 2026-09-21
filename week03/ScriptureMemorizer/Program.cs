using System;

class Program
{
    static void Main(string[] args)
    {
        bool keepRunning = true;
        
        Reference reference = new Reference("Proverbs ", 3, 5, 6);
        string scriptureText = "Trust in the Lord with all thine heart; and lean not unto thine own understanding; In all thy ways acknowledge him, and he shall direct thy paths.";
        Scripture scripture = new Scripture(reference, scriptureText);

        while(keepRunning)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            string answer = Console.ReadLine();

            if (answer != "quit")
            {
                if (scripture.IsCompletelyHidden())
                {
                    keepRunning = false;
                }
                scripture.HideRandomWords(5);
            }
        }
    }
}