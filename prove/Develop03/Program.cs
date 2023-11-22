using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs",3,5,6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thune heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.");
        
        scripture.HideRandomWords(3);
        
        Word word = new Word("");
        


    }
}