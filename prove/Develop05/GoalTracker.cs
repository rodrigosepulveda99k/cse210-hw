public class GoalTracker
{
    private readonly List<Goal> _goals;

    public GoalTracker()
    {
        _goals = new List<Goal>();
    }

    public void CreateGoal(string goalType, string name, int value, params int[] args)
    {
        switch (goalType)
        {
            case "simple":
                _goals.Add(new SimpleGoal(name, value));
                break;
            case "eternal":
                _goals.Add(new EternalGoal(name, value));
                break;
            case "checklist":
                _goals.Add(new ChecklistGoal(name, value, args[0], args[1]));
                break;
            default:
                throw new ArgumentException("Invalid goal type.");
        }
    }

    public int RecordEvent(string goalName)
    {
        foreach (var goal in _goals)
        {
            if (goal.Name == goalName)
                return goal.RecordEvent();
        }
        throw new ArgumentException("Goal not found.");
    }

    public void DisplayGoals()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.DisplayStatus());
        }
    }

    public int CalculateScore()
    {
        int score = 0;
        foreach (var goal in _goals)
        {
            if (goal.Completed)
                score += goal.Value;
        }
        return score;
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var goal in _goals)
            {
                writer.WriteLine($"{goal.Name},{goal.Value},{goal.Completed}");
            }
        }
    }

    public void LoadGoals(string filename)
    {
        _goals.Clear();
        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                string name = parts[0];
                int value = int.Parse(parts[1]);
                bool completed = bool.Parse(parts[2]);
                Goal goal;
                if (parts.Length == 3)
                    goal = new SimpleGoal(name, value);
                else
                {
                    int targetCount = int.Parse(parts[3]);
                    int bonusValue = int.Parse(parts[4]);
                    goal = new ChecklistGoal(name, value, targetCount, bonusValue);
                }
                if (completed)
                    goal.RecordEvent(); 
                _goals.Add(goal);
            }
        }
    }
}
