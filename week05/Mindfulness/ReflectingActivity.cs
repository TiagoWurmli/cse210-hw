using System.Formats.Asn1;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    public ReflectingActivity(string name ="Reflecting Activity", string description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.") 
        : base(name, description)
    {
        
    }
    public void Run()
    {
        DisplayStartingMessege();

        Console.WriteLine("Consider the following prompt: \n");
        DisplayPrompt();
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("\nNow ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();

        for (int i = _duration; i > 0;)
        {
            if (i < 10)
            {
                DisplayQuestions();
                ShowSpinner(i);
                i = 0;
            }
            else if (i < 20)
            {
                DisplayQuestions();
                ShowSpinner(i/2);
                Console.WriteLine();
                DisplayQuestions();
                ShowSpinner(i/2);
                Console.WriteLine();
                i = 0;
            }
            else
            {
                DisplayQuestions();
                ShowSpinner(10);
                Console.WriteLine();
                i -= 10;
            }
        }
        DisplayEndingMessege();
        
    }
    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int i = randomGenerator.Next(0, _prompts.Count);
        return _prompts[i];
    }
    public string GetRandomQuestion()
    {
        Random randomGenerator = new Random();
        int i = randomGenerator.Next(0, _questions.Count);
        return _questions[i];
    }
    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine($"--- {prompt} ---");
    }
    public void DisplayQuestions()
    {
        string question = GetRandomQuestion();
        Console.Write($"> {question}");
    }
}