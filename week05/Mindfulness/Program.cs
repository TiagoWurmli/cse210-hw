using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        int answer = 0;
        while(answer != 4)
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Start brathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            answer = int.Parse(Console.ReadLine());

            if(answer == 1)
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
            }
            else if(answer == 2)
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
            }
            else if(answer == 3)
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
            }
        }
    }
}