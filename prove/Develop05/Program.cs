class Program
{
    static void Main(string[] args)
    {
        GoalTracker tracker = new GoalTracker();
        tracker.CreateGoal("simple", "Run a marathon", 1000);
        tracker.CreateGoal("eternal", "Read scriptures", 100);
        tracker.CreateGoal("checklist", "Attend the temple", 50, 10, 500);

        tracker.RecordEvent("Run a marathon");
        tracker.RecordEvent("Read scriptures");
        tracker.RecordEvent("Attend the temple");

        tracker.DisplayGoals();
        Console.WriteLine("Total Score: " + tracker.CalculateScore());

        // Saving and loading goals
        tracker.SaveGoals("goals.txt");
        tracker.LoadGoals("goals.txt");
    }
}
