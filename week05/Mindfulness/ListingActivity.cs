 public class ListingActivity : Activity
 {
     private int _count;
     private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
     public ListingActivity(string name ="Listing Activity", string description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") 
         : base(name, description)
     {
        
     }
     public void Run()
     {
        DisplayStartingMessege();

        Console.WriteLine("List as many responses you can to the following prompt: ");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();

        _count = GetListFromUser().Count();
        Console.WriteLine($"You listed {_count} items!");

        DisplayEndingMessege();
     }
     public void GetRandomPrompt()
     {
        Random randomGenerator = new Random();
        int i = randomGenerator.Next(0, _prompts.Count);
        Console.WriteLine($"--- {_prompts[i]} ---");
     }
     public List<string> GetListFromUser()
     {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        List<string> _userAnswers = new List<string>();

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string answer = Console.ReadLine();
            _userAnswers.Add(answer);
        }

        return _userAnswers;
     }
 }