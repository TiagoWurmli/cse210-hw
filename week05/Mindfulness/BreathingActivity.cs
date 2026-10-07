public class BreathingActivity : Activity
{
    public BreathingActivity(string name ="Breathing Activity", string description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.") 
        : base(name, description)
    {
        
    }
    public void Run()
    {
        DisplayStartingMessege();
        for (int i = _duration; i > 0;)
        {
            int _breatheIn = 4;
            int _breatheOut = 6;

            if (i < 19 && i > 10)
            {
                _breatheIn = i/2;
                _breatheOut = i - _breatheIn;
            }

            Console.Write("Breathe in...");
            ShowCountDown(_breatheIn);
            Console.WriteLine();

            Console.Write("Now breathe out...");
            ShowCountDown(_breatheOut);
            Console.WriteLine("\n");

            Console.Clear();

            i = i - _breatheIn - _breatheOut;
        }

        DisplayEndingMessege();
    }
}