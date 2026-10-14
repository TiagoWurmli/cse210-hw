using System.IO; 
public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    public GoalManager()
    {
        _score = 0;
    }
    public void Start()
    {
        
    }
    public void DisplayPlayerInfo()
    {
        foreach (Goal goal in _goals)
        {
            if (goal.IsComplete())
            {
                _score += goal.GetPoints();
            }
            Console.WriteLine("You have " + _score + " points.");
        }
    }
    public void ListGoalNames()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetName());
        }
    }
    public void ListGoalDetails()
    {
        int index = 1;
        Console.WriteLine("The goals are:");
        foreach (Goal goal in _goals)
        {
            string goalDetails = index + ". ";
            if (goal.IsComplete())
            {
                goalDetails += "[X] ";
            }
            else
            {
                goalDetails += "[ ] ";
            }
            goalDetails += goal.GetDetailsString();
            Console.WriteLine(goalDetails);

            index++;
        }
    }
    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Which type of goal would you like to create? ");
        string choice = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (choice == "1")
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (choice == "2"){
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (choice == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
    }
    public void RecordEvent()
    {
        Console.WriteLine("The goals are:");
        int index = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(index + ". " + goal.GetDetailsString());
            index++;
        }
        int beforeScore = _score;
        Console.Write("Which goal did you accomplish? ");
        int choice = int.Parse(Console.ReadLine());
        if (choice >= 1 && choice <= _goals.Count)
        {
            _score += _goals[choice - 1].RecordEvent();
        }
        Console.WriteLine("Congratulations! You have earned " + (_score - beforeScore) + " points!");
        Console.WriteLine("You now have " + _score + " points.");
    }
    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }
    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] goalTypes = line.Split(":");

            string goalType = goalTypes[0];

            string[] parts = goalTypes[1].Split(";");
            string name = parts[0];
            string description = parts[1];
            int points = int.Parse(parts[2]);
            if (goalType == "SimpleGoal")
            {
                bool isComplete = bool.Parse(parts[3]);
                _goals.Add(new SimpleGoal(name, description, points, isComplete));
            }
            else if (goalType == "EternalGoal")
            {
                _goals.Add(new EternalGoal(name, description, points));
            }
            else if (goalType == "ChecklistGoal")
            {
                int bonus = int.Parse(parts[3]);
                int target = int.Parse(parts[4]);
                int amountCompleted = int.Parse(parts[5]);
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus, amountCompleted));
            }
        }
    }
    public int GetScore()
    {
        return _score;
    }
}