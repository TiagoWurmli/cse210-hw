using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs",3,5,6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thune heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.");

        bool isCompletelyHidden = scripture.IsCompletelyHidden();

        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("Press enter to continue or type 'quit' to finish");
        string userInput = Console.ReadLine();

        while(isCompletelyHidden == false){

            if(userInput == ""){

                scripture.HideRandomWords(3);
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("Press enter to continue or type 'quit' to finish");
                userInput = Console.ReadLine();
                isCompletelyHidden = scripture.IsCompletelyHidden();
            }
            else if(userInput == "quit"){
                isCompletelyHidden = true;
            }
            else{
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("Press enter to continue or type 'quit' to finish");
                userInput = Console.ReadLine();
            }
        }

        Console.WriteLine("Bye!");
    }
}